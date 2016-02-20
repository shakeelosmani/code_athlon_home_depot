<?php

session_start();
    
if($_SERVER["REQUEST_METHOD"] == "POST"){
    $userName = $_POST["username"];
    
    $_SESSION["username"] = $userName;
    

include_once 'includes/header.php';

?>

<body> 

<div data-role="page" data-theme="e">

  <div data-role="header" data-position="fixed">
    <a href="#" data-role="button">Back</a>
    <h1>Home Depot app</h1>
  </div><!-- /header -->
  
  <br>
  
  <h3 class="center-text">Welcome <?php echo $userName;?></h3>
  
  <form class="center-text" method="post" data-ajax="false" action="areaselected.php">
        <div class="ui-field-contain">
            <select name="select-native-1" id="select-native-1">
                <option value="1">Choose an area of concern</option>
                <option value="2">Plumbing</option>
                <option value="3">Build & Re-model</option>
                <option value="4">Electrical</option>
                <option value="5">Flooring</option>
                <option value="6">Doors & Windows</option>
                <option value="7">Heating Cooling</option>
                <option value="8">Kitchen</option>
                <option value="9">Lawns & Garden</option>
                <option value="10">Outdoor</option>
                 <option value="11">Paint</option>
            </select>
        </div>
       <input type="submit" data-theme="b" name="submit" id="submit" value="Submit">
</form>
  
</div>


<?php

include_once 'includes/footer.php';
}

else {
    
    header("Location: index.php");
}



