using System;
using System.Diagnostics.CodeAnalysis;

namespace WindowsFormsApp1
{
    public class floatt
    {
        private float chisl;
        private float znam;

        public float fl
        {
            get
            {
                float res = chisl / znam;
                return res;
            }
        }

        public float chislitel
        {
            get { return chisl; }
        }

        public float znamenatel
        {
            get { return znam; }
        }
        
        public floatt(float chisl, float znam)
        {
            this.chisl = chisl;
            this.znam = znam;
        }

        public static floatt operator +(floatt a, floatt b)
        {
            floatt sum = new floatt(a.chisl*b.znam + b.chisl*a.znam, a.znam * b.znam);
            return sum;
        }

        public static floatt operator -(floatt a, floatt b)
        {
            floatt minus = new floatt(a.chisl*b.znam - b.chisl*a.znam, a.znam * b.znam);
            return minus;
        }

        public static floatt operator *(floatt a, floatt b)
        {
            floatt umn = new floatt(a.chisl * b.chisl, a.znam * b.znam);
            return umn;
        }

        public static floatt operator /(floatt a, floatt b)
        {
            floatt div = new floatt(a.chisl * b.znam, a.znam * b.chisl);
            return div;
        }

        public float getNOD()
        {
            float a = Convert.ToInt32(chisl);
            float b = Convert.ToInt32(znam);
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }



    }
}