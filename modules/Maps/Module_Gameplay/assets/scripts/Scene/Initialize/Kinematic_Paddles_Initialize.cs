function Module_Gameplay::Kinematic_Paddles_Initialize(%this)
{

/*****************************************************************/

//Top wall.

%SceneObject_Kinematic_Paddle=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y+%this.Vector_2D_Rubberto_Duckie_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Rubberto_Duckie_Size.Y;
class="Class_Kinematic_Paddle";

SceneGroup=2;

BodyType="kinematic";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Vector_2D_Origin=0;

};

%SceneObject_Kinematic_Paddle.Vector_2D_Origin=%SceneObject_Kinematic_Paddle.Position;

%SceneObject_Kinematic_Paddle.setCollisionGroups(2);

%SceneObject_Kinematic_Paddle.Collision_Shape_Index=%SceneObject_Kinematic_Paddle.createPolygonBoxCollisionShape(%SceneObject_Kinematic_Paddle.Size);

Scene_Rubberto_Duckie.add(%SceneObject_Kinematic_Paddle);

%this.SceneObject_Kinematic_Paddle=%SceneObject_Kinematic_Paddle;

return;

/*****************************************************************/

//Bottom wall.

%SceneObject_Kinematic_Paddle=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC 0-%this.Vector_2D_Rubberto_Duckie_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Rubberto_Duckie_Size.Y;
class="Class_Kinematic_Paddle";

SceneGroup=2;

BodyType="kinematic";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Kinematic_Paddle.Vector_2D_Origin=%SceneObject_Kinematic_Paddle.Position;

%SceneObject_Kinematic_Paddle.setCollisionGroups(0);

%SceneObject_Kinematic_Paddle.Collision_Shape_Index=%SceneObject_Kinematic_Paddle.createPolygonBoxCollisionShape(%SceneObject_Kinematic_Paddle.Size);

Scene_Rubberto_Duckie.add(%SceneObject_Kinematic_Paddle);

/*****************************************************************/

//Left wall.

%SceneObject_Kinematic_Paddle=new SceneObject()
{

Position=0-%this.Vector_2D_Rubberto_Duckie_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Rubberto_Duckie_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Kinematic_Paddle";

SceneGroup=2;

BodyType="kinematic";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Kinematic_Paddle.Vector_2D_Origin=%SceneObject_Kinematic_Paddle.Position;

%SceneObject_Kinematic_Paddle.setCollisionGroups(0);

%SceneObject_Kinematic_Paddle.Collision_Shape_Index=%SceneObject_Kinematic_Paddle.createPolygonBoxCollisionShape(%SceneObject_Kinematic_Paddle.Size);

Scene_Rubberto_Duckie.add(%SceneObject_Kinematic_Paddle);

/*****************************************************************/

//Right wall.

%SceneObject_Kinematic_Paddle=new SceneObject()
{

Position=%this.Vector_2D_World_Limits.X+%this.Vector_2D_Rubberto_Duckie_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Rubberto_Duckie_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Kinematic_Paddle";

SceneGroup=2;

BodyType="kinematic";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%SceneObject_Kinematic_Paddle.Vector_2D_Origin=%SceneObject_Kinematic_Paddle.Position;

%SceneObject_Kinematic_Paddle.setCollisionGroups(0);

%SceneObject_Kinematic_Paddle.Collision_Shape_Index=%SceneObject_Kinematic_Paddle.createPolygonBoxCollisionShape(%SceneObject_Kinematic_Paddle.Size);

Scene_Rubberto_Duckie.add(%SceneObject_Kinematic_Paddle);

/*****************************************************************/

}
