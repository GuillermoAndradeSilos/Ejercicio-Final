using System;
using System.Collections.Generic;

namespace Ejercicio_Final.Models;

public partial class Pinacoteca
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public float MetrosCuadrados { get; set; }
}
