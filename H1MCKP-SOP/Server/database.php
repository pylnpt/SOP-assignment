<?php

function connect() {
    $connection_string = "mysql:host=localhost;dbname=energy_db";
    $user = "root";
    $pwd = "";

    try {
        $conn = new PDO($connection_string, $user, $pwd);
        $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        
        return $conn;
    } catch(PDOException $e) {
        echo "Connection failed: " . $e->getMessage();
    }
}

function getAllEnergyDrinks() {
    $conn = connect();
    $response = array();
    $energy_drink = array();

    $raw_sql = "SELECT * FROM energy_drinks";

    foreach($conn->query($raw_sql) as $row) {
        $energy_drink['id'] = $row['id'];
        $energy_drink['brand'] = $row['brand'];
        $energy_drink['coffein_amount'] = $row['coffein_amount'];
        $energy_drink['price'] = $row['price'];
        $energy_drink['model'] = $row['model'];

        $response[] = $energy_drink;
    }

    header('Content-Type: application/json');
    echo json_encode($response);
}

function getEnergyDrinkById($id) {
    $conn = connect();
    $response = array();
    $energy_drink = array();

    $raw_sql = "SELECT * FROM energy_drinks WHERE id = $id";

    foreach($conn->query($raw_sql) as $row) {
        $energy_drink['id'] = $row['id'];
        $energy_drink['brand'] = $row['brand'];
        $energy_drink['coffein_amount'] = $row['coffein_amount'];
        $energy_drink['model'] = $row['model'];
        $energy_drink['price'] = $row['price'];
    }

    header('Content-Type: application/json');
    echo json_encode($energy_drink);
}

function addEnergyDrink(){
    $input = json_decode(file_get_contents('php://input'), true);
    $conn = connect();
    
    $raw_sql = "INSERT INTO energy_drinks (brand, coffein_amount, model, price)
                VALUES (?,?,?,?)";
    try{
        if($conn->prepare($raw_sql)->
        execute(array($input['brand'], $input['coffein_amount'], $input['model'], $input['price']))) {
            $response = array();
            $response['status']=1;
            $response['message']="Inserted successfully!";
            
            header('Content-Type: application/json');
            echo(json_encode($response));
            echo($input);
        }
        else{
            $response = array();
            $response['status'] = 0;
            $response['message'] = "Insert failed!";
            
            header('Content-Type: application/json');
            echo(json_encode($response));
            
        }   
    } catch(PDOException $e) {
        header("HTTP/1.1 400 Bad request");
    }
}
function deleteEnergyDrinkByID($id){
    $conn = connect();
    $raw_sql = "DELETE FROM energy_drinks WHERE id=$id";

    try {
        if($result=$conn->query($raw_sql)) {
            $response=array();
            $response['status']=1;
            $response['message']="Deleted successfully!";
            header('Content-Type: application/json');
            echo(json_encode($response));
        } 
        else {
            $response=array();
            $response['status']=0;
            $response['message']="Delete failed!";
            header('Content-Type: application/json');
            echo(json_encode($response));
        }   
    } catch(Exception $e) {
        header("HTTP/1.1 400 Bad request");
    }
}
function updateEnergyDrinkByID($id){
    $input = json_decode(file_get_contents('php://input'), true);
    $conn = connect();
    $raw_sql = "UPDATE energy_drinks SET brand=?, coffein_amount=?, model=?, price=? WHERE id=?";
    try {
        if($conn->prepare($raw_sql)->
        execute(array($input['brand'], $input['coffein_amount'], $input['model'], $input['price'], $id))) {
            $response=array();
            $response['status']=1;
            $response['message']="Updated successfully!";
            
            header('Content-Type: application/json');
            echo(json_encode($response));
        }
        else {   
            $response=array();
            $response['status']=0;
            $response['message']="Updated failed!";
            header('Content-Type: application/json');
            echo(json_encode($response));  
        }   
    } catch(PDOException $e) {
        header("HTTP/1.1 400 Bad request");
    }
}


function checkUser($username, $pwd) {
    $conn = connect();
   $raw_sql = "SELECT * FROM users WHERE username=? AND pwd=?";
   $sql_stmt=$conn->prepare($raw_sql);
   $sql_stmt->execute(array($username,$pwd));

   if ($sql_stmt->rowCount() == 1) {
       return True;
   }
   else return False;
}

?>