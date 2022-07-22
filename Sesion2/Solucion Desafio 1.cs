/**
 * Descripcion: archivo cs que contiene lo realizado para el desafio 1
 * y parcialmente lo realizado para el desafio 3
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio2
{
    class Calculadora //Nombre de nuestra clase.
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
            inicio:
            do
            {
                try
                {
                    int valor1 = 0; //Aqui se almacenara el primer valor ingresado.
                    int valor2 = 0; //Aqui se almacenara el segundo valor ingresado.
                    int R = 0; //Aqui se almacenara el resultado de la operacion.

                    //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                    Console.WriteLine("Presione el simbolo para realizar la operacion:\n");
                    Console.WriteLine("+ para sumar");
                    Console.WriteLine("- para restar");
                    Console.WriteLine("* para multiplicar");
                    Console.WriteLine("/ para dividir");
                    Console.Write("\n Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                    resp = Convert.ToString(Console.ReadLine());

                    //Aqui se agregaran los mensajes para poder ingresar los datos.
                    Console.WriteLine("\nIngrese sus dos numeros\n");
                    Console.Write("Valor1: ");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.Write("Valor2: ");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (resp)
                    {
                        case "+":
                            Console.WriteLine("El resultado de la suma es:");
                            R = valor1 + valor2;
                            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, R);
                            break;
                        case "-":
                            Console.WriteLine("El resultado de la resta es:");
                            R = valor1 - valor2;
                            Console.WriteLine("{0} - {1} = {2}", valor1, valor2, R);
                            break;
                        case "*":
                            Console.WriteLine("El resultado de la multiplicacion es:");
                            R = valor1 * valor2;
                            Console.WriteLine("{0} * {1} = {2}", valor1, valor2, R);
                            break;
                        case "/":
                            Console.WriteLine("El resultado de la division es:");
                            R = valor1 / valor2;
                            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, R);
                            break;
                        default:
                            Console.WriteLine("Operación solicitada es incorrecta.");
                            break;


                    }

                    continuar:
                    Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                    resp = Console.ReadLine().ToLower();

                    if (resp!="s" && resp!= "n")
                    {
                        Console.Write("\nDebe ingresar s ó n: "); //Si para realizarlo de nuevo y no para salir
                        goto continuar;
                    }
                    
                } catch (Exception e) {
                    Console.WriteLine("Ha sucedido un error, enter para volver a intentarlo");
                    Console.ReadKey();
                    Console.Clear();
                    goto inicio;
                }
            }
            while (resp.Equals("s"));
        }
    }
}