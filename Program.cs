using System;
using System.Reflection.Metadata;
using System.Text;
using System.Timers;


namespace TinhChiSoCoThe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;

            Console.WriteLine("Tính chỉ số cơ thể");
            float height;
            float weight;
            float bmi;

            Console.Write("Nhập chiều cao của bạn (met): ");
            height=float.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng của bạn (kg): ");
            weight=float.Parse(Console.ReadLine());

            bmi=weight/(height*2);
            Console.WriteLine("BMI: "+ bmi);
            if (bmi>=30)
            {
                Console.Write("Chỉ số cơ thể của bạn thuộc loại Obese ");
            }
            else if (bmi>=25)
            {
                Console.Write("Chỉ số cơ thể của bạn thuộc loại OverWeight ");
            }
            else if (bmi>=18.5)
            {
                Console.Write("Chỉ số cơ thể của bạn thuộc loại Normal ");
            }
            else
            {
                Console.Write("Chỉ số cơ thể của bạn thuộc loại UnderWeight ");
            }
            Console.ReadKey();
        }
    }
}