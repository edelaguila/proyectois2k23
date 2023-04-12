﻿using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPC_Modelo
{
    class Conexion
    {

        public OdbcConnection conexion()
        {

            OdbcConnection conexion = new OdbcConnection("Dsn=ingSoftware");
            try
            {
                conexion.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conexion;
        }


        public void desconexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
        }
    }
}
