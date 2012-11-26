using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfRestServiceEncuestas {

    [DataContract]
    public class Cliente {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public int Telefono { get; set; }

    }

}
