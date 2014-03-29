function Class_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandomF(0+(%this.Module_ID_Parent.Vector_2D_Goal_Size.X*0.5),%this.Module_ID_Parent.Vector_2D_World_Limits.X-(%this.Module_ID_Parent.Vector_2D_Goal_Size.X*0.5));

%Vector_2D_Randomized_Offset.Y=getRandomF(0+(%this.Module_ID_Parent.Vector_2D_Goal_Size.Y*0.5),%this.Module_ID_Parent.Vector_2D_World_Limits.Y-(%this.Module_ID_Parent.Vector_2D_Goal_Size.Y*0.5));

%this.Position=%Vector_2D_Randomized_Offset;

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Gui_Text_Score.setText("Score:" SPC %this.Module_ID_Parent.Int_Score);

}
