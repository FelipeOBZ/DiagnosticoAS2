using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public interface IStreamingService
    {

        void PlayVideo(string idVideo);

        void AddVideo(Video video);
    }
}
