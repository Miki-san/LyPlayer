using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using AxWMPLib;

namespace LyPlayer__ver._2._67_
{
    public partial class LyPlayer_main : Form
    {

        public LyPlayer_main()
        {
            InitializeComponent();
        }

        List<string> Files = new List<string>(); //List of files; Список файлов;
        List<string> Paths = new List<string>(); //List of file ways; Список путей файлов;

        private int playlist; //Length of playlist; Колличество треков в плэйлисте;
        private int durationOfTrack; //Duration time of track; Длина трека;
        private int currentTime; //Current time of track; Пройденное время трека;
        private int playingTrackIndex;

        private bool FirstAdd = true; //Is true if tracks add at first time; Является правдой, если трек плэйлист загружается впервые;

        public void FileOpen() //Opens file; Открытие файла;
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog()
                {
                    Filter = "MP3 Files|* .mp3| WAV|* .wav", //Filters for audiofiles; Фильтры аудиофайлов;
                    Multiselect = true, //User can multiselect files; Пользователь может выбрать несколько файлов за один раз;
                    ValidateNames = true //All names of files must be validate; Все имена файлов должны быть допустимыми;
                };

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    Files.AddRange(openFile.SafeFileNames); //Save names of selected files into 'Files' list of string; Сохраняет имена выбранных файлов в список строк 'Files';
                    Paths.AddRange(openFile.FileNames); //Save ways of selected files into 'Paths' list of string; Сохраняет пути выбранных файлов в список строк 'Paths';
                    Playlist_box.Items.Clear(); //Clears Playlist_box before loading new playlist; Очищает Playlist_box прежде чем загрузить новый плэйлист;
                    playlist = Files.Count; //'playlist' is a value of 'Files' length; Задаем значение переменной 'playlist';

                    foreach (string file in Files)
                    {
                        Playlist_box.Items.Add(file); //Load list of names into Playlist_box; Загружает список имен в Playlist_box;
                    } 
                }

                if (FirstAdd)
                {
                    Playlist_box.SetSelected(0, true); //Set selected first element in 'Playlist_box'; Устанавливаем курсор на первый трек плэйлиста;
                    FirstAdd = false;
                } 
            }
            catch (Exception){}
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
            playingTrackIndex = Playlist_box.SelectedIndex; 
            NPBox.Text = Files[playingTrackIndex]; //Writes name of now playing file in text box; Выводит имя проигрываемого файла в текстовый блок;
            axWindowsMediaPlayer1.settings.volume = Volume_Bar.Value; //Set volume to 100% value; Устанавливаем громкость на 100%;
            axWindowsMediaPlayer1.URL = Paths[playingTrackIndex]; //Adds way of now playing file in player; Добавляет путь проигрываемого файла в плеер;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Playlist_box_SelectedIndexChanged(object sender, EventArgs e) //Plays file if selected file index changed; Проигрывает файл если был изменен индекс выделенного файла;
        {
            try
            {
                if ((Playlist_box.SelectedIndex != playingTrackIndex) | (FirstAdd == true))
                {
                    PlayIndexFile();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
            }
        }

        public void Playlist_move(int shift) //Moves on playlist; Движение по плэйлисту;
        {
            Playlist_box.SetSelected((playingTrackIndex + shift + playlist) % playlist, true);
        }

        private void Next_button_Click(object sender, EventArgs e) //Plays next file; Проигрывание следущего файла;
        {
            try
            {
                Playlist_move(1); //Makes move down (right) in playlist; Делаем движение вниз (вправо) по плэйлисту;
            }
            catch (DivideByZeroException){}
        }

        private void Previous_button_Click(object sender, EventArgs e) //Plays previous file; Проигрывание предыдущего файла;
        {
            try
            {
                Playlist_move(-1); //Makes move up (left) in playlist; Делает движение вверх (влево) по плэйлисту;
            }
            catch (DivideByZeroException) {}
        }

        private void Play_button_Click(object sender, EventArgs e) //Plays or continuous file; Проигрывает файл или продолжает его воспроизведение;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.play(); //Says player to play or continuous file; Проигрывает или продолжает проигрывание файла;
            }
            catch (Exception){}
        }

        private void Pause_button_Click(object sender, EventArgs e) //Pause file; Ставит файл на паузу;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause(); //Says player to pause file; ставит файл на паузу;
            }
            catch (Exception){}
        }

        private void Stop_button_Click(object sender, EventArgs e) //Stops file playing; Остановка проигрывания файла. Ставит значение курсор времени в начало трека;
        {
            try
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop(); //Says player to stop file playing; Остановка проигрывания;
            }
            catch (Exception){}
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
            else if (e.newState == 8) //If MediaEnded; Если медиа файл кончился;
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
            else if (e.newState == 10) //If Waiting; Если ожидает;
            {
                try
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show($"Add track to play it!", "LyPlayer_Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; Пишет об ошибке в отдельное окно;
                }
            }
        }

        private void Time_track_timer_Tick(object sender, EventArgs e) //Timer for current time value; Таймер для значения пройденного времени;
        {
            currentTime = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            Music_bar.Value = currentTime;
            Time_box.Text = (currentTime / 60).ToString() + ":" + (currentTime % 60).ToString() + " / " + (durationOfTrack / 60).ToString() + ":" + (durationOfTrack % 60).ToString(); //Writes time of track; Выводит время трека;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LyPlayer." +
                "\nVersion: 2.67\n" +
                "\nСделано для свободного пользования.\n" +
                "\nРазработчики:\n" +
                "\n     Рыхлов Михаил\n" +
                "\n     Исаев Александр\n" +
                "\n     Посеканов Никита\n", "LyPlayer", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}