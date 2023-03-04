using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsVestidos
    {
        public abstract string calidad();
        public abstract string estilo();
        public abstract string color();
        public abstract string largo();
        public abstract double precio();

    }
}
