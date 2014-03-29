function Rubberto_Duckie::Play_Load(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Rubberto_Duckie_Input_Controller";

};

Window_Rubberto_Duckie.addInputListener(%this.Script_Object_Input_Controller);

/*Load splashes*/

ModuleDatabase.LoadExplicit("Splashes");

Splashes.Scene_Load();

}
