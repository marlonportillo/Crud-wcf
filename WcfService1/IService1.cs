using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataSet adduser(string name, string last_name, DateTime fecha, string email);

        [OperationContract]
        DataSet mostrar(int id_user);

        [OperationContract]

        DataSet delete(int id_user);

        [OperationContract]
        DataSet update(int id_user ,string name, string last_name, DateTime fecha, string email);
        // TODO: agregue aquí sus operaciones de servicio
    }


   
}
