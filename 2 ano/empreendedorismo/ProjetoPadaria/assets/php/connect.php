<?php
    try{
        $connect = mysqli_connect("localhost", "root", "vertrigo", "padaria");
        echo"<script>console.log('Conectou')</script>";
    } catch(Exception $e){
        echo"<script>console.log('Não conectou, erro $e')</script>";
    }
?>