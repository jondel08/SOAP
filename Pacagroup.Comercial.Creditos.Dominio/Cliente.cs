﻿using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio {

    [DataContract]
    public class Cliente {

        [DataMember]
        public int idCliente {get; set;}

        [DataMember]
        public string Nombre { get; set;}

        [DataMember]
        public string ApellidoPaterno { get; set;}

        [DataMember]
        public string ApellidoMaterno { get; set;}

        [DataMember]
        public string TipoDocumento { get; set;}

        [DataMember]
        public string NumeroDocumento { get; set;}

        [DataMember]
        public string Sexo { get;set;}

        [DataMember]
        public DateTime FechaNac { get; set; }

        [DataMember]
        public string Direccion { get; set;}

        [DataMember]
        public string CodigoPostal {  get; set;}

        [DataMember]
        public string EstadoCivil { get; set;}
    }//EndClass
}//EndNamespace