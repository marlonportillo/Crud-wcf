using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {


        string strconex = ConfigurationManager.ConnectionStrings["strConex"].ToString();
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter;

        public DataSet adduser(string name, string last_name, DateTime fecha, string email)
        {
            dataSet.Tables.Clear();
            sqlDataAdapter = new SqlDataAdapter("AddUser", strconex);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDataAdapter.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            sqlDataAdapter.SelectCommand.Parameters.Add("@last_name", SqlDbType.VarChar).Value = last_name;
            sqlDataAdapter.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            sqlDataAdapter.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            sqlDataAdapter.Fill(dataSet);


            return dataSet;
        }

        public DataSet delete(int id_user)
        {
            dataSet.Tables.Clear();
            sqlDataAdapter = new SqlDataAdapter("eliminar", strconex);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDataAdapter.SelectCommand.Parameters.Add("@iduser", SqlDbType.Int).Value = id_user;


            sqlDataAdapter.Fill(dataSet);


            return dataSet;
        }

        public DataSet mostrar(int id_user)
        {
            dataSet.Tables.Clear();
            sqlDataAdapter = new SqlDataAdapter("mostrar", strconex);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDataAdapter.SelectCommand.Parameters.Add("@iduser", SqlDbType.Int).Value = id_user;


            sqlDataAdapter.Fill(dataSet);


            return dataSet;
        }

        public DataSet update(int id_user, string name, string last_name, DateTime fecha, string email)
        {
            dataSet.Tables.Clear();
            sqlDataAdapter = new SqlDataAdapter("updateuser", strconex);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDataAdapter.SelectCommand.Parameters.Add("@iduser", SqlDbType.Int).Value = id_user;
            sqlDataAdapter.SelectCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            sqlDataAdapter.SelectCommand.Parameters.Add("@last_name", SqlDbType.VarChar).Value = last_name;
            sqlDataAdapter.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha;
            sqlDataAdapter.SelectCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            sqlDataAdapter.Fill(dataSet);


            return dataSet;
        }
    }
}
