using NAudio.Wave;
using System.Collections.Generic;

namespace Overlay_Watermark.Interfaces
{
    public interface IMusicService
    {
        /// <summary>
        /// Создание трека
        /// </summary>
        /// <param name="musicList">Список треков</param>
        /// <param name="musicBreak">Длительность паузы между треками</param>
        ISampleProvider Create(List<string> musicList, double musicBreak);

        /// <summary>
        /// Получение длительности трека
        /// </summary>
        double GetLenght(List<string> musicList, double musicBreak);
    }
}
