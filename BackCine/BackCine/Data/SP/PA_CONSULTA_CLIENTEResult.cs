﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackCine.Data.Entities
{
    public partial class PA_CONSULTA_CLIENTEResult
    {
        public int? Año { get; set; }
        public string Mes { get; set; }
        public int? cant_compras { get; set; }
        public decimal? total_facturado { get; set; }
        public decimal? mas_alta { get; set; }
    }
}