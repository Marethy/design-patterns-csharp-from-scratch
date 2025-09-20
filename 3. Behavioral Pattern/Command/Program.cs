using Command;

var livingRoomLight = new Light("Living Room Light");
var lightCommand = new LightCommand(livingRoomLight);
var remote = new Remote(lightCommand);

remote.PressButton();  // Output: Living Room Light turned on
remote.PressUndo();    // Output: Living Room Light turned off
var userVoice = new UserVoice(lightCommand);
userVoice.TalkTurnOn(); // Output: Living Room Light turned on
userVoice.TalkTurnOff(); // Output: Living Room Light turned off