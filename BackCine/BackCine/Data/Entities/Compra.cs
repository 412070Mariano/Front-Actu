﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BackCine.Data.Entities;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int IdEmpleado { get; set; }

    public DateTime FechaCompra { get; set; }

    public int IdCliente { get; set; }

    public int IdFormaPago { get; set; }

    public int IdTipoCompra { get; set; }

    public double? Descuento { get; set; }

    public virtual ICollection<DetallesCompra> DetallesCompras { get; set; } = new List<DetallesCompra>();
    [JsonIgnore]
    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}