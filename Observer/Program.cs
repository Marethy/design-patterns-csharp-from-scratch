var subscribers = new List<ISubscriber>();
var socialMedia = new SocialMedia();
var user1 = new User("Alice");
var user2 = new User("Bob");
socialMedia.Subscribe(user1);
socialMedia.Subscribe(user2);
socialMedia.Notify("New post available!");
socialMedia.Unsubscribe(user1);
socialMedia.Notify("Another post available!");
