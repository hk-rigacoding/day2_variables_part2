using System;

namespace day2_variables_part2
{
    class Program
    {
        static void Main(string[] args)
        {

            int ar_ziimi = int.MaxValue;
            ar_ziimi = int.MinValue;

            uint bez_ziimes = uint.MaxValue;


            char ch = '\n';
            string str = "Virkne";


            bool meli = false;


            Console.WriteLine(meli);

            int decimaals = 5;
            int hex_decimaals = 0x0F;

            int bin_skaitlis = 0b_0000_0100;




            float dalja = 1.0f;  //standarta uz GPU, double, precīzs, bet lēnāks

            float decimaals_f = 5f;


            float decimaals_scientific = 1.4e3f;
            double decimaals_scientific_2 = 1e3d;

            double dalja1 = 1.0d;//!!!standarta uz CPU

            //System.Numerics.Complex komplekss = 0;

            {
                double dalja2 = 1.0d;//!!!standarta uz CPU
                double d3 = dalja2;
            }


            {
                double dalja2 = 3.0d;//!!!standarta uz CPU
                double d3 = dalja2;
            }




            decimal ljoti_liels = 1.0m;




            Console.WriteLine("Hello World!");
        }
    }
}
