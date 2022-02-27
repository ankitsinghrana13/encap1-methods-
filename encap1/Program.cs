using System;
namespace encap1
{

    class myApp1
    {

        public static int a;
        public static int b;
        public static int c;
      
      
        static void Data()
        {

            a = 10;
            b = 20;
            c=a+b;
           
        

            Console.WriteLine("a=", a);
            Console.WriteLine("b=", b);
            Console.WriteLine("total=", c);

        }
        public void getdata()
        {
           
            Data();
        }
    }

    class program
    {
        static void Main(string[] arg)
        {
            myApp1 add = new myApp1();
           
            add.getdata();

        }
    }
}