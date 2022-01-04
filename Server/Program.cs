using RemoteControl.HubLibrary;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRemoteControlServices();
var app = builder.Build();
app.UseRouting();
app.AddRemoteControlServices();
app.Run();
//the port for sample is 5252

//used .net 6 empty template.
//this is set to not open browser since this is signal r only.
//means even if you add other commands to your remote control, this will never change.  can create unlimited remote control systems.