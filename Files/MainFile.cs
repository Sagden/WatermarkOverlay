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
    class MainFile
    {
        private ListBox.ObjectCollection trackList;
        private double trackLenght;
        private double pauseBetweenTrack;
        
        public MainFile(ListBox.ObjectCollection trackList, double pauseBetweenTrack)
        {
            this.trackList = trackList;
            this.pauseBetweenTrack = pauseBetweenTrack;
        }

        public ISampleProvider CreateMusicFile()
        {
            ISampleProvider readerMusic = new AudioFileReader(trackList[0].ToString());

            var getTime = new AudioFileReader(trackList[0].ToString());
            trackLenght += getTime.TotalTime.TotalSeconds;

            if (trackList.Count > 0)
            {
                for (int i = 1; i < trackList.Count; i++)
                {

                    var reader = new AudioFileReader(trackList[i].ToString());
                    trackLenght += reader.TotalTime.TotalSeconds;
                    trackLenght += pauseBetweenTrack;

                    readerMusic = readerMusic.FollowedBy(TimeSpan.FromSeconds(pauseBetweenTrack), reader);

                }
            }
            return readerMusic;
        }
        public double GetTrackLenght()
        {
            return trackLenght;
        }
    }
}
