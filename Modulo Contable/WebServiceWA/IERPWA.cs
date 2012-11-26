using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Entidades;

namespace WebServiceWA
{
    [ServiceContract]
    public interface IERPWA
    {

        [OperationContract]
        Entity AutenticarSocio(String pUsuario, String pPassword);

        
    }
}
