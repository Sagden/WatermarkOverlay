using NAudio.Wave;

namespace Overlay_Watermark.Interfaces
{
    public interface IWatermarkService
    {
        /// <summary>
        /// Наложение водяного знака
        /// </summary>
        /// <param name="music">Трек</param>
        /// <param name="watermark">Водяной знак</param>
        /// <param name="watermarkOffset">Пауза между треками</param>
        MixingWaveProvider32 Overlay(ISampleProvider music, ISampleProvider watermark, double watermarkOffset);

        /// <summary>
        /// Создание водяного знака
        /// </summary>
        /// <param name="musicLenght">Длительность трека</param>
        /// <param name="watermarkFilePath">Путь к водяному знаку</param>
        /// <param name="watermarkRepeat"></param>
        /// <param name="watermarkOffset"></param>
        ISampleProvider Create(double musicLenght, string watermarkFilePath, double watermarkRepeat, double watermarkOffset);

        /// <summary>
        /// Сохранение трека в файл
        /// </summary>
        /// <param name="music">Трек</param>
        /// <param name="path">Путь</param>
        void SaveToFile(MixingWaveProvider32 music, string path);
    }
}
