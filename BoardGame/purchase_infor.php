<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="CSS/purchase.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
<body>
<header>
    <div class="logo">BOARDGAME</div>
    <nav>
      <ul>
        <li><a href="index.php">Trang chủ</a></li>
        <li><a href="product.php">Sản phẩm</a></li>
        <li>
          <a href="#">Thể loại</a>
          <!-- Thêm danh sách cho mục "Thể loại" -->
          <ul class="sub-menu">
            <li><a href="cardgame.php">Card Games</a></li> 
            <li><a href="dicegame.php">Dice Games</a></li> 
            <li><a href="chess.php">Chess</a></li> 
            <li><a href="family.php">Family</a></li> 
            <li><a href="livingcardgame.php">Living Card Games</a></li> 
            <li><a href="deckbuilders.php">Deckbuilders</a></li> 
            <li><a href="wargame&strategy.php">Wargame & Strategy</a></li> 
            <li><a href="cooperative.php">Cooperative</a></li> 
            <li><a href="dungeoncral&minis.php">Dungeon Crawl & Minis</a></li> 
            <li><a href="partygames.php">Party Games</a></li> 
            <li><a href="starwars.php">Star Wars</a></li> 
          </ul>
        </li>
        <li><a href="contact.php">Liên hệ</a></li>
        <li><a href="account.php">Tài khoản</a></li>
      </ul>
    </nav>
    <div class="search-bar">
      <input type="text" placeholder="Tìm kiếm">
      <button type="submit">Tìm kiếm</button>
    </div>
    <?php 
    session_start();
    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
    if ($username != "") { 
?>
<div class="account-icon">
    <i class="fas fa-user"></i>
    <span class="name">Xin chào, <?php echo $username ?></span>
</div>
<?php } else { ?>
<a href="login.php">
    <div class="account-icon">
        <i class="fas fa-user"></i>
    </div>
</a>
<?php } ?>
<div class="cart-icon">
  <a href="cart.php">
    <i class="fas fa-shopping-cart"></i>
    <span class="cart-count">
      <?php
        // Kết nối cơ sở dữ liệu và thực hiện truy vấn
        include 'connect.php';
        $query = "SELECT SUM(quantity) AS totalQuantity FROM carts";
        $result = mysqli_query($conn, $query);
        $row = mysqli_fetch_assoc($result);
        $cartItemCount = $row['totalQuantity'];
        
        // Hiển thị tổng số sản phẩm trong giỏ hàng
        echo $cartItemCount;
      ?>
    </span>
  </a>
</div>
  </header>
  <div id="main">
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
            //session_start();
            $randomNumber = $_SESSION['randomNumber'];
            $sql = "SELECT t.ID_THUE,t.USERNAME,t.NGAYTHUE,t.TONGTIEN,tg.TENSP,tg.SOLUONG FROM THUE t JOIN THUEGAME tg ON t.ID_THUE=tg.ID_THUE  WHERE t.id_thue='$randomNumber'";
            $TT="SELECT * from thue WHERE id_thue='$randomNumber'";
            $result = mysqli_query($conn, $sql);
            if ($result) {
                if (mysqli_num_rows($result) > 0) { ?>
                <br><br><br>
                <div class="title-cart">
                    <h2>Thông tin hóa đơn (vui lòng chụp lại mang theo để xác nhận):</h2>
                    <table class="invoice-table">
                    <thead>
                    <tr>
                    <th>Mã Hóa Đơn</th>
                    <th>Họ Và Tên</th>
                    <th>Ngày Thuê</th>
                    <th>Tên Sản Phẩm</th>
                    <th>Số lượng</th>
                    </tr>
                    </thead>
                    <tbody>
                <div>
                <?php
                    while ($row = mysqli_fetch_assoc($result)) {
                        echo '<tr>';
                        echo '<td>' . $row['ID_THUE'] . '</td>';
                        echo '<td>' . $row['USERNAME'] . '</td>';
                        $ngayThue = date('d-m-Y', strtotime($row['NGAYTHUE']));
                        echo '<td>' . $ngayThue . '</td>';
                        
                        echo '<td>' . $row['TENSP'] . '</td>';
                        echo '<td>' . $row['SOLUONG'] . '</td>';
                        echo '</tr>';
                    }
                    
                    echo '</tbody>';
                    echo '</table>';
                    $res=mysqli_query($conn, $TT);
                    $tt=mysqli_fetch_assoc($res);
                    // Tính điểm và cập nhật vào bảng tich_diem
                    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
                    $tongTien = $tt['TONGTIEN'];
                    $diem = intval($tongTien / 10.000);

                    $select_query = "SELECT * FROM tich_diem WHERE USERNAME = '$username'";
                    $select_result = mysqli_query($conn, $select_query);

                    if (mysqli_num_rows($select_result) > 0) {
                        // Nếu username đã tồn tại trong bảng tich_diem, cập nhật điểm
                        $update_query = "UPDATE tich_diem SET diem = diem + $diem WHERE USERNAME = '$username'";
                        mysqli_query($conn, $update_query);
                    } else {
                        // Nếu username chưa tồn tại trong bảng tich_diem, thêm mới
                        $insert_query = "INSERT INTO tich_diem (USERNAME, diem) VALUES ('$username', $diem)";
                        mysqli_query($conn, $insert_query);
                    }
                ?>
                    <div style="text-align: right;">
                        <h2 style="margin-top: 20px;">TỔNG TIỀN: <?php echo $tt['TONGTIEN'] . ' VND'; ?></h2>
                    </div>
                <?php
                } else {
                    echo '<p>Không tìm thấy dữ liệu.</p>';
                }
                
            } else {
                echo 'Lỗi: ' . mysqli_error($conn);
            }

            // Đóng kết nối
            mysqli_close($conn);
            ?>
        </div>
        </div>
        <div id="footer">
        <div class="container">
            <div class="row">
                <div class="footer-col">
                    <h4>Thông tin</h4>
                    <ul>
                        <li><a href="contact.php">Liên hệ</a></li>
                        <li><a href="policy.php">Chính sách</a></li>
                        <li><a href="https://www.google.com/maps/search/Duong+Hàn+Huyên,+Khu+pho+6,+Phuong+Linh+Trung,+Tp.Thù+Đức,+Tp.HCM"  target="_blank"Đường Hàn Huyên, Khu phố 6, Phường Linh Trung, Tp.Thủ Đức, Tp.HCM>Địa chỉ</a></li>
                        <li><a href="respond.php">Phản hồi</a></li>
                    </ul>
                </div>
                <div class="footer-col">
                    <h4>Theo dõi chúng tôi</h4>
                    <div class="social-links">
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="fab fa-instagram"></i></a>
                        <a href="#"><i class="fab fa-linkedin-in"></i></a>
                    </div>
                </div>
            </div>
        </div>
</body>

</html>

