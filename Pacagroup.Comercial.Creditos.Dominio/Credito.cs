using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio {

    [DataContract]
    public class Credito {

        [DataMember]
        public int IdCredito { get; set; }

        [DataMember]
        public int TipoCredito { get; set; }

        [DataMember]
        public int IdCliente { get; set; }

        [DataMember]
        public DateTime Fecha { get; set; }

        [DataMember]
        public decimal Monto { get; set; }

        [DataMember]
        public DateTime DiaPago { get; set; }

        [DataMember]
        public decimal Tasa { get; set; }

        [DataMember]
        public decimal Comision { get; set; }

    }//EndClass
}//EndNamespace
