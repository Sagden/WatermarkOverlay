using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Overlay_Watermark
{
    class WatermarkFile
    {
        private string pathToFile;
        private double watermarkLenght;
        private double repeatWatermarkTimer;
        private double offsetWatermarkTime;

        public WatermarkFile(string pathToFile, double repeatWatermarkTimer, double offsetWatermarkTime)
        {
            this.pathToFile = pathToFile;
            this.repeatWatermarkTimer = repeatWatermarkTimer;
            this.offsetWatermarkTime = offsetWatermarkTime;
        }

        public double GetWatermarkLenght()
        {
            return watermarkLenght;
        }
        public double GetOffsetwatermarkTime()
        {
            return offsetWatermarkTime;
        }

        public ISampleProvider CreateWatermarkFile(MainFile mainFile)
        {
            var readerWM = new AudioFileReader(pathToFile);
            watermarkLenght = readerWM.TotalTime.TotalSeconds;

            ISampleProvider provider = readerWM;

            //вычисление кол-ва водяных знаков на файле
            int watermarkCount = CalculateWatermarkCount(mainFile.GetTrackLenght());


            for (var i = 0; i < watermarkCount; i++) //Создание файла с водяными знаками равного по длинне с треком
            {
                AudioFileReader readerTemp = new AudioFileReader(pathToFile);
                provider = provider.FollowedBy(TimeSpan.FromSeconds(repeatWatermarkTimer), readerTemp);
            }

            return provider;
        }

        private int CalculateWatermarkCount(double musicTrackLenght)
        {
            double wmCount = (musicTrackLenght - offsetWatermarkTime) / (repeatWatermarkTimer + watermarkLenght);
            return (int)wmCount;
        }
    }
}
