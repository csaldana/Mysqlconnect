using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace mysqlconnect
{
     class Registro : MYSQL
    {

        public void MostrarRegistros()
        {

            this.abrirConnection(); //sql != Mysql ..... Sql = microsft mysql = oracle
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM registro", MyConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                int id = Convert.ToInt32(myReader["id"]);
                string codigo = myReader["codigo"].ToString();
                string nombre = myReader["nombre"].ToString();
                string telefono = myReader["telefono"].ToString();
                string email = myReader["email"].ToString();
                Console.WriteLine("id:" + id+"codigo:" + codigo+ "nombre:" + nombre+"telefono:" + telefono+"email:" + email);
            }
            myReader.Close();
            myReader = null;                  
            myCommand.Dispose();
            myCommand = null;
            this.cerrarConnection();
        }

        public void NuevoRegistro(){

            string codigo, nombre, telefono, email;
 
            Console.WriteLine("Dame el codigo:");
            codigo = Console.ReadLine();
            Console.WriteLine("dame el nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame el telefono:");
            telefono = Console.ReadLine();
            Console.WriteLine("Dame el email:");
            email = Console.ReadLine();

            this.abrirConnection();
            string sql = "INSERT INTO `registro` (`codigo`, `nombre`, `telefono`, `email`) VALUES ('" + codigo + "', '" + nombre + "', '" + telefono + "', '" + email + "')";
            this.ejecutarComando(sql);
            this.cerrarConnection();
        }
        public void EditarCodigoRegistro()
        {
            int id  = 50;
            string codigo;
            Console.WriteLine("ID a editar?");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el codigo:");
            codigo = Console.ReadLine();

            this.abrirConnection();
            string sql = "UPDATE `registro` SET `codigo`='" + codigo + "' WHERE (`id`='" + id + "')";
            this.cerrarConnection();

        }
        public void EditarNombreRegistro()
        {
            int id = 50;
            string nombre;
            Console.WriteLine("dame el nombre:");
            nombre = Console.ReadLine();

            this.abrirConnection();
            string sql = "UPDATE `registro` SET `nombre`='" + nombre + "' WHERE (`id`='" + id + "')";
            this.cerrarConnection();

        }
        public void EditarTelefonoRegistro()
        {
            int id = 50;
            string telefono;
            Console.WriteLine("Dame el telefono:");
            telefono = Console.ReadLine();

            this.abrirConnection();
            string sql = "UPDATE `registro` SET `telefono`='" + telefono + "' WHERE (`id`='" + id + "')";
            this.cerrarConnection();

        }
        public void EditarEmailRegistro()
        {
            int id = 50;
            string email;
            Console.WriteLine("Dame el email:");
            email = Console.ReadLine();

            this.abrirConnection();
            string sql = "UPDATE `registro` SET `email`='" + email + "' WHERE (`id`='" + id + "')";
            this.cerrarConnection();

        }
        public void eliminarRegitro(){
            this.abrirConnection();
            int id = 50;
            Console.WriteLine(" id a eliminar");
            id = Convert.ToInt32(Console.ReadLine());
            string sql ="DELETE FROM registro WHERE id =" + id;    
            this.ejecutarComando(sql);
            this.cerrarConnection();
            

        }
        public int ejecutarComando(string sql){
        
            MySqlCommand  myCommand = new MySqlCommand(sql, this.MyConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;

        }

      

    }
}
 
