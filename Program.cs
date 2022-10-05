namespace Задание_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourse;
            int minute;
            int startTime = 9 * 60;
            int endTime = 16 * 60 + 10;
            int lessonTotal = (endTime - startTime) / (45 + 10) +1;
            int[,] lessonStartEnd = new int[2, lessonTotal];
            for (int i = 0; i < lessonTotal; i++)
            {
                lessonStartEnd[0, i] = (i > 0) ? lessonStartEnd[1, i - 1] + 10 : startTime;
                lessonStartEnd[1, i] = lessonStartEnd[0, i] + 45;
            }
            while (true)
            {
                Console.Write("Введите время формата (XX:YY). Введите ХХ: ");
                hourse = int.Parse(Console.ReadLine());
                Console.Write("Введите время формата (XX:YY). Введите YY: ");
                minute = int.Parse(Console.ReadLine());
                int userTime = (hourse * 60) + minute;
                if (userTime < startTime)
                {
                    Console.WriteLine("Уроки начнутся в 09:00.\n");
                }
                if (userTime > endTime)
                {
                    Console.WriteLine("Уроки заканчиваются в 16:10. \n");  
                }
                if (userTime >= startTime && userTime <= endTime)
                {
                    for (int i = 0; i < lessonTotal; i++)
                    {
                        if (userTime >= lessonStartEnd[0, i] && userTime <= lessonStartEnd[1, i])
                        {
                            Console.WriteLine($"Сейчас идёт {i + 1} урок.\n");
                            break;
                        }
                        if (userTime < lessonStartEnd[1, i])
                        {
                            Console.WriteLine($"Сейчас идёт {i} перемена. \n");
                            break;
                        }
                    }
                }
                //var timeChange0 = new TimeSpan(00, 00, 1);
                //var timeChange0End = new TimeSpan(08, 59, 9);
                //var timeLesson1 = new TimeSpan(09, 00, 0);
                //var timeLesson1End = new TimeSpan(09, 45, 0);
                //var timeChange1 = new TimeSpan(09, 45, 1);
                //var timeChange1End = new TimeSpan(09, 54, 9);
                //var timeLesson2 = new TimeSpan(09, 55, 0);
                //var timeLesson2End = new TimeSpan(10, 40, 0);
                //var timeChange2 = new TimeSpan(10, 40, 1);
                //var timeChange2End = new TimeSpan(10, 49, 9);
                //var timeLesson3 = new TimeSpan(10, 50, 0);
                //var timeLesson3End = new TimeSpan(11, 35, 0);
                //var timeChange3 = new TimeSpan(11, 35, 1);
                //var timeChange3End = new TimeSpan(11, 44, 9);
                //var timeLesson4 = new TimeSpan(11, 45, 0);
                //var timeLesson4End = new TimeSpan(12, 30, 0);
                //var timeChange4 = new TimeSpan(12, 30, 1);
                //var timeChange4End = new TimeSpan(12, 39, 9);
                //var timeLesson5 = new TimeSpan(12, 40, 0);
                //var timeLesson5End = new TimeSpan(13, 25, 0);
                //var timeChange5 = new TimeSpan(13, 25, 1);
                //var timeChange5End = new TimeSpan(13, 34, 9);
                //var timeLesson6 = new TimeSpan(13, 35, 0);
                //var timeLesson6End = new TimeSpan(14, 20, 0);
                //var timeChange6 = new TimeSpan(14, 20, 1);
                //var timeChange6End = new TimeSpan(14, 29, 9);
                //var timeLesson7 = new TimeSpan(14, 30, 0);
                //var timeLesson7End = new TimeSpan(15, 15, 0);
                //var timeChange8 = new TimeSpan(15, 15, 1);
                //var timeChange8End = new TimeSpan(15, 24, 9);
                //var timeLesson9 = new TimeSpan(16, 25, 0);
                //var timeLesson9End = new TimeSpan(16, 10, 0);
                //var timeChange9 = new TimeSpan(16, 10, 1);
                //var timeChange9End = new TimeSpan(23, 59, 9);
            }
        }
    }
}