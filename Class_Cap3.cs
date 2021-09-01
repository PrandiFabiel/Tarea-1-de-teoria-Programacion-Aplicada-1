using System;
namespace Tarea_Teoria_1
{
    public class Class_Cap3
    {
        public void Par_impar(int numero)
        {
            if(numero % 2 == 0)
            {
                Console.WriteLine("{0} Es par \n", numero);

            }else{

                Console.WriteLine("{0} Es impar \n", numero); 
            }

        }

        public void dias(byte dias)
        {
            switch(dias)
            {
                case 1:
                   Console.WriteLine("{0} Pertenece al Lunes! \n", dias);
                break;

                case 2:
                   Console.WriteLine("{0} Pertenece al Martes! \n", dias);
                break;

                case 3:
                   Console.WriteLine("{0} Pertenece al Miercoles! \n", dias);
                break; 

                case 4:
                   Console.WriteLine("{0} Pertenece al Jueves! \n", dias);
                break;

                case 5:
                   Console.WriteLine("{0} Pertenece al Viernes! \n", dias);
                break;

                case 6:
                   Console.WriteLine("{0} Pertenece al Sabado! \n", dias);
                break;

                case 7:
                   Console.WriteLine("{0} Pertenece al Domingo! \n", dias);
                break;

                default:
                   Console.WriteLine("{0} No pertenece a ningun dia de la semana... \n", dias);
                break; 
            }
        }

    }
}