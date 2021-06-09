# ConexaoBancoDeDados

Projeto iniciado para ajudar o meu colega de trabalho a realizar conexões de varios banco de dados só alterado a injeção de dados.

## C#
  Foi um projeto para aprender a todos os recursos de orientação a objeto.
  
  No projeto foi utilizado Herança , polimorfismo , interface, sobrescrita de construtores 
  classe abstrata , sobre carga de métodos.
  
## Como utilizar o código

## arquivo para stringConnection

  properties
  ``` 
    Data Source=ip,port
    Initial Catalog=bancodedados
    User ID=usuario
    Password=senha
  ```
  
    static void Main(string[] args)
        {
            //    //postgres
            //    "Provider = PostgreSQL OLE DB Provider; Data Source = myServerAddress; location = myDataBase; User ID = myUsername; password = myPassword";
            //    //Mysql
            //    "Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword";
            //    //SqlServer
            //    "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\dados\\NORTHWND.MDF;Integrated Security=True; Connect Timeout=30;User Instance=True";
            //    "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

            ReadPropertiesFile rfp = new ReadPropertiesFile("properties");
            Console.WriteLine(rfp.BuildString());

            // Caso for usar Mysql 
            // ConnectionMysql con = new ConnectionMysql(rfp.BuildString());
            // MysqlCommand command = new MysqlCommand();
            
            //caso for usar SqlServer
            ConnectionSql con = new ConnectionSql(rfp.BuildString());
            SqlCommand command = new SqlCommand();
            
            command.Connection = con.DbConnection();
            command.CommandText = "select * from tabela";

            CommandDB cmd = new CommandDB(con, command);

            DataTable dt = cmd.DataTable();

            Console.Write(dt.Rows[0]["Coluna1"] + " - ");
            Console.Write(dt.Rows[0]["Coluna2"]);
            Console.WriteLine("");
            Console.Write(dt.Rows[1]["Coluna1"] + " - ");
            Console.Write(dt.Rows[1]["Coluna2"]);

            Thread.Sleep(100000);
        }
  
  
## Autor
  Paulo César
