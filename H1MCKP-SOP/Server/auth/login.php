<?php

require_once('auth.php');
$response = [];

if (checkAuth()){
    $response["Status"] = "Authorized";    
} else {
    $response["Status"] = "Unauthorized";
}

echo(json_encode($response));

?>

