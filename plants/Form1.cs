using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace plants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TimeSpan starttime, endtime;//переменная времени начала и окончания записи
        int timelapse; // частота таймлапса
        bool btnisbool = false; // нажата ли клавиша "старт"
        string path = "c:\\photo"; // путь для сохранения картинок
        string camfolder1 = "\\cam0"; //название папки 1 камеры
        string camfolder2 = "\\cam1"; //название папки 2 камеры
        private void startbtn_Click(object sender, EventArgs e)
        {
            if (btnisbool == false) //если запись остановлена
            {
                if (!Directory.Exists(path))
                    createfolder();
                btnisbool = true;
                startbtn.Text = "Стоп";
                starttime = TimeSpan.Parse(starttimeBox.Text); //переменная времени начала записи
                endtime = TimeSpan.Parse(endtimeBox.Text); //переменная времени остановки записи
                timelapse = Convert.ToInt32(timelapseBox.Text) * 60 * 1000; //частота таймлапса
                starttimeBox.Enabled = false; //
                endtimeBox.Enabled = false;   // отключаем текстбоксы с параметрами
                timelapseBox.Enabled = false; //
                timelapsetimer.Interval = timelapse; //установка интервала таймлапса
                timelapsetimer.Enabled = true; //включить таймер

            }
            else //если запись идёт
            {
                btnisbool = false;
                startbtn.Text = "Старт";
                timelapsetimer.Enabled = false; //выключить таймер
                starttimeBox.Enabled = true; //
                endtimeBox.Enabled = true;   //включаем текстбоксы с параметрами
                timelapseBox.Enabled = true; //
            }
        }
        private void openbtn_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path)) // если не существует, То создать папки и открыть корневую
            {     
                createfolder();
                Process.Start("explorer.exe", path);
            }
            else
            {
                Process.Start("explorer.exe", path);//если существует, то открыть
            }
        }

        private void createfolder()
        {
            Directory.CreateDirectory(path);// создать корневую папку
            Directory.CreateDirectory(path + camfolder1);// создать папку камеры 0
            Directory.CreateDirectory(path + camfolder2);// создать папку камеры 1
        }

        private void timelapsetimer_Tick(object sender, EventArgs e) //тик таймера
        {
            if (GetTime() > starttime && GetTime() < endtime) //интервал времени
            {
                snapshot(); // снимок с камеры
            }
        }

        private void snapshot() //снимок с камеры
        {
            for (int i = 0; i <= 1; i++)
            {
                Process cmd = new Process(); //экземпляр процесса
                cmd.StartInfo.FileName = "cmd.exe"; //обращение к консоли
                cmd.StartInfo.Arguments = "/c ffmpeg.exe -f dshow -video_device_number " + i + " -i video=\"4000  \"  -vframes 1 -q:v 2  " +
                    "-s 4640x2608  -vf lenscorrection=cx=0.5:cy=0.5:k1=-0.227:k2=-0.022   -strftime 1 \"" + path + "\\cam" +i+ "\\%Y-%m-%d_%H-%M-%S.png\"";
                //cmd.StartInfo.Arguments = "/c ffmpeg.exe -f dshow -i video9=\"Integrated Camera\" -vframes 1 -strftime 1 \"" + path + "\\%Y-%m-%d_%H-%M-%S.png\""; // команда на снимок
                cmd.StartInfo.CreateNoWindow = true;//скрыть консоль
                cmd.Start();
                Thread.Sleep(1000);
            }   
        }

        private void testbtn_Click(object sender, EventArgs e) 
        {
            testbtn.Enabled = false;//
            snapshot(); //снимок с камеры
            Thread.Sleep(2000);     //задержка на съемку
            testbtn.Enabled = true; //
        }

        public TimeSpan GetTime() //получение текущего времени времени
        {
            return (DateTime.Now.TimeOfDay);
        }
    }
}
