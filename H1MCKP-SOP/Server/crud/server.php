<?php 
require_once('../database.php');
require_once('../auth/auth.php');

$request_method = $_SERVER["REQUEST_METHOD"];
$headers = apache_request_headers();

switch($request_method) {
    case 'GET':
        if (empty($_GET["id"])) {
            getAllEnergyDrinks();
          }
          else {
              $id=$_GET["id"];
              getEnergyDrinkByID($id);
          }
        break;
    case 'POST':
        if(checkAuth()){
            addEnergyDrink();
        }
        break;
    case 'PUT':
        if(checkAuth()){
            $id=$_GET["id"];
            updateEnergyDrinkByID($id);
        }
        break;
    case 'DELETE':
        if(checkAuth()){
            $id=$_GET["id"];
            deleteEnergyDrinkByID($id);
        }
        break;
}


