using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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
    
        private void startbtn_Click(object sender, EventArgs e)
        {
            if (btnisbool == false) //если запись остановлена
            {
                btnisbool = true;
                startbtn.Text = "Стоп";
                starttime = TimeSpan.Parse(starttimeBox.Text); //переменная времени начала записи
                endtime = TimeSpan.Parse(endtimeBox.Text); //переменная времени остановки записи
                timelapse = Convert.ToInt32(timelapseBox.Text) * 60 * 10; //частота таймлапса
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
            if(!Directory.Exists(path)) 
            {
                Directory.CreateDirectory(path);// если не существует, то создать
            }
            else
            {
                Process.Start("explorer.exe", path);//если существует, то открыть
            }
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
            for (int i = 0; i < 1; i++)
            {
                Process cmd = new Process(); //экземпляр процесса
                cmd.StartInfo.FileName = "cmd.exe"; //обращение к консоли
                cmd.StartInfo.Arguments = "/c ffmpeg.exe -f dshow -video_device_number" + i + " -i video=\"4000  \"  -vframes 1 -q:v 2  -s 4640x2608  -vf lenscorrection=cx=0.5:cy=0.5:k1=-0.227:k2=-0.022   -strftime 1 \"" + path + "\\%Y-%m-%d_%H-%M-%S.png\""; ;
                //cmd.StartInfo.Arguments = "/c ffmpeg.exe -f dshow -i video=\"Integrated Camera\" -vframes 1 -strftime 1 \"" + path + "\\%Y-%m-%d_%H-%M-%S.png\""; // команда на снимок
                cmd.StartInfo.CreateNoWindow = true;//скрыть консоль
                cmd.Start();
            }   
        }
        public TimeSpan GetTime() //получение текущего времени времени
        {
            return (DateTime.Now.TimeOfDay);
        }
    }
}
