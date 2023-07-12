<?php
include 'connect.php';
session_start();
if (!isset($_SESSION['username'])) {
    // Nếu chưa đăng nhập, trả về lỗi
    http_response_code(403);
    echo "Bạn cần đăng nhập trước khi thêm vào giỏ hàng.";
    exit();
}
$username=$_SESSION['username'];
if ($_SERVER["REQUEST_METHOD"] === "POST") {
    $masp = mysqli_real_escape_string($conn, $_POST["code"]);
    $name_product = mysqli_real_escape_string($conn, $_POST["name_product"]);
    $soluong = mysqli_real_escape_string($conn, $_POST["quantity"]);
    $gia = mysqli_real_escape_string($conn, $_POST["price"]);
    $mota = mysqli_real_escape_string($conn, $_POST["describe"]);
    // Kiểm tra xem sản phẩm đã có trong bảng carts của username đó chưa
    $select_query = "SELECT * FROM carts WHERE MASP = '$masp' ";
    $result = mysqli_query($conn, $select_query);

    if (mysqli_num_rows($result) > 0) {
        // Nếu sản phẩm đã tồn tại trong giỏ hàng của username đó, cập nhật số lượng
        $cartItem = $result->fetch_assoc();
        $update_query = "UPDATE carts SET quantity = quantity+1  WHERE MASP = '$masp' AND username = '$username'";
        mysqli_query($conn, $update_query);
    } else {
        // Nếu sản phẩm chưa tồn tại trong giỏ hàng của username đó, thêm mới vào bảng
        $quantity = 1;
        $insert_query = "INSERT INTO carts (MASP, TENSP, GIA, quantity, username) VALUES ('$masp', '$name_product', '$gia', '$soluong', '$username')";
        mysqli_query($conn, $insert_query);
    }
    header('Location: ' . $_SERVER['HTTP_REFERER']);
}


?>
