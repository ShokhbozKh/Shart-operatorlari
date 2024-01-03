namespace Shart_operatorlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Foydalanuvchi kiritgan sonning juft yoki toq bo'lishini aniqlash:
            //Foydalanuvchidan son kiritishni so'rang va kiritilgan sonning juft yoki toq ekanligini tekshiring.
            /* Console.Write("Son kiriting:");
             int number=int.Parse(Console.ReadLine());

             if(number == 0)
             {
                 Console.WriteLine("son 0 ga teng");
             }
             else if (number > 0)
             {
                 if (number % 2 == 0)
                 {
                     Console.WriteLine("Musbat Juft son");
                 }
                 else
                 {
                     Console.WriteLine("Musbat Toq son");
                 }

             }
             else if(number <0)
             {
                 if(number%2 == 0)
                 {
                     Console.WriteLine("Manfiy juft son");
                 }
                 else
                 {
                     Console.WriteLine("Manfiy toq son");
                 }
             }
             else
             {
                 Console.WriteLine("Kiritishda xatolik bor");
             }
            */

            #endregion

            #region 2
            //Foydalanuvchi kiritgan ikkita sonning kattasini topish:
            // Foydalanuvchidan ikkita son kiritishni so'rang va kiritilgan sonlarning kattasini aniqlang.
            /*
             * Console.Write("1- son kirit:");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("2-son kirit:");
            int  n2 = Convert.ToInt32(Console.ReadLine());
            var result = (n1 > n2) ? $"{n1} > {n2}  birinchi son katta" : $"{n1} < {n2} ikkinchi son katta";
            Console.WriteLine(result);
            */

            #endregion

            #region 3
            //Foydalanuvchi kiritgan yilning kabisa yili ekanligini tekshirish:
            //Foydalanuvchidan yil kiritishni so'rang va kiritilgan yilning kabisa
            //yili ekanligini aniqlang (4 ga karrali yillar).
            /*
            Console.Write("Yil kirit:");
            short year = Convert.ToInt16(Console.ReadLine());

            if((year > 0) && (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year-4}-yil oldingi kabisa yili\n" +
                    $"{year}-yil hozirgi kabisa yili kabisa yili\n" +
                    $"{year+4}-yil keyingi kabisa yili");
            }
            else
            {
                Console.WriteLine($"{year}-yil  Kabisa yili emas");
            }
            */
            #endregion

            #region 4
            //Foydalanuvchi kiritgan uch xarfini tartibini aniqlash:
            /* Foydalanuvchidan uch xarf kiritishni 
                 so'rang va kiritilgan harflarning alifbo tartibida (katta harf)
                 yoki teskari tartibida (kichik harf) bo'lishini aniqlang. */
            /*
            Console.Write("1- harf kiriting:");
            char letter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("2- harf kiriting:");
            char letter2 = Char.Parse(Console.ReadLine());
            Console.Write("3- harf kiriting:");
            Char letter3 = Convert.ToChar(Console.ReadLine());

            //Raqamga utqazib olish belgilarni ascii jadvaldagi joylashgan urni bo'yicha
            int l1, l2, l3;
            l1 = (int)letter1;
            l2 = (int)letter2;
            l3 = (int)letter3;

            if( (Char.ToUpper(letter1) == letter1) && (Char.ToUpper(letter2) == letter2) && (Char.ToUpper(letter3) == letter3))
            {
                Console.WriteLine("Kiritilgan harflar katta harflar.");
                if (l1 > l2 && l2 > l3)
                {
                    Console.WriteLine($"{l3}, {l2}, {l1}");
                }
                else if (l1 > l3 && l3 > l2)
                {
                    Console.WriteLine($"{l2}, {l3}, {l1}");
                }
                else if (l2 > l1 && l1 > l3)
                {
                    Console.WriteLine($"{l3}, {l1}, {l2}");
                }
                else if (l2 > l3 && l3 > l1)
                {
                    Console.WriteLine($"{l1}, {l3}, {l2}");
                }
                else if (l3 > l1 && l1 > l2)
                {
                    Console.WriteLine($"{l2}, {l1}, {l3}");
                }
                else if (l3 > l2 && l2 > l1)
                {
                    Console.WriteLine($"{l1}, {l2}, {l3}");
                }

            }
            else
            {
                Console.WriteLine("Kiritilgan harflar kichik harflar.");
                if (l1 > l2 && l2 > l3)
                {
                    Console.WriteLine($"{l1}, {l2}, {l3}");
                }
                else if (l1 > l3 && l3 > l2)
                {
                    Console.WriteLine($"{l1}, {l3}, {l2}");
                }
                else if (l2 > l1 && l1 > l3)
                {
                    Console.WriteLine($"{l2}, {l1}, {l3}");
                }
                else if (l2 > l3 && l3 > l1)
                {
                    Console.WriteLine($"{l2}, {l3}, {l1}");
                }
                else if (l3 > l1 && l1 > l2)
                {
                    Console.WriteLine($"{l3}, {l1}, {l2}");
                }
                else if (l3 > l2 && l2 > l1)
                {
                    Console.WriteLine($"{l3}, {l2}, {l1}");
                }
            }
            */
            

            #endregion

        }
    }
}
