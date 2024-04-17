using System;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // SNACK 1
                Console.WriteLine("SNACK 1");

                Console.WriteLine("Inserire il valore di A");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserire il valore di B");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (a.CompareTo(b))
                {
                    case 1:
                        Console.WriteLine($"In questo caso la variabile maggiore e'{a}");
                        break;
                    case -1:
                        Console.WriteLine($"In questo caso la variabile maggiore e'{b}");
                        break;
                    case 0:
                        Console.WriteLine("a e b sono uguali");
                        break;
                }
            }
            {
                // SNACK 2
                Console.WriteLine("SNACK 2");

                Console.WriteLine("Inserire una parola");
                string? a = Console.ReadLine();
                Console.WriteLine("Inserire una parola");
                string? b = Console.ReadLine();

                if (a.Length < b.Length)
                {
                    Console.WriteLine($"Parola più corta: {a}");
                    Console.WriteLine($"Parola più lunga: {b}");
                }
                else
                {
                    Console.WriteLine($"Parola più corta:  {b}");
                    Console.WriteLine($"Parola più lunga:  {a}");
                }
            }
            {
                // SNACK 3
                Console.WriteLine("SNACK 3");

                int num = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Inserire il primo numero");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (i == 10)
                    {
                        Console.WriteLine("Inserire l'ultimo numero");
                        num += Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Inserire un altro numero");
                        num += Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine($"La somma di tutti i numeri inseriti e' {num}");
            }
            {

                // SNACK 4
                Console.WriteLine("SNACK 4");

                int somma = 0;
                double media = 0;

                int[] myArray = [2, 3, 4, 5, 6, 7, 8, 9, 10];
                foreach (int i in myArray)
                {
                    somma += i;
                }
                media = somma / myArray.Length;
                Console.WriteLine($"La somma dei numeri è: {somma}");
                Console.WriteLine($"La media dei numeri è: {media}");
            }
            {
                // SNACK 5
                Console.WriteLine("SNACK 5");

                Console.WriteLine("Inserire un numero");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a + 1);
                }
            }
            {
                // SNACK 6
                Console.WriteLine("SNACK 6");

                string[] invitati = ["max", "aaaa", "bbbbb", "cccccc"];
                Console.WriteLine("Inserisci il tuo nome");
                string? nome = Console.ReadLine();

                if (invitati.Contains(nome.ToLower()))
                {
                    Console.WriteLine("Benvenuto alla festa");
                }
                else
                {
                    Console.WriteLine("Mi dispiace non puoi entrare");
                }
            }
            {
                // SNACK 7
                Console.WriteLine("SNACK 7");

                int[] arrayVuoto = [];
                int num;
                var lista = arrayVuoto.ToList();

                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("inserire un numero");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num % 2 == 1)
                    {
                        lista.Add(num);
                    }

                }
                arrayVuoto = lista.ToArray();
                Console.WriteLine("Elementi nell'Array:");
                foreach (int i in arrayVuoto)
                {
                    Console.WriteLine(i);
                }

            }
            {
                // SNACK 8
                Console.WriteLine("SNACK 8");

                int[] ints = [1, 2, 3, 4, 5, 6];
                int somma = 0;
                for (int i = 0; i < ints.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        somma += ints[i];
                    }
                }
                Console.WriteLine(somma);
            }
            {
                // SNACK 9
                Console.WriteLine("SNACK 9");

                int[] arrayVuoto = [];
                var lista = arrayVuoto.ToList();
                int somma = 0;

                while (somma < 50)
                {
                    Console.WriteLine("inserire un numero");
                    int num = Convert.ToInt32(Console.ReadLine());
                    lista.Add(num);
                    somma += num;
                }
                arrayVuoto = lista.ToArray();
                Console.WriteLine("Elementi nell'Array:");
                foreach (int i in arrayVuoto)
                {
                    Console.WriteLine(i);
                }
            }
            {
                // SNACK 10
                Console.WriteLine("SNACK 10");

                int N = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                Random random = new Random();

                for (int i = 0; i < N; i++)
                {
                    int[] array = new int[10];
                    for (int j = 0; j < array.Length; j++)
                    {
                        array[j] = random.Next(1, 101); 
                    }
                    counter++;
                    Console.WriteLine($"Elementi random nell'Array {counter}:");
                    foreach (int k in array) 
                    {
                        Console.WriteLine(k);
                    }
                }
            }
        }
    }
}
