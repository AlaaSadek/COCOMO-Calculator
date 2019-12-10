using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO
{
    class ProjectType
    {
        double a, b, c, d;
        string type; 

       public ProjectType(double a, double b, double c, double d, string type)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.type = type;
        }
    }

    
}
