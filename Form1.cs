using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Overlay_Watermark;

namespace Overlay_Watermark
{
    public partial class Form1 : Form
    {
        WatermarkService watermarkService;
        MusicService musicService;
        public Form1()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;

            watermarkService = new WatermarkService();
            musicService = new MusicService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog pathToWavFiles = new OpenFileDialog();
            pathToWavFiles.Multiselect = true;
            pathToWavFiles.Filter = "Wav file | *.wav";
            if (pathToWavFiles.ShowDialog() != DialogResult.OK) return;
            
            foreach(string file in pathToWavFiles.FileNames)
            {
                listBox1.Items.Add(file);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog pathToOutputFile = new SaveFileDialog();
            pathToOutputFile.FileName = "OtputFile";
            pathToOutputFile.DefaultExt = "*.mp3";
            pathToOutputFile.Filter = "MP3 File (.mp3)|*.mp3";
            if (pathToOutputFile.ShowDialog() != DialogResult.OK) return;

            var musicTrack = musicService.CreateMusicFile(listBox1.Items, Convert.ToDouble(pauseBetweenTrack.Text));
            var musicTrackLenght = musicService.GetTrackLenght(listBox1.Items, Convert.ToDouble(pauseBetweenTrack.Text));

            var watermarkTrack = watermarkService.CreateWatermarkFile(
                musicTrackLenght,
                pathToWM.Text,
                Convert.ToDouble(watermarkRepeat.Text),
                Convert.ToDouble(watermarkOffset.Text));

            var mixingFile = watermarkService.Overlay(musicTrack, watermarkTrack, Convert.ToDouble(watermarkOffset.Text));
            watermarkService.SaveMixToFile(mixingFile, pathToOutputFile.FileName);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pathToWM.Text = "SingleWM.mp3";
            }
            else
            if (comboBox1.SelectedIndex == 1)
            {
                OpenFileDialog pathToWMFile = new OpenFileDialog();

                pathToWMFile.Filter = "Wav and mp3 files | *.wav; *.mp3";
                if (pathToWMFile.ShowDialog() != DialogResult.OK) return;

                pathToWM.Text = pathToWMFile.FileName;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != 0)
            {
                var tempItemSelected = listBox1.SelectedItem;
                var tempItemUpper = listBox1.Items[listBox1.SelectedIndex - 1];
                var selectedIndex = listBox1.SelectedIndex;

                listBox1.Items.RemoveAt(selectedIndex - 1);

                listBox1.Items.Insert(selectedIndex, tempItemUpper);
                listBox1.Items.Insert(selectedIndex, tempItemSelected);

                listBox1.Items.RemoveAt(selectedIndex);
            }
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != listBox1.Items.Count-1)
            {
                var tempItemSelected = listBox1.SelectedItem;
                var tempItemUpper = listBox1.Items[listBox1.SelectedIndex + 1];
                var selectedIndex = listBox1.SelectedIndex;

                listBox1.Items.RemoveAt(selectedIndex + 1);

                listBox1.Items.Insert(selectedIndex, tempItemUpper);
                listBox1.Items.Insert(selectedIndex, tempItemSelected);

                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

    }
}
