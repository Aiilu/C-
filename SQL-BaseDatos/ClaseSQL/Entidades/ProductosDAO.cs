using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductosDAO
    {
        private SqlConnection sqlConnection;
        private string connectionString;
        public ProductosDAO()
        {
            //Serie de datos para conectarse a la base de datos
            this.connectionString = "Server=.;Database=ProductosDB;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString); //Se encarga de realizar la conexion.
        }

        public void InsertarProductos(Producto producto)
        {
            try
            {
                string command = "INSERT INTO Productos (Nombre, Precio, Codigo) VALUES (@NombreIdent, @PrecioIdent, @CodigoIdent)";
                //sqlCommand.CommandText

                //Para insertar secuencias INSERT en base de datos.
                //Ejecuta comandos en la base de datos.
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //Lo que esta aca lo va a interpretar como un valor si o si, y no como una secuencia SQL.
                //Lo que pasaria si pusieramos directamente la propiedad.
                sqlCommand.Parameters.AddWithValue("NombreIdent", producto.Nombre); //Como voy a identificar a este parametro.
                sqlCommand.Parameters.AddWithValue("PrecioIdent", producto.Precio);
                sqlCommand.Parameters.AddWithValue("CodigoIdent", producto.Codigo);

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

        public void ModificarProductos(Producto producto)
        {
            try
            {
                string command = "UPDATE Productos SET Nombre=@NombreIdent, Precio=@PrecioIdent, Codigo=@CodigoIdent, Descripcion=@DescripcionIdent WHERE ID=@IdIdent";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("NombreIdent", producto.Nombre); //Como voy a identificar a este parametro.
                sqlCommand.Parameters.AddWithValue("PrecioIdent", producto.Precio);
                sqlCommand.Parameters.AddWithValue("CodigoIdent", producto.Codigo);
                sqlCommand.Parameters.AddWithValue("DescripcionIdent", producto.Descripcion);
                sqlCommand.Parameters.AddWithValue("IdIdent", producto.ID);

                this.sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                string command = "DELETE FROM Productos WHERE ID=@IdIdent";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("IdIdent", id);

                this.sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        public List<Producto> ListarProductos()
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos";
                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader(); //No se instancia, lo hace el execute. Como el nonquery, pero para leer.
                //El execute trae los datos y los encapsula en el reader

                List<Producto> productos = new List<Producto>();

                while (reader.Read()) //Leo iterativamente registro a registro. 
                {
                    int id = (int)reader["ID"];
                    string nombre = (string)reader["Nombre"];
                    string codigo = (string)reader["Codigo"];

                    string descripcion = null;

                    if (reader["Descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["Descripcion"];
                    }

                    float precio = (float)Convert.ToDouble(reader["Precio"]);

                    Producto producto = new Producto(id, codigo, nombre, precio, descripcion);

                    productos.Add(producto);
                }

                return productos;
            }
        }

        public Producto ListarProductosPorID(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
            {
                string command = "SELECT * FROM Productos WHERE ID=@IdIdent";

                SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

                sqlCommand.Parameters.AddWithValue("IdIdent", id);

                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader(); //No se instancia, lo hace el execute. Como el nonquery, pero para leer.
                                                                   //El execute trae los datos y los encapsula en el reader

                Producto producto = null;

                if (reader.Read()) //Leo iterativamente registro a registro. 
                {
                    id = (int)reader["ID"];
                    string nombre = (string)reader["Nombre"];
                    string codigo = (string)reader["Codigo"];

                    string descripcion = null;

                    if (reader["Descripcion"] != DBNull.Value)
                    {
                        descripcion = (string)reader["Descripcion"];
                    }

                    float precio = (float)Convert.ToDouble(reader["Precio"]);

                    producto = new Producto(id, codigo, nombre, precio, descripcion);
                }

                return producto;
            }
        }
    }
}