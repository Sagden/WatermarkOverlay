using System;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using Overlay_Watermark.Interfaces;

namespace Overlay_Watermark
{
    public class WatermarkService : IWatermarkService
    {
        public MixingWaveProvider32 Overlay(ISampleProvider music, ISampleProvider watermark, double watermarkOffset)
        {
            if (music == null || watermark == null)
                throw new ArgumentNullException("Не удалось наложить водяной знак. Трек или водяной знак были пустыми");

            // Инициализация энкодера(чтобы получать на выходе любой формат)
            NAudio.MediaFoundation.MediaFoundationApi.Startup();

            var sampleProvider = new OffsetSampleProvider(watermark.ToWaveProvider().ToSampleProvider()); //Деление на sample
            sampleProvider.DelayBy = TimeSpan.FromSeconds(watermarkOffset);                           //Добавление задержки

            var watermarkWaveProvider = sampleProvider.ToWaveProvider();                        //Перевод в wave водяного знака
            var musicWaveProvider = music.ToWaveProvider();                             //Перевод в wave музыки

            // Слияние трека и водяного знака
            var result = new MixingWaveProvider32(new[] { musicWaveProvider, watermarkWaveProvider });
            result.ToSampleProvider().ToWaveProvider16();

            return result;
        }

        public ISampleProvider Create(
            double musicLenght,
            string watermarkFilePath, 
            double watermarkRepeat, 
            double watermarkOffset)
        {
            var readerWM = new AudioFileReader(watermarkFilePath);
            var watermarkLenght = readerWM.TotalTime.TotalSeconds;

            ISampleProvider provider = readerWM;

            // Вычисление количества водяных знаков на файле
            int watermarkCount = 
                (int)((musicLenght - watermarkOffset) / (watermarkRepeat + watermarkLenght));

            // Создание файла с водяными знаками равного по длинне с треком
            for (var i = 0; i < watermarkCount; i++)
            {
                var readerTemp = new AudioFileReader(watermarkFilePath);
                provider = provider.FollowedBy(TimeSpan.FromSeconds(watermarkRepeat), readerTemp);
            }

            return provider;
        }

        public void SaveToFile(MixingWaveProvider32 music, string path)
        {
            MediaFoundationEncoder.EncodeToMp3(music, path, 320000);
            //WaveFileWriter.CreateWaveFile(path, music);
        }
    }
}
