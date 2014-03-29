function Module_Gameplay::Variables_Initialize(%this)
{

%this.Vector_2D_Rubberto_Duckie_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Rubberto_Duckie);

%this.Vector_2D_Goal_Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Goal);

%this.Vector_2D_World_Limits=Window_Rubberto_Duckie.getCameraSize();

%this.Gui_Text_Score=0;

%this.Int_Score=0;

%this.Bool_Is_Playing=true;

%this.Script_Object_Input_Controller=0;

%this.SceneObject_Kinematic_Paddle=0;

}
