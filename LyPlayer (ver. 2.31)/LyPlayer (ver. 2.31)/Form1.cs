using System;
using System.Windows.Forms;

namespace LyPlayer__ver._2._31_
{
    public partial class LyPlayer_main : Form
    {
        
        public LyPlayer_main()
        {
            InitializeComponent();
        }

        private string[] files, paths; //Arrays of Names and Ways of these files in playlist;
        private int STI; //Selected track index;
        private int playlist; //Length of playlist;

        private void LyPlayer_main_Load(object sender, EventArgs e) //Does smth when LyPlayer loaded;
        {
            STI = 0; //Default value of STI;
        }

        public void FileOpen() //Opens file;
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog() //Initialize new object 'openFile' of OpenFileDialog class;
                {
                    Filter = "MP3 Files|* .mp3| WAV|* .wav", //Filters for audiofiles;
                    Multiselect = true, //User can multiselect files;
                    ValidateNames = true //All names of files must be validate;
                };
    
                if (openFile.ShowDialog() == DialogResult.OK) //If system can open the dialog window...;
                {
                    files = openFile.SafeFileNames; //Save names of selected files into 'files' array of string;
                    paths = openFile.FileNames; //Save ways of selected files into 'paths' array of string;

                    for (int i = 0; i < files.Length; i++)
                    {
                        Playlist_box.Items.Add(files[i]); //Adds names of files into 'Playlist_box' from 'files';
                    }
                }

                playlist = files.Length; //'playlist' is a value of 'files' length;
                Playlist_box.SetSelected(0, true); //Set selected first element in 'Playlist_box';

            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window; 
            }

        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e) //Opens file dialog window if you click tool strip menu;
        {
            FileOpen();
        }

        private void AddTrack_button_Click(object sender, EventArgs e) //Opens file dialog window if click 'addTrack' button;
        {
            FileOpen();
        }

        public void PlayIndexFile() //Plays file by its index in 'paths';
        {
            axWindowsMediaPlayer1.URL = paths[STI]; //Adds way of now playing file in player;
            NPBox.Text = files[STI]; //Writes name of now playing file in text box;
            axWindowsMediaPlayer1.Ctlcontrols.play(); //Says to player play the file;
        }

        private void Playlist_box_SelectedIndexChanged(object sender, EventArgs e) //Plays file if selected file index changed;
        {
            try
            {
                PlayIndexFile();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }

        }

        public void Playlist_move(int shift) //Moves on playlist;
        {
            STI = (STI + shift + playlist) % playlist; // Makes new value of STI;
            Playlist_box.SetSelected(STI, true); //Set selected file by new index;
        }

        private void Next_button_Click(object sender, EventArgs e) //Plays next file;
        {
            try
            {
                Playlist_move(1); //Makes move down (right) in playlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }
        }

        private void Previous_button_Click(object sender, EventArgs e) //Plays previous file;
        {
            try
            {
                Playlist_move(-1); //Makes move up (left) in playlist;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }
        }

        private void Play_button_Click(object sender, EventArgs e) //Plays or continuous file;
        {
            try
            {
            axWindowsMediaPlayer1.Ctlcontrols.play(); //Says player to play or continuous file;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }
        }

        private void Pause_button_Click(object sender, EventArgs e) //Pause file;
        {
            try
            {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); //Says player to pause file;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }

        }

        private void Stop_button_Click(object sender, EventArgs e) //Stops file playing;
        {
            try
            {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); //Says player to stop file playing;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); //Writes about error in another window;
            }

        }
    }
}
