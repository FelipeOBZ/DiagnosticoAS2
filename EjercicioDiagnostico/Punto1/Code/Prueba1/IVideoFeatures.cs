using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public interface IVideoFeatures
    {
        void Play(string videoId);
        void Save(Video video, string outText);
    }
}
