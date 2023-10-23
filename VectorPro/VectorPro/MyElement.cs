using System;
using System.Dynamic;

namespace VectorPro
{
    public class MyElement
    {
        public int id;
        public string String="";

        public MyElement()
        {
            id = Form1.rnd.Next(100000, 1000000);
            for(int i = 0; i < 5; i++)
            {
                char temp =Convert.ToChar(Form1.rnd.Next(100,123));
                 String += Convert.ToString(temp);
            }
        }
        

}
}