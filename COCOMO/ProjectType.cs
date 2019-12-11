using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO
{
    public class ProjectType
    {
        double a, b, c, d;
        string type;
        public ProjectType()
        { }
            public ProjectType(double a, double b, double c, double d, string type)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.type = type;
        }
        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }
        public double getD()
        {
            return d;
        }
        public string Gettype()
        {
            return type;
        }
    }

    
}
