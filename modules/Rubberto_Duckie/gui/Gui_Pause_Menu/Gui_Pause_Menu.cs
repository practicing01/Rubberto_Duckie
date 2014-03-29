/*Pause menu needs to be remade into its own module.*/

if (!isObject(Gui_Pause_Menu))
{

Rubberto_Duckie.add(TamlRead("./Gui_Pause_Menu.gui.taml"));

}

exec("./Buttons/Go_Main_Menu.cs");

function Rubberto_Duckie::Toggle_Pause_Menu(%this)
{

if ($Bool_Is_Playing)
{

if (!Gui_Pause_Menu.isAwake())
{

Canvas.pushDialog(Gui_Pause_Menu);

}
else
{

Canvas.popDialog(Gui_Pause_Menu);

}

}

}

GlobalActionMap.bindCmd(keyboard,"escape","Rubberto_Duckie.Toggle_Pause_Menu();","");
