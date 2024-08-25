using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public class StreamingService : IStreamingService
    {
        public readonly IVideoFeatures _features;
        public StreamingService(IVideoFeatures features)
        {
            _features = features;
        }

        public void AddVideo(Video video)
        {
            if(video.Category == "Premiun")
            {
                _features.Save(video, "Premiun");
            }
            else
            {
                _features.Save(video, "Normal");

            }
        }

        public void PlayVideo(string idVideo)
        {
            _features.Play(idVideo);
        }
    }
}
