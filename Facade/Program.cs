using Facade;

var homeTheater = new HomeTheaterFacade(new AudioSystem(), new VideoSystem(), new LightSystem());
homeTheater.WatchMovie();