using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public class extraINT
    {
        public int id;
        public string str;
        public bool boolean;

        public extraINT()
        {
            for(int i = 0; i < 5; i++)
            {
                char ba =Convert.ToChar(Form1.rnd.Next(100,123));
                str += Convert.ToString(ba) ;
            }
            
            id = Form1.rnd.Next(100000,1000000);

            var state = false;

            switch (Form1.rnd.Next(2))
            {
                case 0:
                    boolean = true;
                    break;
                case 1:
                    boolean = false;
                    break;
            }

        }
        
        public void null_extraint()
        {
            id = 0;
            str = "0";
            boolean = false;
        }

        public bool EqualsById(int id_)
        {
            if (id == id_)
            {
                return true;
            }

            return false;
        }
        public bool EqualsByStr(string str_)
        {
            if (str == str_)
            {
                return true;
            }
            return false;
        }

        

    }
}