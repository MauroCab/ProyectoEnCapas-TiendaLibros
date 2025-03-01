﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.Remoting;


namespace Datos
{
    public class DatosConexionBD
    {
        public SqlConnection conexion;

        public string cadenaConexion = @"Data Source=.\SQLEXPRESS;AttachDbFilename=
        D:\Data\TiendaLibrosBD.mdf;
        Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || 
                    conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                   
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
                    
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }



    }
}
