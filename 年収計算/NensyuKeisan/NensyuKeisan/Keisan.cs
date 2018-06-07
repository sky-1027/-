using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NensyuKeisan
{
    class Keisan
    {
        private double Gessyu = 0;
        private double Syouyo = 0;
        private double Teate = 0;
        private double Nensyuu = 0;

        public Keisan()
        {
        }

        public void setKeisan(double g, double s, double t)
        {
            this.Gessyu = g * 12;
            this.Syouyo = s * 2;
            this.Teate = t * 12;
                
            this.Nensyuu = Gessyu + Syouyo + Teate;
        }

        public double getKeisan()
        {
            return Nensyuu;
        }
    }
}
