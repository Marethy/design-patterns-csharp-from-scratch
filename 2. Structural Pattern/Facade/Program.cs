using Facade;

var homeTheater = new HomeTheaterFacade(new AudioSystem("mp3"), new VideoSystem("mp4"), new LightSystem("red"));
homeTheater.WatchMovie();