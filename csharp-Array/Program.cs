/*
    1. Creare un programma che abbia all’interno un array di interi contenente i numeri da 0 a 9. Stampare l’array a schermo.

    2. Creare un programma che abbia all’interno un array di interi contenente i numeri pari da 0 a 12. Stampare l’array a schermo.

    3. Creare un programma che abbia all’interno un array di interi contenente i numeri dispari da -3 a 11. Stampare l’array a schermo.

    4. Creare un programma che abbia all’interno un array di stringhe scelte dal programmatore. Stampare l’array a schermo.

    5. Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore. Stampare a schermo un messaggio se l’array contiene numeri negativi.

    6. Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore. Stampare la somma di tutti gli elementi dell’array a schermo.

    7. Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore. Stampare la media di tutti gli elementi dell’array a schermo.

    8. Creare un programma che abbia all’interno un array di interi, con numeri arbitrari definiti dal programmatore. Con l’ausilio di una variabile, controllare che un numero sia nell’array.
*/
using System.Xml.Linq;

namespace csharp_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 8 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Stampa a schermo un array di interi contenente i numeri da 0 a 9");
                Console.WriteLine("Caso [2]: Stampa a schermo un array di interi contenente i numeri pari da 0 a 12");
                Console.WriteLine("Caso [3]: Stampa a schermo un array di interi contenente i numeri dispari da -3 a 11");
                Console.WriteLine("Caso [4]: Stampa a schermo un array di stringhe scelte dal programmatore");
                Console.WriteLine("Caso [5]: Crea un array di interi contenente dei numeri scelti dal programmatore. Stampare a schermo un messaggio se l’array contiene numeri negativi");
                Console.WriteLine("Caso [6]: Crea un array di interi contenente dei numeri scelti dal programmatore. Stampare la somma di tutti gli elementi dell’array a schermo");
                Console.WriteLine("Caso [7]: Crea un array di interi contenente dei numeri scelti dal programmatore. Stampare la media di tutti gli elementi dell’array a schermo");
                Console.WriteLine("Caso [8]: Crea un array di interi, con numeri arbitrari definiti dal programmatore. Con l’ausilio di una variabile, controllare che un numero sia nell’array");
       

                if (int.TryParse(Console.ReadLine(), out int scelta))
                {
                    if (scelta == 0)
                    {
                        Console.WriteLine("Uscita dal programma...");
                        break; // Esce dal loop e termina il programma
                    }

                    Console.WriteLine("\n---------------------------------------------------\n");

                    switch (scelta)
                    {
                        case 1:
                            Console.WriteLine("ESERCIZIO 1\n");
                            StampaArray();
                            break;
                        case 2:
                            Console.WriteLine("ESERCIZIO 2\n");
                            StampaArray2();
                            break;
                        case 3:
                            Console.WriteLine("ESERCIZIO 3\n");
                            StampaArray3();
                            break;
                        case 4:
                            Console.WriteLine("ESERCIZIO 4\n");
                            StampaArray4();
                            break;
                        case 5:
                            Console.WriteLine("ESERCIZIO 5\n");
                            StampaArray5();
                            break;
                        case 6:
                            Console.WriteLine("ESERCIZIO 6\n");
                            StampaArray6();
                            break;
                        case 7:
                            Console.WriteLine("ESERCIZIO 7\n");
                            StampaArray7();
                            break;
                        case 8:
                            Console.WriteLine("ESERCIZIO 8\n");
                            StampaArray8();
                            break;
                        default:
                            Console.WriteLine("Scelta non valida. Inserisci un numero tra 1 e 8 oppure 0 per uscire.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Errore: Inserisci un numero valido.");
                }
            }
        }


        /*
          Creare un programma che abbia all’interno un array di interi contenente i numeri da 0 a 9. Stampare l’array a schermo.
        */
        static void StampaArray()
        {
            int[] numeri = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numeri[i] = i;
            }
            //stampo l'array su una sola riga
            Console.WriteLine("Array formato da:\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));
        }

        /*
          Creare un programma che abbia all’interno un array di interi contenente i numeri pari da 0 a 12. Stampare l’array a schermo.
        */
        static void StampaArray2()
        {
            int[] numeri = new int[7];
            int index = 0;

            for (int i = 0; i < 13; i++)
            {
                if ( i%2 != 0){
                    continue; 
                }

                numeri[index] = i;
                index++;
            }
            //stampo l'array su una sola riga
            Console.WriteLine("Array formato da:\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));
        }

        /*
          Creare un programma che abbia all’interno un array di interi contenente i numeri dispari da -3 a 11. Stampare l’array a schermo.
        */
        static void StampaArray3()
        {
            int[] numeri = new int[7];
            int index = 0;

            for (int i = -3; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                numeri[index] = i;
                index++;
            }
            //stampo l'array su una sola riga
            Console.WriteLine("Array formato da:\n");
            //stampo l'array su una sola riga
            Console.WriteLine(string.Join(" ", numeri));
        }

        /*
          Creare un programma che abbia all’interno un array di stringhe scelte dal programmatore. Stampare l’array a schermo.
        */
        static void StampaArray4()
        {
            int n;

            Console.WriteLine("Quante parole vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            string[] parole = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci la parola {i + 1}: ");
                parole[i] = Console.ReadLine(); // Salva la parola nell'array
            }

            Console.WriteLine("\nArray di stringhe inserito:\n");
            Console.WriteLine(string.Join(", ", parole)); // Stampa tutto in un'unica riga

        }

        /*
         Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore. Stampare a schermo un messaggio se l’array contiene numeri negativi.
       */
        static void StampaArray5()
        {
            int n;
            bool contieneNegativi = false; // Flag per verificare numeri negativi

            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero");
                }

                numeri[i] = temp;

                // Verifica se il numero è negativo
                if (temp < 0)
                {
                    contieneNegativi = true;
                }

            }

            // Stampa l'array
            Console.WriteLine("\nArray inserito:");
            Console.WriteLine(string.Join(", ", numeri));

            // Messaggio se contiene numeri negativi
            if (contieneNegativi)
            {
                Console.WriteLine("\nL'array contiene numeri negativi.");
            }
            else
            {
                Console.WriteLine("\nL'array non contiene numeri negativi.");
            }

        }

        /*
          Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore. Stampare la somma di tutti gli elementi dell’array a schermo.
        */
        static void StampaArray6()
        {
            int n;
            
            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero");
                }

                numeri[i] = temp;
            }

            int somma = 0;

            for (int i = 0; i < numeri.Length; i++) 
            {
                somma += numeri[i];
            }

            Console.WriteLine("\nLa soma sarà: {0}",somma);
        }

        /*
        Creare un programma che abbia all’interno un array di interi contenente dei numeri scelti dal programmatore.Stampare la media di tutti gli elementi dell’array a schermo.
        */
        static void StampaArray7()
        {
            int n;

            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero");
                }

                numeri[i] = temp;
            }

            int somma = 0;

            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }

            double media = somma / numeri.Length;

            // Stampa dell'array e della media
            Console.WriteLine("Array: " + string.Join(", ", numeri));
            Console.WriteLine($"La media dei numeri è: {media}");
        }

        /*
          Creare un programma che abbia all’interno un array di interi, con numeri arbitrari definiti dal programmatore. Con l’ausilio di una variabile, controllare che un numero sia nell’array. 
        */
        static void StampaArray8()
        {
            int n,m;

            Console.WriteLine("Quanti numeri vuoi inserire?");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
            }

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Inserisci il numero in posizione {i + 1}: ");

                int temp;

                //Controllo
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero");
                }

                numeri[i] = temp;
            }

            Console.WriteLine("Digita il numero da ricercare");

            // Controllo input utente
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            for (int i = 0; i < numeri.Length; i++)
            {
                if (numeri[i] == m)
                {
                    Console.WriteLine("Numero trovato in posizione: {0}", i + 1);
                    break;
                }
                //Se il ciclo arriva alla fine senza aver trovato il numero
                if(i == numeri.Length-1)
                {
                    Console.WriteLine("Numero non trovato");
                    break;
                }
                
            }


        }

     }
}
