using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Facade
{
    // Subsystems
    public class AudioSystem(string name)
    {
        public string Name { get; set; } = name;
        public void TurnOn() => Console.WriteLine($"{Name} Audio On");
    }

    public class VideoSystem(string name)
    {
        public string Name { get; set; } = name;
        public void TurnOn() => Console.WriteLine($"{Name} video  On");
    }

    public class LightSystem(string name)
    {
        public string Name { get; set; } = name;

        public void Dim() => Console.WriteLine($"{Name} video dimmed");
    }

    // Facade
    public class HomeTheaterFacade(AudioSystem audio, VideoSystem video, LightSystem light)
    {
        public void WatchMovie()
        {
            Console.WriteLine("Get ready for a movie...");
            light.Dim();
            video.TurnOn();
            audio.TurnOn();
        }
    }

}
