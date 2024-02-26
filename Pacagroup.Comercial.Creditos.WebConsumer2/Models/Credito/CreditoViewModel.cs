using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pacagroup.Comercial.Creditos.WebConsumer2.Models.Credito {
    public class CreditoViewModel {
        public int IdCredito { get; set; }

        public int TipoCredito { get; set; }

        public int IdCliente { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DiaPago { get; set; }

        public decimal Tasa { get; set; }

        public decimal Comision { get; set; }
    }//EndClass
}//EndNamespace