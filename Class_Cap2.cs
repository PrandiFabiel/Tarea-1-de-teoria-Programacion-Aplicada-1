using System;
namespace Tarea_Teoria_1
{
    public class Class_Cap2
    {
        public float CalcularPerimetro(float Medida, int NumeroDeLados)
        {
            float Perimetro;
            Perimetro = Medida * NumeroDeLados; 

            return Perimetro; 
        }

        public float ConvertirGradosA_Radianes(float Grados)
        {
            float Radianes;
            Radianes = (Grados * 3.14f)/180; 

            return Radianes; 
        }

        public float ConvertirCentigradosA_Fahrenheit(float Centigrados)
        {
            float Fahrenheit;
            Fahrenheit = (Centigrados * 1.8f) + 32; 

            return Fahrenheit; 
        }

        public float ConvertirMoneda(float moneda, float tipoCambio)
        {
            float resultado;
            resultado = moneda * tipoCambio; 
            return resultado;
        }
    }
}