using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Interfaces
{
    public interface ILineaRecta : IBase<Activo>
    {
        decimal[] DepreciacionAnual(Activo a);
    }
}
