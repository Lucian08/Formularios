using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Formularios
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=REGISTRO_ALUMNO;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No sea podido conectar con la base de datos" + ex.ToString());
            }


        }
        public string insertar(int Rut, string Nombre, string Apellido, string Direccion, string Ciudad, string Fecha_Nacimiento)
        {
            string salida = "Registro guardado con exito";
            try
            {
                cmd = new SqlCommand("Insert into DATOS_ALUMNO(Rut,Nombre,Apellido,Direccion,Ciudad,Fecha_Nacimiento) values(" + Rut + ",'" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Ciudad + "','" + Fecha_Nacimiento + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public int personaRegistrada(int id)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from DATOS_ALUMNO where Rut=" + id + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }



    }
}





