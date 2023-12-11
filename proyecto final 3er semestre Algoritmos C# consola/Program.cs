using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_3er_semestre_Algoritmos_C__consola
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Insertionsort insertionsort = new Insertionsort();
            Bubblesort bubblesort = new Bubblesort();
            Selectionsort selectionsort = new Selectionsort();
            Cocktailsort cocktailsort = new Cocktailsort();
            BucketSort bucketsort = new BucketSort();
            Radixsort radixsort = new Radixsort();
            Shellsort shellsort = new Shellsort();
            Binarytreesort binarytreesort = new Binarytreesort();
            Combsort combsort = new Combsort();
            Countingsort countingsort = new Countingsort();
            Gnomesort gnomesort = new Gnomesort();
            Heapsort heapsort = new Heapsort();
            Mergesort mergesort = new Mergesort();
            Pigeonhole pigeonhole = new Pigeonhole();
            QuickSort quickSort = new QuickSort();

            while (true)
            {
                Console.WriteLine("Selecciona la opción deseada:");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Cocktail Sort");
                Console.WriteLine("5. Bucket Sort");
                Console.WriteLine("6. Radix Sort");
                Console.WriteLine("7. Shell Sort ");
                Console.WriteLine("8. Binary Tree Sort");
                Console.WriteLine("9. Comb Sort");
                Console.WriteLine("10. Counting Sort");
                Console.WriteLine("11. Gnome Sort");
                Console.WriteLine("12. Heap Sort");
                Console.WriteLine("13. Merge Sort");
                Console.WriteLine("14. Pigeonhole");
                Console.WriteLine("15. Quick Sort");
                Console.WriteLine("16. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        int[] a = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(a);

                        insertionsort.AlgoritmoInsertionSort(a);

                        Console.WriteLine("Insertion Sort: ");
                        Print(a);

                        Console.ReadKey();
                        break;

                        case "2":
                        int[] b = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(b);

                        bubblesort.bubbleSort(b);

                        Console.WriteLine("Bubble Sort: ");
                        Print(b);

                        Console.ReadKey();
                            break;

                    case "3":
                        int[] c = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(c);

                        selectionsort.Sort(c);

                        Console.WriteLine("Selection Sort");
                        Print(c);

                        Console.ReadKey();
                        break;

                        case "4":
                        int[] d = Multipurpose();

                        Console.WriteLine("Original:");
                        Print(d);

                        cocktailsort.Sort(d);

                        Console.WriteLine("Cocktail Sort");
                        Print(d);

                        Console.ReadKey();
                        break;

                        case "5":
                        double[] e = GenerarVectorDouble();

                        Console.WriteLine("Original: ");
                        PrintD(e);

                        bucketsort.bucketSort(e);
                        Console.WriteLine("Bucketsort: ");
                        PrintD(e);

                        Console.ReadKey();
                        break;

                    case "6":
                        int[] f = Multipurpose();

                        Console.WriteLine("Original:");
                        Print(f);

                        radixsort.Sort(f);

                        Console.WriteLine("Radix Sort");
                        Print(f);

                        Console.ReadKey();
                        break;

                    case "7":
                        int[] g = Multipurpose();

                        Console.WriteLine("Original:");
                        Print(g);

                        shellsort.ShellSort(g);

                        Console.WriteLine("Shell sort");
                        Print(g);

                        Console.ReadKey();
                        break;

                    case "8":
                        int[] h = Multipurpose();

                        Console.WriteLine("Original:");
                        Print(h);

                        binarytreesort.Sort(h);

                        Console.WriteLine("Binary Tree Sort");
                        Print(h);

                        Console.ReadKey();
                        break;

                    case "9":
                        int[] j = Multipurpose();

                        Console.WriteLine("Original:");
                        Print(j);

                        combsort.Sort(j);

                        Console.WriteLine("Comb Sort");
                        Print(j);

                        Console.ReadKey();
                        break;

                    case "10":
                        int[] k = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(k);

                        countingsort.Sort(k);

                        Console.WriteLine("Counting Sort: ");
                        Print(k);

                        Console.ReadKey();
                        break;
                    case "11":
                        int[] l = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(l);

                        gnomesort.Sort(l);

                        Console.WriteLine("Gnome Sort: ");
                        Print(l);

                        Console.ReadKey();
                        break;
                    case "12":
                        int[] m = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(m);

                        heapsort.Sort(m);

                        Console.WriteLine("Heap Sort: ");
                        Print(m);

                        Console.ReadKey();
                        break;
                    case "13":
                        int[] n = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(n);

                        mergesort.MergeSort(n);

                        Console.WriteLine("Merge Sort: ");
                        Print(n);

                        Console.ReadKey();
                        break;
                    case "14":
                        int[] o = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(o);

                        pigeonhole.PigeonholeSort(o);

                        Console.WriteLine("Pigeonhole: ");
                        Print(o);

                        Console.ReadKey();
                        break;
                    case "15":
                        int[] p = Multipurpose();

                        Console.WriteLine("Original: ");
                        Print(p);

                        quickSort.quicksort(ref p, 0, p.Length - 1);

                        Console.WriteLine("Quick Sort: ");
                        Print(p);

                        Console.ReadKey();
                        break;
                    case "16":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
        }

        private static int[] Multipurpose()
        {
            var x = 0;

            Console.Clear();
            Console.Write("Inserte la cantidad de datos: ");
            x = int.Parse(Console.ReadLine());
            Console.Clear();

            int[] array = new int[x];

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10000);
            }
            return array;
        }

        private static double[] GenerarVectorDouble()
        {
            Console.Clear();
            Console.Write("Inserte la cantidad de datos (double): ");
            int length = int.Parse(Console.ReadLine());
            Console.Clear();

            List<double> list = new List<double>();
            Random random = new Random();
            int values = 5;

            for (int i = 0; i < length; i++)
            {
                if (i < values)
                {
                    double newValue = random.NextDouble();
                    list.Add(newValue);
                }
                else
                {
                    break;
                }
            }
            return list.ToArray();
        }
        private static void Print(int[] collection)
        {
            Console.Write("(");
            foreach (var item in collection)
            {
                Console.Write($" {item}, ");
            }
            Console.Write(")\n\n");
        }

        private static void PrintD(double[] collection)
        {
            Console.Write("[");
            foreach (var item in collection)
            {
                Console.Write($" {item}, ");
            }
            Console.Write("]\n\n");
        }
    }
}
