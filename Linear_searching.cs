class Program
    {
        static void Main(string[] args)
        {
            //array untuk mencari
            int[] arr = new int[20];
            //jumlah elemen dalam array
            int n;
            int i;

            //memberi jumlah elemen dan disimpan dalam array
            while (true)
            {
                Console.Write("Masukkan Jumlah Element dalam Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else Console.WriteLine("\nMasukkan Array Minimal 1 dan Maksimal 20.\n");
            }

            //menyimpan elemen array
            Console.WriteLine("\n========================");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("========================\n");

            for(i = 0; i < n; i++)
            {
                Console.Write((i+1)+" .");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

            char ch;
            int ctr;

            do
            {
                //menyimpan jumlah yang akan dicari
                Console.Write("\nMasukkan Elemen yang Ingin Anda Cari : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //penerapan linear search
                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + " di temukan pada posisi " + (i + 1).ToString());
                        break;
                    }
                }

                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + " tidak ditemukan di dalam array");

                Console.WriteLine("\nNomor Comparisons : " + ctr);

                Console.Write("\nLanjutkan Mencari? (y/n) : ");
                ch = Char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
    }
