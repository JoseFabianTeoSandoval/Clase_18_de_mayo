using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18_de_mayo.data.dataAcces
{
    internal class PDB
    {
        private string connectionString = "Server =localhost;Database=mi_base_datos;Uid=root;Pwd=Shyro#23112004";
        public bool Provarconeccion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                } catch (Exception ) 
                { 
                    return false; 
                }
            }
        }
    }
}
