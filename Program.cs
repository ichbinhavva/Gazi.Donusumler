namespace Gazi.Donusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());

            //int sayac = 0;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine (sayac == 2 ? "Asal": "Asal Değildir" ) ;


            //aritmetik ortalama

            //Console.WriteLine("Bir sayı giriniz:");
            //int toplam = int.Parse(Console.ReadLine());

            //int sayac = 0;
            //for (int i = 1;i<= toplam; i++)
            //{
            //    sayac +  ;
            //}


            //iç içe döngüler

            //for (int i = 0;i<3;i++) 
            //{
            //    for(int j = 0;j<4;j++)
            //    {
            //        Console.Write($"{i},{j}");
            //    }
            //Console.WriteLine();
            //}


            //for(int i= 1; i<=5; i++ )
            //{
            //    for (int j = 0; j<i; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine();
            //}



            //for(int i= 0;i<=5; i++ ) 
            //{
            //    for (int j= 0;j<5; j++ )
            //    {
            //        Console.WriteLine((i + j) % 2== 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("Enter row count:");
            //int row = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter column count:");
            //int column = int.Parse(Console.ReadLine());


            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //abcd=4*dcba
            //abcd?


            // for (int a = 1; a<10; a++)
            //{
            //    for(int b = 0; b<10; b++)
            //    {
            //        for(int c = 0; c<10; c++)
            //        {
            //            for(int d = 0; d<10; d++)
            //            {
            //                if( 1000*a+ 100*b+ 10*c+ d ==4 *(1000*d + 100*c + 10*b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                }
            //            }
            //        }
            //    }
            //}

            
            
            
            
            //3-4-5


            // for(int i =1 ; i < 50; i++)
            //{
            //    for( int j = 1; j < 50; j++)
            //    {
            //        for( int k= 1;k< 50; k++)
            //        {
            //            if (i * i + j * j == k * k)
            //            {
            //                Console.WriteLine($"{i}{j}{k}");
            //            }
            //        }
            //    }
            //}


            //Enter starting number=5
            // Enter end number=8
            //5- is prime
            //6- İs not prime
            //7- İs prime
            //8- İs not prime

            // iç içe for döngülerini 2 boyutlu olarak kullanabiliriz. excel de yaptığımız gibi
            // yapıları karşılaştırmak isterkende kullanabiliriz.




            //Console.WriteLine("Enter starting number:");
            //int start= int.Parse( Console.ReadLine() );
            //Console.WriteLine("Enter end number:");
            //int end=int.Parse( Console.ReadLine() );

            //for(int i = start ; i<end; i++)
            //{
            //    int count= 0;
            //    for(int j = 2 ; j<=(i/2); j++)
            //    {
            //        count++;
            //        break;
            //    }
            //}
            //Console.WriteLine( count == 0 ? $"{i}-İs prime" : $"{i}-İs not prime");

           
            //parantez içi true olana kadar sonsuza kadar devam eder. while döngüsü
            int count = 0;
            while (true)
            {
                Console.WriteLine("Gazi");
                count++
            }



           

            int max = int.MinValue;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi= int.Parse(Console.ReadLine());
               

                if(sayi>max)
                {
                    max = sayi;
                }
                
                Console.WriteLine("Devam etmek istiyor musunuz?");
                string harf = Console.ReadLine();
                if(harf=="h")
                {
                    break;
                }
            }

            do
            {
                Console.WriteLine(" Gazi");
            } while (true);

            int max = int.MinValue;
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = int.Parse(Console.ReadLine());


                if (sayi > max)
                {
                    max = sayi;
                }

                Console.WriteLine("Devam etmek istiyor musunuz?");
                string harf = Console.ReadLine();
                if (harf == "h")
                {
                    break;
                }
            }


            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j<10; j++) 
                {
                    Random rnd = new.Random();
                    int number = rnd.Next(33, 127);
                    Console.Write((char)number);
                }
                Console.WriteLine();
            }

              
            





        } 
    }
}
// Ascii : random atarken char karşılığını verir. vermiş olduğun değer aralıklarında bir karşılığı var. bunu şifre bulmak için kullanabiliriz.