<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="CSS/cart.css">
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
        <!-- end header -->
        <div id="main">
            <br>
            <div class="title-cart">
                <H2>THÔNG TIN ĐƠN HÀNG </H2>
            </div>
            <?php
            $query = ("SELECT * FROM carts where USERNAME='$username'");
            $result = mysqli_query($conn, $query);
            if (mysqli_num_rows($result) <=0) {
                echo "<div style='text-align: center;'><h2>Bạn chưa thực hiện đơn hàng nào.</h2></div>";
            } else {
    ?>
            <div class="cart">
            <table style="width:100%;">
                    <thead>
                        <tr>
                        <td>ID</td>
                        <td>Mã sản phẩm</td>
                        <td>Tên Sản Phẩm</td>
                        <td>Số lượng</td>
                        <td>Giá</td>
                        </tr>
                    </thead>
                    <tbody>
                    <?php
                        $index = 1;
                        while ($row = mysqli_fetch_assoc($result)) {?>
                        <tr>
                            <td><?php echo $index++; ?></td>
                            <td><?php echo $row['MASP']; ?></td>
                            <td><?php echo $row['TENSP']; ?></td>
                            <td><?php echo $row['quantity']; ?></td>
                            <td><?php echo $row['GIA'] . " VND"; ?></td>
                        </tr>

                       <?php }?>
                    </tbody>
                    </table>

            </div>
            <br><br>
            <div>
            <h2>Vui lòng nhập thông tin thuê BoardGame: </h2>
            <form action="insert_purchase.php" method="post">
                <div style="border: 1px solid #ccc; padding: 10px;">
                <div style="border-bottom: 1px solid #ccc; padding-bottom: 10px;">
                    <label class="cart" style="width: 50%;">Họ và tên:</label>
                    <input type="text" class="form-control" style="border: none; outline: none; width: 100%;" id="name" name="name" required>
                </div>
                <div style="border-bottom: 1px solid #ccc; padding-bottom: 10px;">
                    <label class="cart" style="width: 50%;">Số điện thoại:</label>
                    <input type="text" class="form-control" style="border: none; outline: none; width: 100%;" id="phone" name="phone" required>
                </div>
                <div style="border-bottom: 1px solid #ccc; padding-bottom: 10px;">
                <label class="cart" style="width: 50%;">Số điểm quy đổi: ( 10.000 vnđ= 1 điểm )</label>
                <input type="text" class="form-control" style="border: none; outline: none; width: 100%;" id="point" name="point" required>
                </div>
                </div>
                <button type="submit" class="btn">Lưu <i class="fas fa-shopping-cart"></i></button>
            </form>
            </div>  
    <?php
    }
    ?>
    <br><br>
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
</body>

</html>
