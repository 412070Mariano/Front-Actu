﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackCine.Data.Entities
{
    public partial class pa_analisis_ocupacionResult
    {
        [Column("Total Reservas")]
        public int? TotalReservas { get; set; }
        [Column("Total Compradas")]
        public int? TotalCompradas { get; set; }
        [Column("Porcentaje Ocupacion")]
        public string PorcentajeOcupacion { get; set; }
        [Column("Cliente con más Reservas")]
        public string ClienteconmásReservas { get; set; }
        [Column("Pelicula más Vista")]
        public string PeliculamásVista { get; set; }
        public int? ID_SALA { get; set; }
    }
}
