﻿using System;
using System.Collections.Generic;

namespace Grupo7_lab1_dotnet.Models.Entities;

public partial class Telefono
{
    public string Num { get; set; } = null!;

    public string Oper { get; set; } = null!;

    public int Duenio { get; set; }

    public virtual Persona DuenioNavigation { get; set; } = null!;
}
