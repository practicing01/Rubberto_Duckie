function Class_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandom(0+(%this.Module_ID_Parent.Vector_2D_Goal_Size.X*0.5),%this.Module_ID_Parent.Vector_2D_World_Limits.X-(%this.Module_ID_Parent.Vector_2D_Goal_Size.X*0.5));

%Vector_2D_Randomized_Offset.Y=getRandom(0+(%this.Module_ID_Parent.Vector_2D_Goal_Size.Y*0.5),%this.Module_ID_Parent.Vector_2D_World_Limits.Y-(%this.Module_ID_Parent.Vector_2D_Goal_Size.Y*0.5));

%this.Position=%Vector_2D_Randomized_Offset;

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Gui_Text_Score.setText("Score:" SPC %this.Module_ID_Parent.Int_Score);

/*if (%Colliding_Object.class$="Class_Rubberto_Duckie"&&!%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

schedule(0,0,"Gui_Gameplay::Go_Main_Menu",Gui_Gameplay);

}*/

}