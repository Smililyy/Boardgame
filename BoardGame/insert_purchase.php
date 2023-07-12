<?php
// Kết nối tới cơ sở dữ liệu
$servername = "localhost";
$username = "root";
$password ="" ;
$dbname = "boardgame";

$conn = mysqli_connect($servername, $username, $password, $dbname);

// Kiểm tra kết nối
if (!$conn) {
    die("Không thể kết nối đến cơ sở dữ liệu: " . mysqli_connect_error());
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $hoten = mysqli_real_escape_string($conn, $_POST["name"]);
    $sdt = mysqli_real_escape_string($conn, $_POST["phone"]);
    $point=mysqli_real_escape_string($conn, $_POST["point"]);
    $currentDate = date('Y-m-d'); 
    $existingNumbers = [];
    
    do {
        $randomNumber = str_pad(rand(0, 9999), 4, '0', STR_PAD_LEFT);
    } while (in_array($randomNumber, $existingNumbers));
    session_start();
    $_SESSION['randomNumber'] = $randomNumber;
    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
    $tt = "SELECT SUM(GIA* quantity) AS total FROM carts WHERE USERNAME='$username' GROUP BY USERNAME";
    $result = mysqli_query($conn, $tt);
    if(mysqli_num_rows($result) <= 0)
    { echo"Lỗi truy vấn ";}
    $row = mysqli_fetch_assoc($result);
    $tongtien = $row['total'];
    $point_retrieve= "SELECT diem,score_used FROM tich_diem WHERE USERNAME='$username' ";
    $result = mysqli_query($conn, $point_retrieve);
    $row = mysqli_fetch_assoc($result);
    $point_have = $row['diem'];
    $point_used=$row['score_used'];
    if ($point> $point_have)
    {
        echo '<script>alert("Số điểm tích lũy không đủ");window.location.href = "cart.php";</script>';
        exit;
    }
    else{
            $update_point="UPDATE tich_diem set diem= '$point_have'-'$point',score_used='$point_used'+'$point' where USERNAME= '$username'";
            $sql = "INSERT INTO thue (id_thue,username, ngaythue, tongtien, diem) VALUES ('$randomNumber','$hoten', '$currentDate', '$tongtien','$point')";
            $insert_tg = "INSERT INTO thuegame (id_thue, masp, tensp, soluong)
                    SELECT '$randomNumber', masp, tensp, quantity FROM carts";
            $delete_temp="delete from carts where USERNAME='$username'";
            if (mysqli_query($conn, $sql) && mysqli_query($conn,$insert_tg) && mysqli_query($conn,$delete_temp) && mysqli_query($conn,$update_point) ) {
                echo '<script>alert("Thanh toán thành công"); window.location.href = "purchase_infor.php";</script>';
                exit;
            } else {
                echo "Lỗi: " . $sql . "<br>" . mysqli_error($conn);
            }
        }
}

// Đóng kết nối
mysqli_close($conn);
?>
