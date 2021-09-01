using System;

namespace Tarea_Teoria_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            byte opcion;
            byte opcion2; 
            bool ON = true;
            bool Encender = true;
            float medida; 
            int lados; 
            float grados;
            float centigrados;
            float moneda;
            float tipoCambio;
            int parImpar;
            byte dias; 
            //Intancias de clases
            Class_Cap1 objCap1 = new Class_Cap1();
            Class_Cap2 objCap2 = new Class_Cap2();
            Class_Cap3 objCap3 = new Class_Cap3();

            Console.WriteLine("*************Tarea 1 de Programacion Aplicada 1***************** \n \n");

            do
            {
                Console.WriteLine("Elija una opcion para ver los ejercicios de los capitulos 1 al 3 \n");
                Console.WriteLine("1.Ver ejercicios Cap1."); 
                Console.WriteLine("2.Ver ejercicios Cap2."); 
                Console.WriteLine("3.Ver ejercicios Cap3.");
                Console.WriteLine("4.Salir del programa.");
                Console.Write("Opcion: ");
                opcion = Convert.ToByte(Console.ReadLine());
                Console.Write("\n");

                switch(opcion)
                {
                    case 1:
                      Console.WriteLine("Los ejercicios de cap1 son: \n");
                      Console.WriteLine("1.Imprimir el nombre.");
                      Console.WriteLine("5.Agregar mas mensajes. \n");
                      objCap1.ImprimirNombre(); 
                      objCap1.NewPosts();
                    break;
                    
                    case 2:
                       do{
                            Console.WriteLine("Elija que ejercicios del cap2 desea ver: \n");
                            Console.WriteLine("1.Calcular el perimetro de cualquier poligono regular.");
                            Console.WriteLine("3.Transformar de grados a radianes.");
                            Console.WriteLine("4.Transformar de centigrados a Fahrenheit.");
                            Console.WriteLine("5.Transformar entre dolares y euros y pedir el tipo de cambio.");
                            Console.WriteLine("6.Salir del programa.");
                            Console.Write("Opcion: ");
                            opcion2 = Convert.ToByte(Console.ReadLine());
                            Console.Write("\n");

                            switch(opcion2)
                            {
                                case 1:
                                   Console.Write("Dame la medidad de uno de los lados: ");
                                   medida = Convert.ToSingle(Console.ReadLine());

                                   Console.Write("Numero de lados del poligono: ");
                                   lados = Convert.ToInt32(Console.ReadLine());

                                   Console.WriteLine("Resultado: {0}", objCap2.CalcularPerimetro(medida, lados));
                                break;

                                case 3:
                                    Console.Write("Introduce los grados a transformar: ");
                                    grados = Convert.ToSingle(Console.ReadLine()); 

                                    Console.WriteLine("Resultado: {0}", objCap2.ConvertirGradosA_Radianes(grados));
                                break;

                                case 4:
                                    Console.Write("Introduce los centigrados a transformar: ");
                                    centigrados = Convert.ToSingle(Console.ReadLine());

                                    Console.WriteLine("Resultado: {0}", objCap2.ConvertirCentigradosA_Fahrenheit(centigrados));
                                break; 

                                case 5:
                                    Console.WriteLine("Introduce la cantidad de euros o dolares a trasnformar: ");
                                    moneda = Convert.ToSingle(Console.ReadLine()); 

                                    Console.WriteLine("Introduce el tipo de cambio de acuerdo a la moneda que quieres cambiar: ");
                                    tipoCambio = Convert.ToSingle(Console.ReadLine());

                                    Console.WriteLine("Resultado: {0}", objCap2.ConvertirMoneda(moneda, tipoCambio));
                                break;
                                
                                case 6:
                                    Console.WriteLine("Saliste del los ejercicios del cap2, adios! :( \n");
                                    Encender = false;
                                break;

                                default:
                                    Console.WriteLine("error 404, opcion no validad, selecciona otra... \n");
                                break;

                            }

                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadLine(); 
                            Console.Clear();

                       }while(Encender == true); 
                    break; 
                    
                    case 3:
                       Console.WriteLine("Los ejercicios del cap3 son: \n");

                       Console.WriteLine("1.Ver si un numero es par o impar \n");
                       //Aqui empieza el ejercicio 1 cap1
                       Console.Write("Introduce un numero entero para saber si es par o impar: ");
                       parImpar = Convert.ToInt32(Console.ReadLine());
                       Console.Write("\n");
                       objCap3.Par_impar(parImpar);

                       //Aqui empieza el ejercicio 4 cap3
                       Console.Write("4.Introducir un numero y ver a que dia de la semana corresponde: ");
                       dias = Convert.ToByte(Console.ReadLine());
                       Console.Write("\n");
                       objCap3.dias(dias); 
                    break;

                    case 4:
                      Console.WriteLine("Saliste del programa, adios! :( \n");
                      ON = false;
                    break; 

                    default:
                       Console.WriteLine("error 404, opcion no valida, selecciona otra... \n");
                    break;
                           
                }
                
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadLine(); 
                Console.Clear();

            }while(ON == true); 


        }
    }
}