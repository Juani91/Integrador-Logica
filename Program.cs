using System;

namespace TPFinal_Zucco
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            
            // A partir de dichos datos informar:
                // a. El mayor de los números pares.
                // b. La cantidad de números impares.
                // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int n = 0;
            bool primero = true;
            bool parBand = false; // A
            int maxPar = 0;
            int conImp = 0;       // B
            bool priBand = false; // C
            int minPri = 0;

            pedirNum(ref n, ref primero);

            while (n != 0)
            {
                // Punto A
                if(par(n)){
                    if(!parBand){
                        maxPar = n;
                        parBand = true;
                    }else if(n > maxPar)
                        maxPar = n;
                }                    
                
                // Control Punto A
                //Console.WriteLine("El maxPar es: " + maxPar);
                
                // Punto B
                if(impar(n))
                    conImp ++;
                
                // Control Punto B
                //Console.WriteLine("El contImp es: " + conImp);

                // Punto C
                if(primo(n)){
                    if(!priBand){
                        minPri = n;
                        priBand = true;
                    }else if(n < minPri)
                        minPri = n;
                }                                  
                
                // Control Punto C
                //Console.WriteLine("El minPri es: " + minPri);

                pedirNum(ref n, ref primero);
            }

            Console.WriteLine("El mayor de los números pares es: " + maxPar);
            Console.WriteLine("La cantidad de números impares es: " + conImp);
            Console.WriteLine("El menor de los números primos es: " + minPri);
        }

        static void pedirNum(ref int n1, ref bool p){
            if(p){
                Console.WriteLine("Ingrese un número:");
                n1 = int.Parse(Console.ReadLine());
                p = false;
            }else{
                Console.WriteLine("Ingrese otro número:");
                n1 = int.Parse(Console.ReadLine());
            }
        }

        static bool par(int a){
            if(a % 2 == 0)
                return true;
            else
                return false;
        }

        static bool impar(int b){
            if(b % 2 != 0)
                return true;
            else
                return false;
        }

        static bool primo(int c){
            int con = 0;
            if(c > 0){
                for (int x = 1; x <= c; x++)
                {
                    if(c % x == 0)
                        con++;
                }
            }else if(c < 0){
               for (int x = -1; x >= c; x--)
                {
                    if(c % x == 0)
                        con++;
                } 
            }

            if(con == 2)
                return true;
            else
                return false;       
        
        }
    }
}

// Hola Juan. Muy bien el TP. Es completo, es funcional y resuelve todo de manera correcta.
// Hay un solo detalle, que no es de lógica de programación, pero sí es una cuestión matemática. 
// Y es el hecho de que los números Primos son solo los Positivos, por lo que es erróneo buscar Primos entre los Negativos.
// Es solo un pequeño detalle, no afecta el funcionamiento, es solo para tener en cuenta esta regla matemática con los Primos.
// Buen trabajo