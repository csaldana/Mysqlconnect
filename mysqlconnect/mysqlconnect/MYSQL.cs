using System;
using MySql.Data.MySqlClient;

namespace mysqlconnect
{
    
    class MYSQL
    {
    protected MySqlConnection MyConnection;

    public MYSQL() { }

        protected void abrirConnection(){
            string connectionString="Server=localhost;" +
                "Database=Registro;"+
                "User ID=root;" +
                "Password=;" +
                "Pooling= false;";
            this.MyConnection = new MySqlConnection(connectionString);
            this.MyConnection.Open();
            
        }
        protected void cerrarConnection(){
                        this.MyConnection.Close(); 
                        this.MyConnection = null;
        
    }
    }
    }
