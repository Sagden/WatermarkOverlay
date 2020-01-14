using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using Overlay_Watermark;
using NAudio.Wave;

namespace Overlay_Watermark
{
    class MusicService
    {
        public ISampleProvider CreateMusicFile(ListBox.ObjectCollection trackList, double pauseBetweenTrack)
        {
            ISampleProvider readerMusic = new AudioFileReader(trackList[0].ToString());

            if (trackList.Count > 0)
            {
                for (int i = 1; i < trackList.Count; i++)
                {
                    var reader = new AudioFileReader(trackList[i].ToString());
                    readerMusic = readerMusic.FollowedBy(TimeSpan.FromSeconds(pauseBetweenTrack), reader);
                }
            }
            return readerMusic;
        }


        public double GetTrackLenght(ListBox.ObjectCollection trackList, double pauseBetweenTrack)
        {

            var getTime = new AudioFileReader(trackList[0].ToString());
            double trackLenght = getTime.TotalTime.TotalSeconds;

            if (trackList.Count > 0)
            {
                for (int i = 1; i < trackList.Count; i++)
                {

                    var reader = new AudioFileReader(trackList[i].ToString());
                    trackLenght += reader.TotalTime.TotalSeconds;
                    trackLenght += pauseBetweenTrack;

                }
            }
            return trackLenght;
        }
    }
}
