using Observer;

IPublisher techNews = new Publisher("Tech News");
IPublisher sportsNews = new Publisher("Sports News");

// Tạo subscribers
ISubscriber alice = new Subscriber("Alice");
ISubscriber bob = new Subscriber("Bob");
ISubscriber charlie = new Subscriber("Charlie");

// Alice & Bob theo dõi Tech News
alice.SubscribeTo(techNews);
bob.SubscribeTo(techNews);

// Charlie theo dõi Sports News
charlie.SubscribeTo(sportsNews);

// Xuất bản tin tức
techNews.Publish("C# 13 Released!");
sportsNews.Publish("Manchester United won the match!");

// Bob hủy theo dõi Tech News
bob.UnsubscribeFrom(techNews);

// Xuất bản lần nữa
techNews.Publish("ASP.NET 9 is coming!");