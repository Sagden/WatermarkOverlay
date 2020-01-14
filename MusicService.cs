using System;
using System.Collections.Generic;
using System.Linq;
using NAudio.Wave;
using Overlay_Watermark.Interfaces;

namespace Overlay_Watermark
{
    public class MusicService : IMusicService
    {
        public ISampleProvider Create(List<string> musicList, double musicBreak)
        {
            if (musicList == null) 
                throw new ArgumentNullException("Список треков пуст");

            ISampleProvider readerMusic = new AudioFileReader(musicList.First());

            foreach (var music in musicList)
            {
                if (musicList.IndexOf(music) == 0) 
                    continue;

                var reader = new AudioFileReader(music);
                readerMusic = readerMusic.FollowedBy(TimeSpan.FromSeconds(musicBreak), reader);
            }
            return readerMusic;
        }

        public double GetLenght(List<string> musicList, double musicBreak)
        {
            var getTime = new AudioFileReader(musicList[0].ToString());
            double trackLenght = getTime.TotalTime.TotalSeconds;

            if (musicList.Count > 0)
            {
                for (int i = 1; i < musicList.Count; i++)
                {

                    var reader = new AudioFileReader(musicList[i].ToString());
                    trackLenght += reader.TotalTime.TotalSeconds;
                    trackLenght += musicBreak;

                }
            }
            return trackLenght;
        }
    }
}
