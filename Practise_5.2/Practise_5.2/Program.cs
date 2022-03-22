using System;

namespace Practise_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece kitab isteyirsiniz?");
            int bookCount = Convert.ToInt32(Console.ReadLine());
            while(bookCount <= 0)
            {
                Console.WriteLine("Nece kitab isteyirsiniz?");
                bookCount = Convert.ToInt32(Console.ReadLine());
            }

            Library library = new Library();
            library.books = new Book[bookCount];

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine("Kitabin adi?");
                string name = Console.ReadLine();
                while(name.Length<=1 || name.Length>=50)
                {
                    Console.WriteLine("Kitabin adin duzgun teyin edin!");
                    name = Console.ReadLine();
                }
                Console.WriteLine("Kitabin janri?");
                string genre = Console.ReadLine();
                while(genre.Length<=3 || genre.Length>=20)
                {
                    Console.WriteLine("Kitabin janrin duzgun teyin edin!");
                    genre = Console.ReadLine();
                }
                int no = 0;
                bool check = true;
                while(check)
                {
                    check = false;
                    Console.WriteLine("Kitabin nomresi?");
                    no = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if(library.books[j].No==no)
                        {
                            check = true;
                            break;
                        }

                    }

                }

                Console.WriteLine("Kitabin qiymeti?");
                double price = Convert.ToDouble(Console.ReadLine());
                while(price <= 0 )
                {
                    Console.WriteLine("Kitabin qiymetini duzgubn teyin edin!");
                    price = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Kitabin saayi?");
                int count = Convert.ToInt32(Console.ReadLine());
                while(count <= 0)
                {
                    Console.WriteLine("Kitabin saayini duzgun teyin edin?");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                Book book = new Book(genre, no, name, price, count);
                library.AddBook(book);

            }

            Console.WriteLine("Filterlemek isteyirsinizmi?");
            Console.WriteLine("isteyirsinizse -y- , eks teqdirde -n- secin!");
            char cavab = Convert.ToChar(Console.ReadLine());
            while((cavab != 'y') && (cavab != 'n'))
            {
                Console.WriteLine("cavabi duzgun teyin edin!");
                cavab = Convert.ToChar(Console.ReadLine());
            }
            if(cavab =='y')
            {
                Console.WriteLine("filterlemek istediyiniz xususiyyeti secin!");
                Console.WriteLine("janr adina gore -1- , qiymet intervalina gore -2-");
                char cavab2 = Convert.ToChar(Console.ReadLine());
                while(cavab2!='1'&& cavab2!='2')
                {
                    Console.WriteLine("cavabi duzgun teyin edin!");
                    cavab2 = Convert.ToChar(Console.ReadLine());
                }
                if(cavab2=='1')
                {
                    Console.WriteLine("Janrin adini daxil edin:");
                    string genre = Console.ReadLine();
                    library.GetInfo(library.GetFilteredBooks(genre));   
                }
                if(cavab2=='2')
                {
                    double minprice = Convert.ToDouble(Console.ReadLine());
                    double maxprice = Convert.ToDouble(Console.ReadLine());
                    library.GetInfo(library.GetFilteredPrice(minprice, maxprice));
                }
                
            }
            else if (cavab == 'n')
            {
                library.GetInfo(library.books);
            }
        }
    }
}
