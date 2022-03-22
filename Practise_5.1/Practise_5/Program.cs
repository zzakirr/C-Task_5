using System;

namespace Practise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1,2
            Console.WriteLine("Notebook-un sayi:");
            int NoteCount = Convert.ToInt32(Console.ReadLine());
             Notebook[] notebook = new Notebook[NoteCount];
            for(int i = 0; i < notebook.Length; i++)
            {
                Console.WriteLine($"{i+1} - Notebook-un qiymeti:");
                double price = double.Parse(Console.ReadLine());
                notebook[i] = new Notebook(price);
            }
            Console.WriteLine("qiymey intervali teyin edin!");
            double minprice = Convert.ToDouble(Console.ReadLine());
            double maxprice = Convert.ToDouble(Console.ReadLine());
             var NotebookArr3 = PriceNotebooks(notebook, minprice, maxprice);
             foreach (var item in NotebookArr3)
             {
                 Console.WriteLine(item.Price);
             }
            #endregion

        }
        static Notebook[] PriceNotebooks(Notebook[] notebookArr,double MinPrice, double MaxPrice)
        {
            
            int Count = 0;
            for (int i = 0; i < notebookArr.Length; i++)
            { 
                if (notebookArr[i].Price > MinPrice && notebookArr[i].Price < MaxPrice)
                    Count++;
            }
            Notebook[] NotebookArr2 = new Notebook[Count];
            int j = 0;
            for (int i = 0; i < notebookArr.Length; i++)
            {
                if (notebookArr[i].Price > MinPrice && notebookArr[i].Price < MaxPrice)
                {
                    NotebookArr2[j] = notebookArr[i];
                    j++;
                }

            }
            
            return NotebookArr2;
        }


    }
}
