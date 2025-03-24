using System;
using System.Collections.Generic;

namespace Kevin20250324.AppWebMVC.Modelos;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? Notes { get; set; }
}
