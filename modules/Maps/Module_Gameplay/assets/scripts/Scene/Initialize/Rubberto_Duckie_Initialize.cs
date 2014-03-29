function Module_Gameplay::Rubberto_Duckie_Initialize(%this)
{

/*****************************************************************/

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandom(0+(%this.Vector_2D_Rubberto_Duckie_Size.X),%this.Vector_2D_World_Limits.X-(%this.Vector_2D_Rubberto_Duckie_Size.X));

%Vector_2D_Randomized_Offset.Y=getRandom(0+(%this.Vector_2D_Rubberto_Duckie_Size.Y),%this.Vector_2D_World_Limits.Y-(%this.Vector_2D_Rubberto_Duckie_Size.Y));

%Sprite_Rubberto_Duckie_Player=new Sprite()
{

Position="0 0";
Size=%this.Vector_2D_Rubberto_Duckie_Size;
Image="Module_Gameplay:Image_Rubberto_Duckie";
class="Class_Rubberto_Duckie";
//CollisionCallback="true";
SceneLayer=16;

BlendColor="1.0 1.0 1.0 1.0";

DefaultDensity=0;

DefaultRestitution=1;

SceneGroup=0;

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Bullet=true;

};

%Sprite_Rubberto_Duckie_Player.Position.X+=%Vector_2D_Randomized_Offset.X;

%Sprite_Rubberto_Duckie_Player.Position.Y+=%Vector_2D_Randomized_Offset.Y;

%Sprite_Rubberto_Duckie_Player.setCollisionGroups(26,30);

%Square_Size=%this.Vector_2D_Rubberto_Duckie_Size;

%Radius=0;

if (%Square_Size.X>%Square_Size.Y){%Radius=%Square_Size.X/2;}else{%Radius=%Square_Size.Y/2;}

%Sprite_Rubberto_Duckie_Player.Collision_Shape_Index=%Sprite_Rubberto_Duckie_Player.createCircleCollisionShape(%Radius);

//%Sprite_Rubberto_Duckie_Player.Collision_Shape_Index=%Sprite_Rubberto_Duckie_Player.createPolygonBoxCollisionShape(%Sprite_Rubberto_Duckie_Player.Size);

Scene_Rubberto_Duckie.add(%Sprite_Rubberto_Duckie_Player);

/*****************************************************************/

}
