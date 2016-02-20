<?php
 session_start();
    
if($_SERVER["REQUEST_METHOD"] == "POST"){
   
    
    $username = $_SESSION["username"];
    
    $selectedarea = $_POST["select-native-1"];
    
    switch($selectedarea){
        case "2": $selectedarea = "Plumbing";
                    $expert = "Bob";
                    $rating = "3.4";
                    break;
        case "3": $selectedarea = "Build & Re-model";
                    $expert = "Clark";
                    $rating = "4.6";
                    break;
        case "4": $selectedarea = "Electrical";
                    $expert = "Ricky";
                    $rating = "4.3";
                    break;
        case "5": $selectedarea = "Flooring";
                    $expert = "Chris";
                    $rating = "4.2";
                    break;
        case "6": $selectedarea = "Doors & Windows";
                    $expert = "Mitchel";
                    $rating = "4.1";
                    break;
        case "7": $selectedarea = "Heating Cooling";
                    $expert = "Trent";
                    $rating = "3.9";
                    break;
        case "8": $selectedarea = "Kitchen";
                    $expert = "Brendan";
                    $rating = "4.1";
                    break;
        case "9": $selectedarea = "Lawns & Garden";
                    $expert = "Martin";
                    $rating = "4.1";
                    break;
        case "10": $selectedarea = "Outdoor";
                    $expert = "Mitchel Starc";
                    $rating = "3.2";
                    break;
        case "11": $selectedarea = "Paint";
                    $expert = "Johnson";
                    $rating = "4.1";
                    break;
                
                default :break;
   
                
    }
    

include_once 'includes/header.php';

?>

<body> 

<div data-role="page" data-theme="e">

  <div data-role="header" data-position="fixed">
    <a href="#" data-role="button">Back</a>
    <h1>Home Depot app</h1>
  </div><!-- /header -->
  
  <br>
  
  <h3 class="center-text">Welcome <?php echo $username;?></h3>
  
  <br>
  
  <h4 class="center-text">We currently have the following pros for <?php echo $selectedarea;?>
      
      <br>
      <br>
      <div class="last center-text">Name: <?php echo $expert;?>
          <br>
          <br>
          Rating:<?php echo $rating;?>
          <div class="ui-btn-text">
                <a class="ui-link-inherit" href="mailto:jdoe@foo.com">Send a message to <?php echo $expert;?></a>
        </div>
      </div>
  
  <?php

    include_once 'includes/footer.php';
}

else {
    
    header("Location: index.php");
}