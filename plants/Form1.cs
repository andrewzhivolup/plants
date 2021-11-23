﻿using System;
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
        string starttime, endtime;//переменная времени начала и окончания записи
        int timelapse; // частота таймлапса
        bool btnisbool = false; // нажата ли клавиша "старт"
        string path = @"c:\photo"; // путь для сохранения картинок
    
        private void startbtn_Click(object sender, EventArgs e)
        {
            if (btnisbool == false) //если запись остановлена
            {
                btnisbool = true;
                startbtn.Text = "Стоп";
                starttime = starttimeBox.Text; //переменная времени начала записи
                endtime = endtimeBox.Text; //переменная времени остановки записи
                timelapse = Convert.ToInt32(timelapseBox.Text) * 60 *10; //частота таймлапса
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
                endtimeBox.Enabled = true;   // включаем текстбоксы с параметрами
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

        private void timelapsetimer_Tick(object sender, EventArgs e)
        {
            
            if (true)
            {
                snapshot();
            }
            else
            {
                
            }
        }

        private void snapshot()
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = "cmd.exe";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/c ffmpeg.exe -f dshow -i video=""Integrated Camera"" -vframes 1 -strftime 1 ""c:\photo\%Y-%m-%d_%H-%M-%S.png""";
            Process.Start(cmd);
        }
        public void SetTime()
        {
            DateTime time = new DateTime();



        }

    }
}
