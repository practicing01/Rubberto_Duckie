function Module_Gameplay::World_Limits_Initialize(%this)
{

/*****************************************************************/

//Top wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y+%this.Vector_2D_Rubberto_Duckie_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Rubberto_Duckie_Size.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/

//Bottom wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC 0-%this.Vector_2D_Rubberto_Duckie_Size.Y*0.5;
Size=%this.Vector_2D_World_Limits.X SPC %this.Vector_2D_Rubberto_Duckie_Size.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/

//Left wall.

%Sprite_Wall=new Sprite()
{

Position=0-%this.Vector_2D_Rubberto_Duckie_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Rubberto_Duckie_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/

//Right wall.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X+%this.Vector_2D_Rubberto_Duckie_Size.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_Rubberto_Duckie_Size.X SPC %this.Vector_2D_World_Limits.Y;
class="Class_Wall";
SceneLayer=30;

SceneGroup=30;//Walls.

BodyType="static";

Image="Module_Gameplay:Image_Wall";

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Wall.setCollisionGroups(0);

%Sprite_Wall.Collision_Shape_Index=%Sprite_Wall.createPolygonBoxCollisionShape(%Sprite_Wall.Size);

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/

//Water color.

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_World_Limits;
BlendColor="1.0 1.0 1.0 0.75";

SceneGroup=2;

SceneLayer=30;

BodyType="static";

Image="Module_Gameplay:Image_Water_Color";

Module_ID_Parent=%this;

};

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/

//Caustics

%Sprite_Wall=new Sprite()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size=%this.Vector_2D_World_Limits;
Animation="Module_Gameplay:Animation_Caustics";
BlendColor="1.0 1.0 1.0 0.25";

SceneGroup=2;

SceneLayer=29;

BodyType="static";

Module_ID_Parent=%this;

};

Scene_Rubberto_Duckie.add(%Sprite_Wall);

/*****************************************************************/
Window_Rubberto_Duckie.setCameraPosition(%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5);

}
