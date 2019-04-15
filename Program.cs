using System;

namespace royecto
{
    class Program
    {
        public Program()
        {
        }

        static void Main(string[] args)
        {
            float[] lado = new float[3];
            float mayor = 0, sumar = 0;
            int i, j, auxi = 0, flag = 0;

            for (i = 0; i < 3; i++)
            {
                Console.Write("Lado {0}:", i + 1);
                lado[i] = float.Parse(s: Console.ReadLine());

                if (lado[i] > mayor)
                {
                    mayor = lado[i];
                    auxi = i;
                }
            }

            for (i = 0; i < 3; i++)
                if (auxi != i)
                    sumar += lado[i];

            if (mayor < sumar)
            {
                Console.Write("Es un triangulo");

                for (i = 0; i < 2; i++)
                    for (j = i + 1; j < 3; j++)
                        if (lado[i] == lado[j])
                            flag++;
                if (flag == 3)
                    Console.Write(" ---> Equilatero");
                else
                {
                    flag = 0;
                    for (i = 0; i < 2; i++)
                        for (j = i + 1; j < 3; j++)
                            if (lado[i] != lado[j])
                                flag++;
                    if (flag == 3)
                        Console.Write(" ---> Escaleno");
                    else
                        Console.Write(" ---> Isosceles");
                }
            }
            else
            {
                Console.Write("No es un triangulo");
            }
            Console.Read();
        }

    }
   
   
}
