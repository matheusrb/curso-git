using System;
using System.Globalization;
namespace Data_e_Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operações
            DateTime d1 = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d10 = new DateTime(2001, 8, 15);
            DateTime d11 = new DateTime(2001, 8, 20);
            
            //Operações
            DateTime d2 = d1.AddHours(2); //Adiciona 2 horas ao horario de Date (Adiciona um TimeSpan)
            TimeSpan t1 = d11.Subtract(d10); //Subtrai d1 de d2, usado apra achar a diferença de tempo de uma data apra outra


            //Saida de dados
            Console.WriteLine("1) Date: " + d1) ;
            Console.WriteLine("2) Date + 2 horas: " + d2);
            Console.WriteLine("3) Subtract (d2-d1): " + t1);
        }   


    }
}
