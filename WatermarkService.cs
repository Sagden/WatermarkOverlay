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

        public MixingWaveProvider32 Overlay(ISampleProvider musicTrack, ISampleProvider watermarkTrack, double offsetWatermarkTime)
        {

            NAudio.MediaFoundation.MediaFoundationApi.Startup();                       //Инициализация энкодера(чтобы получать на выходе любой формат)

            var sampleProvider = new OffsetSampleProvider(watermarkTrack.ToWaveProvider().ToSampleProvider()); //Деление на sample
            sampleProvider.DelayBy = TimeSpan.FromSeconds(offsetWatermarkTime);                           //Добавление задержки

            var watermarkWaveProvider = sampleProvider.ToWaveProvider();                        //Перевод в wave водяного знака
            var musicWaveProvider = musicTrack.ToWaveProvider();                             //Перевод в wave музыки

            var mix = new MixingWaveProvider32(new[] { musicWaveProvider, watermarkWaveProvider });       //Слияние трека и водяного знака
            mix.ToSampleProvider().ToWaveProvider16();

            return mix;
        }

        public ISampleProvider CreateWatermarkFile(
            double musicTrackLenght,
            string pathToWatermarkFile, 
            double repeatWatermarkTimer, 
            double offsetWatermarkTime)
        {
            var readerWM = new AudioFileReader(pathToWatermarkFile);
            var watermarkLenght = readerWM.TotalTime.TotalSeconds;

            ISampleProvider provider = readerWM;

            //вычисление кол-ва водяных знаков на файле
            int watermarkCount = (int)((musicTrackLenght - offsetWatermarkTime) / (repeatWatermarkTimer + watermarkLenght));


            for (var i = 0; i < watermarkCount; i++) //Создание файла с водяными знаками равного по длинне с треком
            {
                AudioFileReader readerTemp = new AudioFileReader(pathToWatermarkFile);
                provider = provider.FollowedBy(TimeSpan.FromSeconds(repeatWatermarkTimer), readerTemp);
            }

            return provider;
        }

        public void SaveMixToFile(MixingWaveProvider32 mix, string pathToSave)
        {
            MediaFoundationEncoder.EncodeToMp3(mix, pathToSave, 320000);          //Создание mp3 файла с водяным знаком
            //WaveFileWriter.CreateWaveFile(PathToOutputFile, mix);               //Создание WAV файла с водяным знаком
        }
    }
}
