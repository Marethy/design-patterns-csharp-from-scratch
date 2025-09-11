using Command;

var light = new Light();
var lightOn = new LightOnCommand(light);
var lightOff = new LightOffCommand(light);

var remote = new RemoteControl();

remote.SetCommand(lightOn);
remote.PressButton();   // Light is ON
remote.PressUndo();     // Light is OFF

remote.SetCommand(lightOff);
remote.PressButton();   // Light is OFF
remote.PressUndo();     // Light is ON