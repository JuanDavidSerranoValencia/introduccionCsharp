using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {//Siempre toda sentencia termina con ;
        /*
            Console.WriteLine("Hello, World!");//salto de linea
            Console.Write("Hola Si");//linea continua

            int a;
            float precio =23.0f;//flotante
            Console.Write("Ingrese su edad:");
            Console.WriteLine(precio);
            try{
                 //a = int.Parse(Console.ReadLine());//ingreso de variable siempre tienen que ser parseadas al tipo de dato de la variable declarada
                 a=Convert.ToInt16(Console.ReadLine());
            }catch(Exception ex){

               Console.WriteLine("Error {0}",ex.Message.ToString());//genera la excepsion si el ingreso presenta algun fallo
            }

        */
        //switch
        /*
                int valor =1;

                switch(valor){
                    case 0:
                        break;
                    default:
                        break;
                };
        */

        //Operadores logicos and( && &) or(|| |) not !=
        //operadores matematicos ( + * - / %)
        //comp ( < > != <= >= ==)
        /*
                var a = 12.3;
                double b = 12.3;
                Console.WriteLine($"El valor de a es = {a}");
                Console.WriteLine($"El valor de b es = {b}");
        */

        /*
        double d = 3D;
        d = 4d;
        d = 3.934_001;
        Console.WriteLine($"{d}");
        float f = 3_000.5f;
        f = 5.4f;
        Console.WriteLine($"{f}");
        decimal myMoney = 3_000.5m;
        myMoney =400.75M;
        Console.WriteLine($"{myMoney}");
        */

        /*
        //ternarios
        bool check =true;
        Console.WriteLine(check ? "Activo" :"Inactivo");
        Console.WriteLine(false ? "Activo": "Inactivo");
        */

        /*
         // CONVERCION A MONEDAS 

          decimal value =123.456m;
          Console.WriteLine(value.ToString("C2"));


        */
        /*
        //CICLOS
        for (int i =0; i<10;i++){
            Console.WriteLine(i);

        }
        //WHILE
        bool flag = true;
        while(flag){
            Console.WriteLine("hola");
            break;
        }
        */

        //Como realizar una mortizacion de un credito
    }
}