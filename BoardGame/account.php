<?php

include 'connect.php';
session_start();
// Kiểm tra đăng nhập
if (!isset($_SESSION['username'])) {
    header('location: login.php');
    exit;
}

$username = $_SESSION['username'];

// Lấy thông tin cá nhân của người dùng
$select_query = "SELECT * FROM customers WHERE USERNAME= '$username'";
$result = mysqli_query($conn, $select_query);

if (mysqli_num_rows($result) > 0) {
    $userInfo= mysqli_fetch_array($result);
}

// Xử lý dữ liệu gửi từ form
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $name = mysqli_real_escape_string($conn, $_POST['name']);
  $email = mysqli_real_escape_string($conn, $_POST['email']);
  $phone = mysqli_real_escape_string($conn,$_POST['phone']);
  $password = mysqli_real_escape_string($conn,$_POST['password']);
 
  // Cập nhật thông tin vào CSDL
  $sql = "UPDATE customers SET HOTEN='$name', email='$email', sdt='$phone', password='$password' WHERE username='$username'";
}

 //Lấy thông tin điểm tích lũy
 $select_query_score = "SELECT * FROM tich_diem WHERE USERNAME= '$username'";
 $result_score = mysqli_query($conn, $select_query_score);

 if (mysqli_num_rows($result_score) > 0) {
     $score= mysqli_fetch_array($result_score);
  // Lấy thông tin đơn hàng và số điểm đã sử dụng
  $select_query_score_used = "SELECT * FROM thue WHERE USERNAME= '$username'";
  $result_score_used = mysqli_query($conn,$select_query_score_used);
 
 }
?>

<!DOCTYPE html>
<html>

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang quản lý tài khoản cá nhân</title>
    <link rel="stylesheet" href="CSS/account.css">
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
    $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
    if ($username != "") { ?>
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
  <div class="container">
        <div class="account-sidebar">
            <ul>
                <li class="menu-item" data-content="history"><a href="#">Lịch sử đặt hàng</a></li>
                <li class="menu-item" data-content="personal-info"><a href="#">Thông tin cá nhân</a></li>
                <li class="menu-item" data-content="edit-info"><a href="#">Sửa đổi thông tin cá nhân</a></li>
                <li class="menu-item" data-content="points"><a href="#">Xem tích điểm cá nhân</a></li>
                <li class="menu-item" data-content="logout"><a href="#">Đăng xuất</a></li>
            </ul>
        </div>
        <div class="account-content">
        <div id="history" class="content-item">
                <!-- Nội dung cho Lịch sử đặt hàng -->
                <h2>Lịch sử đặt hàng</h2>
                <?php
                   $username = isset($_SESSION['username']) ? $_SESSION['username'] : "";
                   $query = "SELECT thue.ID_THUE, GROUP_CONCAT(TENSP SEPARATOR ', ') AS TENSP, SOLUONG, NGAYTHUE, TONGTIEN 
                             FROM thue
                             INNER JOIN thuegame ON thue.ID_THUE = thuegame.ID_THUE
                             WHERE username='$username'
                             GROUP BY thue.ID_THUE";

                  // Thực thi câu truy vấn
                  $result = mysqli_query($conn, $query);

                  // Kiểm tra và hiển thị kết quả
                  if (mysqli_num_rows($result) > 0) {
                    echo "<table>";
                    echo "<tr><th>Mã đơn hàng</th><th>Tên sản phẩm</th><th>Số lượng</th><th>Ngày thuê</th><th>Tổng tiền</th></tr>";
                    
                    while ($row = mysqli_fetch_assoc($result)) {
                      echo "<tr>";
                      echo "<td>" . $row['ID_THUE'] . "</td>";
                      echo "<td>" . $row['TENSP'] . "</td>";
                      echo "<td>" . $row['SOLUONG'] . "</td>";
                      echo "<td>" . $row['NGAYTHUE'] . "</td>";
                      echo "<td>" . $row['TONGTIEN'] . "</td>";
                      echo "</tr>";
                    }
                    
                    echo "</table>";
                  } else {
                    echo "Không có đơn hàng nào.";
                  }
                  // Đóng kết nối
                  mysqli_close($conn);
                  ?>
            </div>
            <div id="personal-info" class="content-item">
                <!-- Nội dung cho Thông tin cá nhân -->
                <h2>Thông tin cá nhân</h2>
                <p><strong>Họ và tên:</strong> <?php echo $userInfo['HOTEN']; ?></p>
                <p><strong>Tên đăng nhập:</strong> <?php echo $userInfo['USERNAME']; ?></p>
                <p><strong>Email:</strong> <?php echo $userInfo['email']; ?></p>
                <p><strong>Điện thoại:</strong> <?php echo $userInfo['sdt']; ?></p>
            </div>
            <div id="edit-info" class="content-item">
            <!-- Nội dung cho Sửa đổi thông tin cá nhân -->
            <h2>Sửa đổi thông tin cá nhân</h2>
            <form action="" method="post">
              <div class="form-group">
                <label for="name">Họ và tên:</label>
                <input type="text" id="name" name="name" value="<?php echo $userInfo['HOTEN']; ?>" required>
              </div>
                <div class="form-group">
                  <label for="username">Tên người dùng:</label>
                  <input type="text" id="username" name="username" value="<?php echo $userInfo['USERNAME']; ?>" required readonly>
                </div>

                <div class="form-group">
                  <label for="email">Email:</label>
                  <input type="email" id="email" name="email" value="<?php echo $userInfo['email']; ?>" required>
                </div>

                <div class="form-group">
                  <label for="phone">Số điện thoại:</label>
                  <input type="tel" id="phone" name="phone" value="<?php echo $userInfo['sdt']; ?>" required>
                </div>
                
                <div class="form-group">
                  <label for="password">Mật khẩu:</label>
                  <input type="password" id="password" name="password" required>
                </div>
                <button type="submit" class="btn-submit">Cập nhật thông tin</button>
              </form>
            </div>
            <div id="points" class="content-item">
              <!-- Nội dung cho Xem tích điểm cá nhân -->
              <h2>Xem tích điểm cá nhân</h2>
                <p><strong>Tên người dùng:</strong> <?php echo $score['USERNAME']; ?></p>
                <p><strong>Số điểm tích lũy:</strong> <?php echo $score['diem']; ?></p>
                <?php
                  if (mysqli_num_rows($result_score_used) > 0) {
                
                   echo "<table>";
                    echo "<tr><th>Mã đơn hàng</th><th>Tổng tiền</th><th>Số điểm tích lũy ban đầu</th><th>Số điểm tích lũy đã dùng</th><th>Số điểm tích lũy được cộng</th></tr>";
                    while ($row = mysqli_fetch_assoc($result_score_used)) {
                    $score_before = $row['diem'] + $score['diem'];
                    $score_new = intval($row['TONGTIEN'] / 10.000);
                    echo "<tr>";
                    echo "<td>" . $row['ID_THUE'] . "</td>";
                    echo "<td>" . $row['TONGTIEN'] . "</td>";
                    echo "<td>" . $score_before . "</td>";
                    echo "<td>" . $row['diem'] . "</td>";
                    echo "<td>" . $score_new . "</td>";
                    echo "</tr>";
                    }
                    echo "</table>";
                  } else {
                      echo "Không tìm thấy thông tin điểm cho người dùng $username";
                  }
                ?>
            </div>
            <div id="logout" class="content-item">
                <a href="confirm_logout.php">Click vào đây để đăng xuất</a>
            </div>

        </div>
    </div> 
    <script src="account.js"></script>
    <!-- end main -->
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
        </div>
         <!-- end foooter -->
</body>

</html>
