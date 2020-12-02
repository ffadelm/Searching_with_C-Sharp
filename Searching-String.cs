class Program
    {
        string[] fay = new string[20];

        int i, j, n;

        public void input()
        {
            while (true)
            {
                Console.Write("Masukkan Jumlah Element dalam Array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else Console.WriteLine("\nMasukkan Array Minimal 1 dan Maksimal 20.\n");
            }

            Console.WriteLine("\n========================");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("========================\n");

            for (i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " .");
                fay[i] = Console.ReadLine();
            }
        }

        public void LinearSearch()
        {
            int ctr;
            char ch;

            do
            {
                //menyimpan jumlah yang akan dicari
                Console.Write("\nMasukkan Elemen yang Ingin Anda Cari : ");
                string item = Console.ReadLine();


                //penerapan linear search
                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (fay[i] == item)
                    {
                        Console.WriteLine("\n" + item + " di temukan pada posisi " + (i + 1).ToString());
                        break;
                    }
                }

                if (i == n)
                    Console.WriteLine("\n" + item + " tidak ditemukan di dalam array");

                Console.WriteLine("\nNomor Comparisons : " + ctr);
                
                Console.Write("\nLanjutkan Mencari? (y/n) : ");
                ch = Char.Parse(Console.ReadLine());
            }
            while ((ch == 'y') || (ch == 'Y'));
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                //menyimpan angka yang ingin di cari
                Console.Write("\nMasukkan Elemen yang ingin di cari : ");
                string item = Console.ReadLine();

                //penerapan binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //mendetekai indeks dari elemen paling tengah
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 0;

                //loop untuk mencari elemen dalam array
                while ((item != fay[mid]) && (lowerbound <= upperbound))
                {
                    if (item.CompareTo(fay[mid]) > 0)
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }

                if (item == fay[mid])
                    Console.WriteLine("\n" + item + " ditemukan pada posisi " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item + " Tidak ditemukan dalam array\n");

                Console.WriteLine("\nNomor Comparisons : " + ctr);

                Console.Write("\nLanjutkan Mencari? (y/n) : ");
                ch = Char.Parse(Console.ReadLine());
            }
            while ((ch == 'y') || (ch == 'Y'));
        }

        void Insertion()
        {
            //insertion sort
            // 1. Repeat steps 2, 3, 4, and 5 varying i from 1 to n – 1 
            for (i = 1; i < n; i++)
            {
                // set temp
                string temp = fay[i];
                // Set j = i – 1
                j = i - 1;
                // Repeat until j becomes less than 0 or arr[j] becomes less than or equal to temp:
                while ((j >= 0) && (fay[j].CompareTo(temp) > 0))
                {
                    // Shift the value at index j to index j + 1
                    fay[j + 1] = fay[j];
                    // Decrement j by 1
                    j--;
                }
                // Store temp at index j + 1
                fay[j + 1] = temp;
            }

            // Output Insertion Sorting
            Console.WriteLine("\n==============================================");
            Console.WriteLine(">>>>>>>> Diurutkan dengan InsertSort <<<<<<<<");
            Console.WriteLine("=============================================");

            for (i = 0; i < n; i++)
            {
                Console.WriteLine((i + 1) + ". " + fay[i]);

            }
        }

        static void Main(string[] args)
        {
            Program ini = new Program();

            
            int pilih;
            string ulang;
            ulang = "Y";
            while((ulang =="Y")||(ulang == "y"))
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Selamat Datang di Program Searching Nama");
                Console.WriteLine("========================================");
                a://isi a 
                Console.WriteLine("\n Pilihan Metode Search : ");
                Console.WriteLine("\n 1. Linear Search");
                Console.WriteLine(" 2. Binary Search");
                Console.WriteLine(" 3. Exit");
                Console.Write(" pilihan (1/2/3) : ");
                pilih = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (pilih)
                {
                    
                    case 1:
                        Console.WriteLine(">>>>Program Linear Search<<<<\n");
                        ini.input();
                        ini.LinearSearch();
                        break;

                    
                    case 2:
                        Console.WriteLine(">>>>Program Binary Search<<<<\n");
                        ini.input();
                        ini.Insertion();
                        ini.BinarySearch();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Pilihan Salah !!!!");
                        Console.WriteLine("Masukkan pilihan 1-3");
                        goto a;
                        //untuk kembali ke a                                              
                }
                Console.Write("\nKembali Kemenu ? (Y/T) : ");
                ulang = Console.ReadLine();
                Console.Clear();
            }
        }
    }
