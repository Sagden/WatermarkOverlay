using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Overlay_Watermark
{
    class WatermarkService
    {
        public string PathToOutputFile { get; set; }

        public bool Overlay(MainFile mainFile, WatermarkFile wm)
        {
            var mainMusicFile = mainFile.CreateMusicFile();                            //Получение готового файла с музыкой
            var mainWatermarkFile = wm.CreateWatermarkFile(mainFile);                  //Получение готового файла водяного знака

            NAudio.MediaFoundation.MediaFoundationApi.Startup();                       //Инициализация энкодера(чтобы получать на выходе любой формат)

            var sampleProvider = new OffsetSampleProvider(mainWatermarkFile.ToWaveProvider().ToSampleProvider()); //Деление на sample
            sampleProvider.DelayBy = TimeSpan.FromSeconds(wm.GetOffsetwatermarkTime());                           //Добавление задержки

            var watermarkWaveProvider = sampleProvider.ToWaveProvider();                        //Перевод в wave водяного знака
            var musicWaveProvider = mainMusicFile.ToWaveProvider();                             //Перевод в wave музыки

            var mix = new MixingWaveProvider32(new[] { musicWaveProvider, watermarkWaveProvider });       //Слияние трека и водяного знака
            mix.ToSampleProvider().ToWaveProvider16();

            MediaFoundationEncoder.EncodeToMp3(mix, PathToOutputFile, 320000);    //Создание mp3 файла с водяным знаком
            //WaveFileWriter.CreateWaveFile(PathToOutputFile, mix);               //Создание WAV файла с водяным знаком

            return true;
        }
    }
}
