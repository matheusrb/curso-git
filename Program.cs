using System;
using System.Globalization;
namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 30, 10);
            TimeSpan t2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t1.Add(t2); //soma o periodo de t2 a t1 - retorna um timespan
            TimeSpan dif = t1.Subtract(t2); //subtrai t2 de t1 - retorna um timespan
            TimeSpan mult = t2.Multiply(2.0); //multiplica o valor de t2 pelo numero do argumento - retorna um timespan
            TimeSpan div = t2.Divide(2.0); //divide o valor de t2 pelo numero do argumento - retorna um timespan


            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
            Console.WriteLine("Ola Mundo");
        }   


    }
}
