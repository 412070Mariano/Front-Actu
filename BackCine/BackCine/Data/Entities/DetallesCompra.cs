﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BackCine.Data.Entities;

public partial class DetallesCompra
{
    public int IdDetalleCompra { get; set; }

    public int IdCompra { get; set; }

    public decimal PrecioEntrada { get; set; }

    public int IdButaca { get; set; }

    public int IdFuncion { get; set; }

    public virtual DetalleButaca DetalleButaca { get; set; }
    [JsonIgnore]
    public virtual Compra IdCompraNavigation { get; set; }
}