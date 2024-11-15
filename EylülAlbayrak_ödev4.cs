// Soru 1
//namespace UcgeninAlanı
//{
//    class Program
//    {
//        public static int alan(int taban, int yükseklik)
//        {
//            int  sonuc;
//            sonuc = taban * yükseklik / 2;
//            return sonuc;
//        }
//        static void Main(string[] args)
//        {
//            double taban, yükseklik, alan;
//            Console.Write("Taban değerini giriniz: ");
//            taban = Double.Parse(Console.ReadLine());
//            Console.Write("Yükseklik değerini giriniz: ");
//            yükseklik = Double.Parse(Console.ReadLine());
//            alan = taban * yükseklik / 2;
//            Console.Write("Sonuç: {0} " , alan);
//            Console.ReadKey();
//        }


//    }
//}
// Soru 2
//namespace DizidekiEnBuyukSayi
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] dizi = new int[10];
//            int enbuyuk = 0;
//            for (int i = 0; i < dizi.Length; i++)
//            {
//                Console.Write("Dizinin " + (i + 1) + ". elemanını giriniz: ");
//                dizi[i] = Convert.ToInt32(Console.ReadLine());
//                if (dizi[i] > enbuyuk)
//                {
//                    enbuyuk = dizi[i];
//                }
//            }
//            Console.WriteLine("Dizinin en büyük elemanı = " + enbuyuk);
//            Console.ReadLine();
//        }
//    }
//}
// Soru 3
//using System;

//class OverloadedMethods
//{

//    public int Sum(int a, int b)
//    {
//        return a + b;
//    }

//    public double Sum(double a, double b)
//    {
//        return a + b;
//    }

//    public int CalculateSum(int a, int b, int c)
//    {
//        return a + b + c;
//    }

//    static void Main(string[] args)
//    {
//        OverloadedMethods om = new OverloadedMethods();


//        Console.WriteLine("İki int sayının toplamı : " + om.Sum(7, 13));
//        Console.WriteLine("İki double sayının toplamı : " + om.Sum(2.5, 6.5));
//        Console.WriteLine("Üç int sayının toplamı : " + om.CalculateSum(1, 2, 3));
//    }
//}
// Soru 4
//using System;

//class RecursiveFibonacci
//{

//    public static int Fibonacci(int n)
//    {

//        if (n == 0) return 0; 
//        if (n == 1) return 1; 


//        return Fibonacci(n - 1) + Fibonacci(n - 2);
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Fibonacci dizisindeki kaçıncı sayıyı hesaplamak istiyorsunuz ?  ");
//        int number = int.Parse(Console.ReadLine());

//        int result = Fibonacci(number);

//        Console.WriteLine($"{number}. Fibonacci sayısı: {result}");
//    }
//}
// Soru 5
//class ParamsİleOrtalamaHesabı
//{

//    public static double CalculateAverage(params double[] numbers)
//    {

//        if (numbers.Length == 0)
//            return 0;

//        double sum = 0;

//        foreach (double number in numbers)
//        {
//            sum += number;
//        }

//        return sum / numbers.Length;
//    }

//    static void Main(string[] args)
//    {

//        Console.WriteLine("Ortalama (7, 2, 6, 4, 8): " + CalculateAverage(7, 2, 6, 4, 8));
//        Console.WriteLine("Ortalama (17.5, 21.4): " + CalculateAverage(17.5, 21.4));
//        Console.WriteLine("Ortalama (boş): " + CalculateAverage());
//        Console.WriteLine("Ortalama (44): " + CalculateAverage(44));
//    }
//}
// Soru 6
//using System;

//class DiziFiltrelemeveToplama
//{

//    public static int SumFiltered(int[] numbers, int filterValue)
//    {
//        int sum = 0;


//        foreach (int number in numbers)
//        {
//            if (number > filterValue)
//            {
//                sum += number; 
//            }
//        }

//        return sum;
//    }

//    static void Main(string[] args)
//    {

//        int[] numbers = { 1, 5, 8, 10, 3, 12, 7 };

//        int filterValue = 5;

//        int result = SumFiltered(numbers, filterValue);
//        Console.WriteLine($"Filtre değerinden büyük olan elemanların toplamı: {result}");
//    }
//}
// Soru 7
//using System;

//class OptionalParametreİleYaş
//{

//    public static int YearsAbove18(int age = 18)
//    {

//        return age > 18 ? age - 18 : 0; 
//    }

//    static void Main(string[] args)
//    {

//        Console.WriteLine("Yaş 22 ise: " + YearsAbove18(22)); 

//        Console.WriteLine("Yaş belirtilmediğinde: " + YearsAbove18()); 

//        Console.WriteLine("Yaş 14 ise: " + YearsAbove18(14)); 
//    }
//}
// Soru 8
//class VeriFiltreleme
//{
    
//    public static List<string> FilterLongStrings(string[] inputStrings)
//    {
        
//        List<string> result = new List<string>();

        
//        foreach (string str in inputStrings)
//        {
            
//            if (str.Length > 5)
//            {
//                result.Add(str);
//            }
//        }

//        return result;
//    }

//    static void Main(string[] args)
//    {
        
//        string[] strings = { "can", "eylül", "beren", "mustafa", "yasemin" };

        
//        List<string> filteredStrings = FilterLongStrings(strings);

        
//        Console.WriteLine("5 karakterden uzun stringler:");
//        foreach (string str in filteredStrings)
//        {
//            Console.WriteLine(str);
//        }
//    }
//}
