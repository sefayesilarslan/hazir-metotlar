namespace HazirMetotlar
{

    class HazirMetotlar
    {
        public static void Main(string[] args)
        {

            // Datetime metotları

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); //Günü string olarak verir
            Console.WriteLine(DateTime.Now.DayOfYear);  //Yılın kaçıncı gününde oldugumuzu verir

            Console.WriteLine(DateTime.Now.ToLongDateString()); // tarihi string olarak verir
            Console.WriteLine(DateTime.Now.ToShortDateString()); // tarihi sayısal olarak verir


            Console.WriteLine(DateTime.Now.ToLongTimeString()); // saati saniyeli olarak verir
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // saati saniyesiz olarak verir

            Console.WriteLine("******************");        

            Console.WriteLine(DateTime.Now.AddDays(2)); // 2 gün ekler
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddSeconds(25));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(5));

            // Datetime Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //String olarak günün tarihini
            Console.WriteLine(DateTime.Now.ToString("ddd")); //String olarak günün kısaltılmışı
            Console.WriteLine(DateTime.Now.ToString("dddd")); //String olarak gün

            Console.WriteLine(DateTime.Now.ToString("MM")); //String olarak ayın günü
            Console.WriteLine(DateTime.Now.ToString("MMM")); //String olarak ayın kısa adı
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //String olarak ayın adı


            Console.WriteLine(DateTime.Now.ToString("yy")); //String olarak yılın kısa tarihini
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //String olarak yılın tarihini


            // MATH KÜTÜPHANESİ
            Console.WriteLine(Math.Abs(-25)); // 25;
			Console.WriteLine(Math.Sin(10));
			Console.WriteLine(Math.Cos(10));
			Console.WriteLine(Math.Tan(10));
			Console.WriteLine(Math.Ceiling(22.3)); // 23
			Console.WriteLine(Math.Round(22.3)); // 22
			Console.WriteLine(Math.Round(22.7)); // 23
			Console.WriteLine(Math.Floor(22.7)); // 22
			Console.WriteLine(Math.Max(2, 6));
			Console.WriteLine(Math.Min(2, 6));
			Console.WriteLine(Math.Pow(3, 4)); // 3^4 û verir. 81.
			Console.WriteLine(Math.Sqrt(9)); // karekök alır. 3
			Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logoritmik karşılığını getirir.
		    Console.WriteLine(Math.Exp(3)); // e üzeri 3 û verir.
			Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
        }
    }

}