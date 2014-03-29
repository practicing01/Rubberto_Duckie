function Module_Gameplay::Movement_Initialize(%this)
{

%this.Script_Object_Input_Controller=new ScriptObject()
{

class="Class_Module_Gameplay_Input_Controller";

Module_ID_Parent=%this;

Vector_2D_World_Origin=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;

Vector_2D_World_Limits_Half=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;

Float_Swing_Magnitude=Vector2Distance("0 0",%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5);

};

Window_Rubberto_Duckie.addInputListener(%this.Script_Object_Input_Controller);

}

function Class_Module_Gameplay_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

%Float_Angle=Vector2AngleToPoint(%this.Vector_2D_World_Origin,%Vector_2D_World_Position);

%Vector_2D_Projected_Position=Vector2Direction(%Float_Angle+180,%this.Float_Swing_Magnitude);

%Vector_2D_Projected_Position=Vector2Add(%Vector_2D_Projected_Position,%this.Vector_2D_World_Origin);

%this.Module_ID_Parent.SceneObject_Kinematic_Paddle.Position=%Vector_2D_Projected_Position;

%this.Module_ID_Parent.SceneObject_Kinematic_Paddle.Angle=%Float_Angle+90;

%Vector_2D_Projected_Position=Vector2Direction(%Float_Angle,%this.Float_Swing_Magnitude*0.5);

%Vector_2D_Projected_Position=Vector2Add(%Vector_2D_Projected_Position,%this.Module_ID_Parent.SceneObject_Kinematic_Paddle.Position);

%this.Module_ID_Parent.SceneObject_Kinematic_Paddle.moveTo(%Vector_2D_Projected_Position,100,true,true);

}

function Class_Module_Gameplay_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{



}

function Class_Module_Gameplay_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{



}
