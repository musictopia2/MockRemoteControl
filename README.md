# MockRemoteControl
This is a sample to show how to use the nuget packages to create a remote controls system.  This will only be a mock.  However, obviously the code for the commands can be replaced with anything you want.

#Installation Instructions

*First run the server app

*Second, run the client app

*Third, go to the url of http://localhost:5199/MockMusicRemoteControl

If you have a static local ip address, then the localhost can be changed to that one.
If you do, make sure to change the endpoint interface to it as well so both the host and the client has the correct hub to connect to (which is the server).

At this point, the page will say its not connected and give a date you either went to the page or the host disconnected.

*Fourth, run the host app

*Fifth, click pause on the client.

You will see the host updates with the time you paused.

The host uses delegates so you hook a delegate to do whatever method you want to do.
I use blazor for the UI.
However, obviously, blazor is not required in production for the host.
