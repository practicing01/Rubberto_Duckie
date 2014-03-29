function Rubberto_Duckie::create(%this)
{

/*Core Misc*/

exec("./scripts/Misc/Misc_Initialize.cs");

initializeCanvas("Rubberto_Duckie");

Canvas.BackgroundColor="black";

Canvas.UseBackgroundColor=true;

initializeOpenAL();

/*Gui Init*/
exec("./gui/guiProfiles.cs");

/*Global Variables*/

exec("./scripts/Variables_Initialize.cs");

%this.Variables_Initialize();

/*Global Functions*/
exec("./scripts/Functions_Initialize/Functions_Initialize.cs");

/*Core Scene*/
exec("./scenes/Scene_Rubberto_Duckie.cs");

/*Pause Menu*/
exec("./gui/Gui_Pause_Menu/Gui_Pause_Menu.cs");

Window_Create_Rubberto_Duckie();

Scene_Create_Rubberto_Duckie();

Rubberto_Duckie.add(TamlRead("./gui/ConsoleDialog.gui.taml"));

GlobalActionMap.bind(keyboard,"tilde",toggleConsole);

new RenderProxy(CannotRenderProxy)
{

Image="Rubberto_Duckie:CannotRender";

};

Rubberto_Duckie.add(CannotRenderProxy);

Rubberto_Duckie.Camera_Size=Window_Rubberto_Duckie.getCameraSize();

%Local_Time=getLocalTime();

%Local_Time=stripChars(%Local_Time,":/");

%Local_Time=getWord(%Local_Time,0)+getWord(%Local_Time,1);

setRandomSeed(%Local_Time);

/*Load Play*/
exec("./scripts/Play_Load/Play_Load.cs");

%this.Play_Load();

}

function Rubberto_Duckie::destroy(%this)
{
Window_Destroy_Rubberto_Duckie();
}
