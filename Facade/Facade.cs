using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Subsystems
    public class AudioSystem
    {
        public void TurnOn() => Console.WriteLine("Audio On");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
    }

    public class VideoSystem
    {
        public void TurnOn() => Console.WriteLine("Video On");
        public void SetResolution(string res) => Console.WriteLine($"Resolution set to {res}");
    }

    public class LightSystem
    {
        public void Dim() => Console.WriteLine("Lights dimmed");
    }

    // Facade
    public class HomeTheaterFacade(AudioSystem audio, VideoSystem video, LightSystem light)
    {
        public void WatchMovie()
        {
            Console.WriteLine("Get ready for a movie...");
            light.Dim();
            video.TurnOn();
            video.SetResolution("1080p");
            audio.TurnOn();
            audio.SetVolume(5);
        }
    }

}
