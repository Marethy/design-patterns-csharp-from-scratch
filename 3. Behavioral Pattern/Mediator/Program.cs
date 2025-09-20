using Mediator;

IChatRoomMediator chatRoom = new ChatRoomMediator();

IUser alice = new User("Alice", chatRoom);
IUser bob = new User("Bob", chatRoom);
IUser charlie = new User("Charlie", chatRoom);

alice.SendMessage("Hello Bob!", bob);
bob.SendMessage("Hi Alice, how are you?", alice);