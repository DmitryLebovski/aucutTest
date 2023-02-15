using System;

namespace классы1
{
    class Audio_info
    {
        //поля
        string title;
        int duration;

        //конструкторы
        public Audio_info(string a, int b)
        {
            title = a;
            duration = b;
        }

        public Audio_info(string a)
        {
            title = a;
            duration = 0;
        }

        public Audio_info(int b)
        {
            title = "Track_Placeholder";
            duration = b;
        }

        public Audio_info()
        {
            title = "Track_Placeholder";
            duration = 0;
        }

        //метод
        public void info_track()
        {
            int sec = duration;
            int min = sec / 60;
            if (sec > 60) {
                Console.WriteLine($"Title: {title}, Duration: {string.Format("{0:00}", min)}:{string.Format("{0:00}", sec - 60)}");
            } else if(sec > 0)
            {
                Console.WriteLine($"Title: {title}, Duration: {string.Format("{0:00}", min)}:{string.Format("{0:00}", sec)}");
            } else
            {
                Console.WriteLine($"Title: {title}, Duration: {string.Format("{0:00}", min)}:{string.Format("{0:00}", 0)}");
            }
        }

        public int cut_track(int a, int b)
        {
            if (duration > 0 && a <= duration && b <= duration)
            {
                int new_duration = duration - a - (duration - b);
                duration = new_duration;
                //duration = duration - new_duration;
                return duration;
            } else {
                return 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Audio_info track1 = new Audio_info("LET U GO", 134);
            track1.info_track();
            Console.WriteLine($"New duration: {track1.cut_track(13, 45)} sec.");
            track1.info_track();
            Console.ReadKey(); 
        }
    }
}

//2 глава должна быть готова к 12(20) апреля (печатать), список литературы тоже дожен быть
//курсовая работа должна быть готова к 18 мая
// 10 мая можно сдать раньше
// титульный лист
// введение - 1-2 страницы
// обязательно лист содержания
// главы - 4-6 страниц
// заключение - 1 страница
// список литературы(по госту), количество источников - не менее 3, в главах ссылка на каждый источник
