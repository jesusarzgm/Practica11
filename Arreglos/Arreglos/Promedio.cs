using System;


namespace Arreglos
{
    class Promedio
    {
        int[] materias;
        string nombre;
        int suma = 0;
        public float prom;
        public float resultado;


        public Promedio(int matematicas, int español, int calculo, int progra, int historia)
        {
            materias = new int[5];

            materias[0] = matematicas;
            materias[1] = español;
            materias[2] = calculo;
            materias[3] = progra;
            materias[4] = historia;

            for (int i = 0; i < 5; i++)
            {
                suma = materias[i] + suma;
            }
            prom = suma / 5;         


        }
        public void Varianza(string[] varianza,float promedio)
        {
            float vari;
            float suma = 0;
            
            
            for (int i = 0; i < 5; i++)
            {

                vari = (int.Parse(varianza[i]) - prom) * (int.Parse(varianza[i]) - prom);
                suma = vari + suma;
            }
            resultado = suma / (4);


        }
    }
}
