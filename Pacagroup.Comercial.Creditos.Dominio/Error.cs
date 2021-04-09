﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Pacagroup.Comercial.Creditos.Dominio
{
    [DataContract]
    public class Error
    {
        [DataMember]
        public string CodigoError { get; set; }
        [DataMember]
        public string MensajeError { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}
