using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface ISumaDigitos : IBase<Activo>
    {
        decimal[] DepreciacionAnual(Activo a);
        decimal Digitos(Activo a);
    }
}
