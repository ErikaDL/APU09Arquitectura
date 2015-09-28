using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APU09Arquitectura
{
    interface IAgregar
    {
        void AgregarMAT(string codigo, string desc, string unidad, double costo);
        void AgregarMAN(string codigo, string ocup, string ssm, double stotal);
        void AgregarEQMAQ(string codigo, string desc, string unidad, double costohr);
    }
}
