using System.Collections.Generic;

using System.Linq;

using System.Data.SqlClient;

using Dapper;

using Pizzas.API.Models;


namespace Pizzas.API.Utils
{
    public static class BD
    {

        private static string CONNECTION_STRING=@"Server=A-PHZ2-AMI-008;DataBase=Pizzas;Trusted_Connection=True;";

        public static List<Pizza> GetAll()
        {

            string sqlQuery;

            List<Pizza> listaPizza;

            listaPizza = new List<Pizza>();

            using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
            {

                sqlQuery = "SELECT * FROM Pizzas";

                listaPizza = db.Query<Pizza>(sqlQuery).ToList();

            }

            return listaPizza;

        }
        public static Pizza GetById(int id)
        {
            string sqlQuery;

            Pizza pedido = null;

            sqlQuery = "SELECT * FROM Pizzas ";

            sqlQuery += "WHERE Id = @idPizza";

            using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
            {

                pedido = db.QueryFirstOrDefault<Pizza>(sqlQuery, new { idPizza = id });

            }

            return pedido;

        }
        public static int CreatePizza(Pizza pizza)
        {

            string sqlQuery;

            int cantCambios = 0;

            sqlQuery = "INSERT INTO Pizzas (";

            sqlQuery += " Nombre , LibreGluten , Importe , Descripcion";

            sqlQuery += ") VALUES (";

            sqlQuery += " @nombre , @libreGluten , @importe , @descripcion";

            sqlQuery += ")";

            using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
            {

                cantCambios = db.Execute(sqlQuery, new
                {

                    nombre = pizza.Nombre,

                    libreGluten =
                pizza.LibreGluten,

                    importe = pizza.Importe,

                    descripcion =
                pizza.Descripcion

                }

                );

            }

            return cantCambios;
        }
        public static int UpdateById(Pizza pizza)
        {

            string sqlQuery;

            int cantCambios = 0;

            sqlQuery = "UPDATE Pizzas SET ";

            sqlQuery += " Nombre = @nombre, ";

            sqlQuery += " LibreGluten = @libreGluten, ";

            sqlQuery += " Importe = @importe, ";

            sqlQuery += " Descripcion = @descripcion ";

            sqlQuery += "WHERE Id = @idPizza";

            using (var db = new SqlConnection(CONNECTION_STRING))
            {

                cantCambios = db.Execute(sqlQuery, new
                {

                    idPizza = pizza.Id,

                    nombre = pizza.Nombre,

                    libreGluten = pizza.LibreGluten,

                    importe = pizza.Importe,

                    descripcion = pizza.Descripcion

                }

                );

            }

            return cantCambios;
        }
        public static int DeleteById(int id)
        {

            string sqlQuery;

            int cantCambios = 0;

            sqlQuery = "DELETE FROM Pizzas WHERE Id = @idPizza";

            using (SqlConnection db = new SqlConnection(CONNECTION_STRING))
            {

                cantCambios = db.Execute(sqlQuery, new { idPizza = id });

            }

            return cantCambios;

        }
    }
}