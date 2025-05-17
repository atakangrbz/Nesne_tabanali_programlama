using Modül7.Ünite1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modül7.Ünite1
{
    public class Sekil
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Sekil()
        {
        }

        public Sekil(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Alan()
        {
            return x * y;
        }
    }

    public class Daire : Sekil
    {
        public Daire(double r)
            : base(r, 0)
        {
        }

        public override double Alan()
        {
            return PI * x * x;
        }
    }

    class Kure : Sekil
    {
        public Kure(double r)
            : base(r, 0)
        {
        }

        public override double Alan()
        {
            return 4 * PI * x * x;
        }
    }

    class Silindir : Sekil
    {
        public Silindir(double r, double h)
            : base(r, h)
        {
        }

        public override double Alan()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
}

