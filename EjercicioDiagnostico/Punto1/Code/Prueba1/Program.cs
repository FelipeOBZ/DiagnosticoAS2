// Creamos un par de videos

using Prueba1;

Video video1 = new Video {
    Category = "Premiun",
    Type = "Comedy"
};


Video video2 = new Video
{
    Category = "Normal",
    Type = "Musical"
};

// Creamos una instancia de VideoFeatures y se de StreamingService, a la cual vamos a inyectar VideoFeatures

VideoFeatures options = new VideoFeatures();

StreamingService streaming = new StreamingService(options);


streaming.PlayVideo(video1.Type);
streaming.PlayVideo(video2.Type);

streaming.AddVideo(video1);
streaming.AddVideo(video2);
