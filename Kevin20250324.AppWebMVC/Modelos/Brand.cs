using System;
using System.Collections.Generic;

namespace Kevin20250324.AppWebMVC.Modelos;

public partial class Brand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
