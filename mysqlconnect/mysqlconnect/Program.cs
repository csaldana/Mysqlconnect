using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace mysqlconnect
{
    class Program
    {
        static void Main(string[] args)
        {

            Registro registros = new Registro();
            string opcionUsuario = "";
           
            do{


            Console.WriteLine("Elija una accion a realizar para su base de datos: \n 1-Mostrar Informacion \n  2-Editar Registro \n  3- Eliminar Registro \n  4-nuevo \n 5- Salir");
           
            opcionUsuario = Console.ReadLine();
            if (opcionUsuario == "1")
            {
                registros.MostrarRegistros();

            }
            else if (opcionUsuario == "2")
            {
                  registros.EditarCodigoRegistro();
                  registros.EditarNombreRegistro();
                  registros.EditarTelefonoRegistro();
                  registros.EditarEmailRegistro();
                  Console.WriteLine("Registro Editado");
            }
           
            else if (opcionUsuario == "3")
            {
                
                registros.eliminarRegitro();
                Console.WriteLine("Eliminado");
            }
            else if (opcionUsuario == "4")
            {
                registros.NuevoRegistro();
                Console.WriteLine("Agregado");
            }

                Console.ReadKey();
                Console.Clear();

            }while(opcionUsuario != "5");  
                
            
            
        }
    }
}
