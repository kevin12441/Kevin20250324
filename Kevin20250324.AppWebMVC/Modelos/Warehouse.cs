using System;
using System.Collections.Generic;

namespace Kevin20250324.AppWebMVC.Modelos;

public partial class Warehouse
{
    public int Id { get; set; }

    public string WarehouseName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
