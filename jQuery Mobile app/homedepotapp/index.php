<?php 

include_once 'includes/header.php';

?>

<body> 

<div data-role="page" data-theme="e">

  <div data-role="header" data-position="fixed">
    <a data-rel="back" data-role="button">Back</a>
    <h1>Home Depot app</h1>
  </div><!-- /header -->
  
  <br>
  
  <h3 class="center-text">Home Depot user login here</h3>
  
  <div data-role="content">
            <form id="check-user" class="ui-body ui-body-a ui-corner-all" data-ajax="false" method="post" action="landingpage.php">
                <fieldset>
                    <div data-role="fieldcontain">
                        <label for="username">Enter your username:</label>
                        <input type="text" value="" name="username" id="username"/>
                    </div>                                  
                    <div data-role="fieldcontain">                                      
                        <label for="password">Enter your password:</label>
                        <input type="password" value="" name="password" id="password"/> 
                    </div>
                    <input type="submit" data-theme="b" name="submit" id="submit" value="Submit">
                </fieldset>
            </form>                              
        </div>
  
</div>


<?php

include_once 'includes/footer.php';



