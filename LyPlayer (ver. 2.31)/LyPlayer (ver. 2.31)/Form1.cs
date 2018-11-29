﻿using System;
using System.Windows.Forms;

namespace LyPlayer__ver._2._31_
{
    public partial class LyPlayer_main : Form
    {

        public LyPlayer_main()
        {
            InitializeComponent();
        }

        private string[] files, paths; //Arrays of Names and Ways of these files in playlist; Массивы Имен и Путей файлов в плэйлисте;
        private int STI; //Selected track index; Индекс выбранного трека;
        private int playlist; //Length of playlist; Колличество треков в плэйлисте;
        private int durationOfTrack; //Duration time of track; Длинна трека;
        private int currentTime; //Current time of track; Пройденное время;

        private void LyPlayer_main_Load(object sender, EventArgs e)
        {
            STI = 0; //Default value of STI; Начальное значение индекса выбранного трека;
        }      

        public void FileOpen() //Opens file; Открытие файла;
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog() //Initialize new object 'openFile' of OpenFileDialog class; Инициализирует новый объект 'openFile' класса OpenFileDialog;
                {
                    Filter = "MP3 Files|* .mp3| WAV|* .wav", //Filters for audiofiles; Фильтры аудиофайлов;
                    Multiselect = true, //User can multiselect files; Пользователь может выбрать несколько файлов за один раз;
                    ValidateNames = true //All names of files must be validate; Все имена файлов должны быть допустимыми;
                };

                if (openFile.ShowDialog() == DialogResult.OK) //If system can open the dialog window...; Если система смогла открыть диалоговое окно...;
                {
                    files = openFile.SafeFileNames; //Save names of selected files into 'files' array of string; Сохраняет имена выбранных файлов в массив строк 'files';
                    paths = openFile.FileNames; //Save ways of selected files into 'paths' array of string; Сохраняет пути выбранных файлов в массив строк 'paths';
                    Playlist_box.Items.Clear(); //Clears Playlist_box before loading new playlist; Очищает Playlist_box прежде чем загрузить новый плэйлист;
                    playlist = files.Length; //'playlist' is a value of 'files' length; Задаем значение переменной 'playlist';

                    for (int i = 0; i < playlist; i++)
                    {
                        Playlist_box.Items.Add(files[i]); //Adds names of files into 'Playlist_box' from 'files'; Добавляем имена файлов в 'Playlist_box' из массива 'files';
                    }
                }

                Playlist_box.SetSelected(0, true); //Set selected first element in 'Playlist_box'; Устанавливаем выделение на первый трек плэйлиста;

            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Choose file to play it!", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в новом окне;
            }

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e) //Opens file dialog window if you click tool strip menu; Открывает диалоговое окно если вы открываете верхнее меню;
        {
            FileOpen();
        }

        private void AddTrack_button_Click(object sender, EventArgs e) //Opens file dialog window if click 'addTrack' button; Открывает диалоговое окно если нажата кнопка 'addTrack';
        {
            FileOpen();
        }

        public void PlayIndexFile() //Plays file by its index in 'paths'; Играет трек по его индексу в массиве 'paths';
        {
            axWindowsMediaPlayer1.URL = paths[STI]; //Adds way of now playing file in player; Добавляет путь проигрываемого файла в плеер;
            NPBox.Text = files[STI]; //Writes name of now playing file in text box; Выводит имя проигрываемого файла в текстовый блок;
            axWindowsMediaPlayer1.settings.volume = 100; //Set volume to 100% value; Устанавливаем громкость на 100%;
            axWindowsMediaPlayer1.Ctlcontrols.play(); //Says to player play the file; Запускает плеер;
        }

        private void Playlist_box_SelectedIndexChanged(object sender, EventArgs e) //Plays file if selected file index changed; Проигрывает файл если был изменен индекс выделенного файла;
        {
            try
            {
                PlayIndexFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }

        }

        public void Playlist_move(int shift) //Moves on playlist; Движение по плэйлисту;
        {
            STI = (STI + shift + playlist) % playlist; // Makes new value of STI; Задает новое значение индекса выделенного трека;
            Playlist_box.SetSelected(STI, true); //Set selected file by new index; Ставит выделение на трек по его индексу в плэйлисте;
        }

        private void Next_button_Click(object sender, EventArgs e) //Plays next file; Проигрывание следущего файла;
        {
            try
            {
                Playlist_move(1); //Makes move down (right) in playlist; Делаем движение вниз (вправо) по плэйлисту;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show($"Add track to play it!", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }

        private void Previous_button_Click(object sender, EventArgs e) //Plays previous file; Проигрывание предыдущего файла;
        {
            try
            {
                Playlist_move(-1); //Makes move up (left) in playlist; Делает движение вверх (влево) по плэйлисту;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show($"Add track to play it!", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }

        private void Play_button_Click(object sender, EventArgs e) //Plays or continuous file; Проигрывает файл или продолжает его воспроизведение;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.play(); //Says player to play or continuous file; Проигрывает или продолжает проигрывание файла;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }

        private void Pause_button_Click(object sender, EventArgs e) //Pause file; Ставит файл на паузу;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause(); //Says player to pause file; ставит файл на паузу;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }

        private void Volume_Bar_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = Volume_Bar.Value; //Bind volume value to scroll bar; Привязываем значение громкости к ползунку;
        }

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) //Call when state of playing changes;
        {
            if (e.newState == 3) //If Playing; Если идет проигрывание;
            {
                double dur = axWindowsMediaPlayer1.currentMedia.duration; //Duration time of track; Длина трека;
                durationOfTrack = (int)dur; 
                Music_bar.Maximum = durationOfTrack; //Set maximum value for Music bar; Устанавливаем максимальное значение для Music bar;
            }
        }

        private void Time_track_timer_Tick(object sender, EventArgs e) //Timer for current time value; Таймер для значения пройденного времени;
        {
            currentTime = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Music_bar.Value = currentTime;
            Time_box.Text = (currentTime / 60).ToString() + ":" + (currentTime % 60).ToString() + " / " + (durationOfTrack / 60).ToString() + ":" + (durationOfTrack % 60).ToString(); //Writes time of track; Выводит время трека;
        }

        private void Stop_button_Click(object sender, EventArgs e) //Stops file playing; Остановка проигрывания файла. Ставит значение курсор времени в начало трека;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop(); //Says player to stop file playing; Остановка проигрывания;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }
    }
}

