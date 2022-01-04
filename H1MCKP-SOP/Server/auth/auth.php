<?php
require_once("../database.php");

function checkAuth(){
    $header = apache_request_headers();
    $data=explode(" ",$header['Authorization']);
    return checkUser($data[1], $data[2]);
}
?>