<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Trang chủ | BoardGame</title>
    <link rel="stylesheet" href="home.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css">
</head>
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
            <div class="container">
                    <div class="banner">
                        <img src="Sanpham/banner.jpg" alt="">
                    </div>            
               <!-- 1 --> 
               <div class="bang-sron">
                    <h2 class="new-arrival">HÀNG MỚI VỀ!</h2> 
                    <div class="title">
                    </div>
                    </div>
            <div class="main-product">                 
                    <div class="products"> 
                    <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=1"><img src="Sanpham\fantasy-flight-games-star-wars-outer-rim.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Outer Rim</h4>
                                <span>74.999</span>
                            </div>
                            <p>Mã SP: BG001 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Outer Rim">
                                    <input type="hidden" name="code" value="BG001">
                                    <input type="hidden" name="price" value="74.999">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=2"><img src="Sanpham\pic6961520.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Not That Movie</h4>
                                <span>24.999</span>
                            </div>
                            <p>Mã SP: BG002 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Not That Movie">
                                    <input type="hidden" name="code" value="BG002">
                                    <input type="hidden" name="price" value="24.999">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=3"><img src="Sanpham\zygomatic-best-of-werewolves-of-millers-hollow_2.png" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Best of Werewolves of Millers Hollow</h4>
                                <span>21.999</span>
                            </div>
                            <p>Mã SP: BG003 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Best of Werewolves of Millers Hollow">
                                    <input type="hidden" name="code" value="BG003">
                                    <input type="hidden" name="price" value="21.999">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>            
                </div>
            </div>
                 <!-- 2 -->
            <div class="main-product">
                <div class="products"> 
                <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=4"><img src="Sanpham\lucky-duck-games-nimalia.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Dixit: Odyssey Expansion</h4>
                                <span>34.99</span>
                            </div>
                            <p>Mã SP: BG004 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Dixit: Odyssey Expansion">
                                    <input type="hidden" name="code" value="BG004">
                                    <input type="hidden" name="price" value="34.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=5"><img src="Sanpham\space-cowboys-skull.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Skull</h4>
                                <span>24.99</span>
                            </div>
                            <p>Mã SP: BG005 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Skull">
                                    <input type="hidden" name="code" value="BG005">
                                    <input type="hidden" name="price" value="24.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=6"><img src="Sanpham\zygomatic-the-werewolves-of-millers-hollow-the-pac.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>The Werewolves of Millers Hollow: The Pact</h4>
                                <span>49.99</span>
                            </div>
                            <p>Mã SP: BG006 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="The Werewolves of Millers Hollow: The Pact">
                                    <input type="hidden" name="code" value="BG006">
                                    <input type="hidden" name="price" value="49.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>
                </div>
            </div>
                <!-- 3 -->
                <div class="bang-sron">
                    <h2 class="new-arrival">BOARDGAME PHỔ BIẾN TRONG TUẦN</h2> 
                    <div class="title">
                    </div>
                    </div>
            <div class="main-product">
                <div class="products"> 
                <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=7"><img src="Sanpham\mixlore-squid-game.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Squid Game</h4>
                                <span>29.990 </span>
                            </div>
                            <p>Mã SP: BG007 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Squid Game">
                                    <input type="hidden" name="code" value="BG007">
                                    <input type="hidden" name="price" value="29.990 ">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=8"><img src="Sanpham\hasbro-heroquest-the-mage-of-the-mirror.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>HeroQuest: The Mage of the Mirror</h4>
                                <span>49.99</span>
                            </div>
                            <p>Mã SP: BG008 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="HeroQuest: The Mage of the Mirror">
                                    <input type="hidden" name="code" value="BG008">
                                    <input type="hidden" name="price" value="49.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=9"><img src="Sanpham\cmon-marvel-united-guardians-of-the-galaxy-remix.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Marvel United: Guardians of the Galaxy Remix</h4>
                                <span>34.99</span>
                            </div>
                            <p>Mã SP: BG009 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Marvel United: Guardians of the Galaxy Remix">
                                    <input type="hidden" name="code" value="BG009">
                                    <input type="hidden" name="price" value="34.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>
   
                </div>
            </div>
                <!-- 4 -->
            <div class="main-product">
                <div class="products"> 
                <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=11"><img src="Sanpham\pegasus-spiele-beast.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Beast</h4>
                                <span>69.99</span>
                            </div>
                            <p>Mã SP: BG011 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Beast">
                                    <input type="hidden" name="code" value="BG011">
                                    <input type="hidden" name="price" value="69.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=12"><img src="Sanpham\fantasy-flight-games-arkham-horror-final-hour.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Arkham Horror: Final Hour</h4>
                                <span>39.99</span>
                            </div>
                            <p>Mã SP: BG012 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Arkham Horror: Final Hour">
                                    <input type="hidden" name="code" value="BG012">
                                    <input type="hidden" name="price" value="39.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=13"><img src="Sanpham\renegade-game-studios-legacy-of-yu-1.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Legacy of Yu</h4>
                                <span>59.99</span>
                            </div>
                            <p>Mã SP: BG013 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Legacy of Yu">
                                    <input type="hidden" name="code" value="BG013">
                                    <input type="hidden" name="price" value="59.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>   
                </div>
            </div>
                <!-- 5 -->
                <div class="bang-sron">
                    <h2 class="new-arrival">BOARDGAME THUÊ CHẠY NHẤT</h2> 
                    <div class="title">
                    </div>
                    </div>
            <div class="main-product">
                <div class="products"> 
                <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=14"><img src="Sanpham\inside-up-games-earth.jpg" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Earth</h4>
                                <span>49.99</span>
                            </div>
                            <p>Mã SP: BG014 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Earth">
                                    <input type="hidden" name="code" value="BG014">
                                    <input type="hidden" name="price" value="49.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=15"><img src="Sanpham\renegade-game-studios-my-fathers-work-1.png" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>My Fathers Work</h4>
                                <span>124.99</span>
                            </div>
                            <p>Mã SP: BG015 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="My Fathers Work">
                                    <input type="hidden" name="code" value="BG015">
                                    <input type="hidden" name="price" value="124.99">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>

                        <div class="product">   
                            <div class="image">
                                <a href="/BoardGame/product-details.php?id=16"><img src="Sanpham\fantasy-flight-games-twilight-imperium-prophecy-of.webp" alt=""></a>
                            </div>
                            <div class="product-info">
                                <h4>Twilight Imperium: Prophecy of Kings</h4>
                                <span>99.95</span>
                            </div>
                            <p>Mã SP: BG016 </p>
                            <div class="stars">
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-solid fa-star"></i>
                            <i class="fa-regular fa-star"></i>
                            </div>
                            <div class="pay">
                                <form action="save_to_cart.php" method="post">
                                    <input type="hidden" name="name_product" value="Twilight Imperium: Prophecy of Kings">
                                    <input type="hidden" name="code" value="BG016">
                                    <input type="hidden" name="price" value="99.95">
                                    <input type="hidden" name="describe" value="">
                                    <input type="hidden" name="quantity" value="1">
                                    <button type="submit" class="btn">Thêm vào giỏ <i class="fas fa-shopping-cart"></i></button>
                                </form>
                            </div>
                        </div>
   
            </div>
        </div>
                    </div>
                </div>   
            </div>
            </div>
        </div>
        <!-- end main -->
        <div div id="footer">
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
    </div>
</body>

</html>
