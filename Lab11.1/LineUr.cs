using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    struct Count
    {
        double b;
        double k;

        public Count(double b, double k)
        {
            this.b = b;
            this.k = k;
        }
        public string Root()
        {
            double x=-b/k;
            if (k==0)
                return "Деление на ноль";
            return $"Решение линейного уравнения: x = {x}";
        }
    }
}
