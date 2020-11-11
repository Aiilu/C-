using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;
        public PersonaDAO()
        {
            //Serie de datos para conectarse a la base de datos
            this.connectionString = "Server=.;Database=TablaPersona;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString); //Se encarga de realizar la conexion.
        }

        public void GuardarPersona(Persona persona)
        {
            try
            {
                string command = "INSERT INTO Persona (Nombre, Apellido) VALUES (@NombreIdent, @ApellidoIdent)";
                //sqlCommand.CommandText

                //Para insertar secuencias INSERT en base de datos.
                //Ejecuta comandos en la base de datos.
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //Lo que esta aca lo va a interpretar como un valor si o si, y no como una secuencia SQL.
                //Lo que pasaria si pusieramos directamente la propiedad.
                sqlCommand.Parameters.AddWithValue("NombreIdent", persona.Nombre); //Como voy a identificar a este parametro.
                sqlCommand.Parameters.AddWithValue("ApellidoIdent", persona.Apellido);

                //Abrimos la conexion
                this.sqlConnection.Open();

                //Ejecutar sentencias que no son Querys, osea, no consultas, no select. Para insert, update y delete.
                sqlCommand.ExecuteNonQuery(); //Asi devuelve la cantidad de filas afectadas.
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public List<Persona> LeerPersonas()
        {
            List<Persona> lista = new List<Persona>();

            try
            {
                string command = "SELECT * FROM Persona";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                this.sqlConnection.Open();

                SqlDataReader read = sqlCommand.ExecuteReader(); //No se instancia, lo hace el execute. Como el nonquery, pero para leer.
                                                                 //El execute trae los datos y los encapsula en el reader.

                while(read.Read()) //Devuelve true si hay filas, si pudo leer
                {
                    //int id = (int) read["ID"]; //Indexador que trae el valor de esa columna en especifico

                    Persona persona = new Persona(read.GetInt32(0), read.GetString(1), read.GetString(2));

                    lista.Add(persona);
                }
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }

            return lista;
        }

        public Persona LeerPersonasID(int id)
        {
            Persona persona = null;

            try
            {
                string command = "SELECT * FROM Persona WHERE ID=@IdIdent";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                this.sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("IdIdent", id);

                SqlDataReader read = sqlCommand.ExecuteReader(); //No se instancia, lo hace el execute. Como el nonquery, pero para leer.
                                                                 //El execute trae los datos y los encapsula en el reader.

                if(read.Read())
                {
                    //int id = (int) read["ID"]; //Indexador que trae el valor de esa columna en especifico

                    persona = new Persona(read.GetInt32(0), read.GetString(1), read.GetString(2));
                }
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }

            return persona;
        }

        public void ModificarPersona(Persona persona)
        {
            try
            {
                string command = "UPDATE Persona SET Nombre=@NombreIdent, Apellido=@ApellidoIdent WHERE ID=@IdIdent";
                //sqlCommand.CommandText

                //Para insertar secuencias INSERT en base de datos.
                //Ejecuta comandos en la base de datos.
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //Lo que esta aca lo va a interpretar como un valor si o si, y no como una secuencia SQL.
                //Lo que pasaria si pusieramos directamente la propiedad.
                sqlCommand.Parameters.AddWithValue("NombreIdent", persona.Nombre); //Como voy a identificar a este parametro.
                sqlCommand.Parameters.AddWithValue("ApellidoIdent", persona.Apellido);
                sqlCommand.Parameters.AddWithValue("IdIdent", persona.ID);

                //Abrimos la conexion
                this.sqlConnection.Open();

                //Ejecutar sentencias que no son Querys, osea, no consultas, no select. Para insert, update y delete.
                sqlCommand.ExecuteNonQuery(); //Asi devuelve la cantidad de filas afectadas.
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void EliminarPersona(int id)
        {
            try
            {
                string command = "DELETE FROM Persona WHERE ID=@IdIdent";
                //sqlCommand.CommandText

                //Para insertar secuencias INSERT en base de datos.
                //Ejecuta comandos en la base de datos.
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //Lo que esta aca lo va a interpretar como un valor si o si, y no como una secuencia SQL.
                //Lo que pasaria si pusieramos directamente la propiedad.

                sqlCommand.Parameters.AddWithValue("IdIdent", id);

                //Abrimos la conexion
                this.sqlConnection.Open();

                //Ejecutar sentencias que no son Querys, osea, no consultas, no select. Para insert, update y delete.
                sqlCommand.ExecuteNonQuery(); //Asi devuelve la cantidad de filas afectadas.
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

    }
}
