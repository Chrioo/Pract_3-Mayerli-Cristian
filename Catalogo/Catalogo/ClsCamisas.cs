using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    abstract class ClsCamisas
    {
        public abstract string calidad();
        public abstract string estilo();
        public abstract string color();
        public abstract double precio();

        
    }
    
    class camisaOxford : ClsCamisas
    {
        
        public override string calidad()
        {
            return" gama media";
        }
        public override string estilo()
        {
            return "Todo negro";
        }
        public override string color()
        {
            return " negro";
        }

        public override double precio()
        {
            return 6.60;
        }

       
    }
    
    
    


}
