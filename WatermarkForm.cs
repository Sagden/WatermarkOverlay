using System;
using System.Windows.Forms;
using System.Linq;
using Overlay_Watermark.Interfaces;

namespace Overlay_Watermark
{
    public partial class WatermarkForm : Form
    {
        readonly IMusicService musicService;
        readonly IWatermarkService watermarkService;

        public WatermarkForm()
        {
            watermarkService = new WatermarkService();
            musicService = new MusicService();

            InitializeComponent();

            WatermarkList.SelectedIndex = default;
        }

        private void AddTrackButtonClick(object sender, EventArgs e)
        {
            var files = new OpenFileDialog();
            files.Multiselect = true;
            files.Filter = "Wav file | *.wav";
            if (files.ShowDialog() != DialogResult.OK)
                return;

            files.FileNames.ToList().ForEach(f => MusicList.Items.Add(f));
        }

        private void RemoveTrackButtonClick(object sender, EventArgs e)
        {
            // TODO: Переделать на проверки, если есть необходимость
            try
            {
                MusicList.Items.Remove(MusicList.Items[MusicList.SelectedIndex]);
            }
            catch { }
        }

        private void OverlayButtonClick(object sender, EventArgs e)
        {
            // Диалоговое окно
            var outputFile = new SaveFileDialog();
            outputFile.FileName = "OtputFile";
            outputFile.DefaultExt = "*.mp3";
            outputFile.Filter = "MP3 File (.mp3)|*.mp3";
            if (outputFile.ShowDialog() != DialogResult.OK) 
                return;

            // Создание основного трека
            var musicList = MusicList.Items?.Cast<string>()?.ToList();
            double musicBreak;
            if (!double.TryParse(PauseBetweenTrack.Text, out musicBreak))
                return;
            
            // TODO: Здесь надо дальше везде обрабатывать исключения на созданиях, наложениях и сохранениях
            var musicTrack = musicService.Create(musicList, musicBreak);
            var musicTrackLenght = musicService.GetLenght(musicList, musicBreak); // TODO: Передавать трек

            // Создание водяного знака
            var watermarkTrack = watermarkService.Create(
                musicTrackLenght,
                WatermarkPathLabel.Text,
                Convert.ToDouble(WatermarkRepeat.Text),
                Convert.ToDouble(WatermarkOffset.Text));

            // Наложение водяного знака и сохранение в файл
            var mixingFile = watermarkService.Overlay(musicTrack, watermarkTrack, Convert.ToDouble(WatermarkOffset.Text));
            watermarkService.SaveToFile(mixingFile, outputFile.FileName);

        }

        private void WatermarkListSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (WatermarkList.SelectedIndex)
            {
                case 0: 
                    WatermarkPathLabel.Text = "SingleWM.mp3"; // TODO: !!!
                    break;
                case 1:
                    var watermarkFile = new OpenFileDialog();
                    watermarkFile.Filter = "Wav or mp3 files | *.wav; *.mp3";
                    if (watermarkFile.ShowDialog() != DialogResult.OK) 
                        return;

                    WatermarkPathLabel.Text = watermarkFile.FileName;
                    break;
                default: 
                    break;
            }
        }
        
        private void UpButtonClick(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void DownButtonClick(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        private void MoveItem(int direction)
        {
            if (MusicList.SelectedItem == null || MusicList.SelectedIndex < 0)
                return;

            int newIndex = MusicList.SelectedIndex + direction;
            if (newIndex < 0 || newIndex >= MusicList.Items.Count)
                return;

            var selected = MusicList.SelectedItem;
            MusicList.Items.Remove(selected);
            MusicList.Items.Insert(newIndex, selected);
            MusicList.SetSelected(newIndex, true);
        }

    }
}
