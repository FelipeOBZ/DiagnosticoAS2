using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prueba1
{
    public class VideoFeatures : IVideoFeatures
    {
        public void Play(string videoId)
        {
            Console.WriteLine("Reproduciendo video: "+ videoId);
        }

        public void Save(Video video, string outText)
        {
            Console.WriteLine("Guardando video "+ outText+ ": "+ JsonConvert.SerializeObject(video));
        }
    }
}
