class Program
    {
        static void Main(string[] args)
        {
            //array untuk mencari
            int[] arr = new int[20];
            //jumlah elemen arr
            int n;
            int i;

            //menerima jumlah elemen arr dan disimpan ke dalam array
            while (true)
            {
                Console.Write("Masukkan jumlah elemen dalam array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else Console.WriteLine("\nArray harus minimal 1 dan maksimal 20.\n");
            }

            //menyimpan elemen array
            Console.WriteLine("\n=============================================");
            Console.WriteLine(" Masukkan Element Array dalam Ascending Order ");
            Console.WriteLine("=============================================\n");

            for(i= 0; i < n; i++)
            {
                Console.Write((i+1)+" .");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

            char ch;
            do
            {
                //menyimpan angka yang ingin di cari
                Console.Write("\nMasukkan Elemen yang ingin di cari : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //penerapan binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //mendetekai indeks dari elemen paling tengah
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop untuk mencari elemen dalam array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }

                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " ditemukan pada posisi " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " Tidak ditemukan dalam array\n");

                Console.WriteLine("\nNomor Comparisons : " + ctr);

                Console.Write("Lanjutkan Mencari? (y/n) : ");
                ch = Char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
