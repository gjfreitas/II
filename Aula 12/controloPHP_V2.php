<html>
    <body>
        <form action="controloPHP_V2.php" method="POST">
            <p>
                Defina o comando a executar.<br>
                O comando é inscrito na base de dados "reservatorio," na tabela "controlo"
            </p>
            <div>
                Y0:
                <input type="submit" name="Y0" value="Ativar">
                <input type="submit" name="Y0" value="Desativar">

                Y1:
                <input type="submit" name="Y1" value="Ativar">
                <input type="submit" name="Y1" value="Desativar">

                Y2:
                <input type="submit" name="Y2" value="Ativar">
                <input type="submit" name="Y2" value="Desativar">
            </div> 
        </form>
        <?php
            /* Conectando, escolhendo a base de dados */
            $link = mysqli_connect("localhost", "root", "123456", "reservatorio") or die("Não pude conectar: " . mysql_error());

            if(isset($_POST['Y0'])){
                if($_POST['Y0'] == 'Ativar'){
                    $Y0 = 1;
                }else{
                    $Y0 = 0;
                }

                $query = "INSERT INTO controlo SET Y0=" . $Y0;
                $result = mysqli_query($link, $query) or die("A query falhou: " . mysqli_error($link));
            }

            if(isset($_POST['Y1'])){
                if($_POST['Y1'] == 'Ativar'){
                    $Y1 = 1;
                }else{
                    $Y1 = 0;
                }

                $query = "INSERT INTO controlo SET Y1=" . $Y1;
                $result = mysqli_query($link, $query) or die("A query falhou: " . mysqli_error($link));
            }

            if(isset($_POST['Y2'])){
                if($_POST['Y2'] == 'Ativar'){
                    $Y2 = 1;
                }else{
                    $Y2 = 0;
                }

                $query = "INSERT INTO controlo SET Y2=" . $Y2;
                $result = mysqli_query($link, $query) or die("A query falhou: " . mysqli_error($link));
            }


            echo "------- Supervisao -------<br>Os valores lidos na base de dados sao:<br>";

            /* Fazendo a query SQL DE LEITURA DA BASE DE DADOS*/
            $query = "SELECT * FROM controlo order by id desc limit 1";
            $result = mysqli_query($link, $query) or die("A query falhou: " . mysqli_error($link));
            if ($result->num_rows > 0) {
                while($row = $result->fetch_assoc()) {
                    echo "id: " . $row["id"]."<br>";
                    echo "Y0: " . $row["Y0"]."<br>";
                    echo "Y1: " . $row["Y1"]."<br>";
                    echo "Y2: " . $row["Y2"]."<br>";
            }
            }
            /* Liberta o resultado */
            mysqli_free_result($result);
            /* Fecha a ligação à base de dados*/
            mysqli_close($link);
            ?>
    </body>
</html>