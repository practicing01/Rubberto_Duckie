function Module_Gameplay::Goal_Initialize(%this)
{

%Vector_2D_Randomized_Offset="0 0";

%Vector_2D_Randomized_Offset.X=getRandom(0+(%this.Vector_2D_Goal_Size.X*0.5),%this.Vector_2D_World_Limits.X-(%this.Vector_2D_Goal_Size.X*0.5));

%Vector_2D_Randomized_Offset.Y=getRandom(0+(%this.Vector_2D_Goal_Size.Y*0.5),%this.Vector_2D_World_Limits.Y-(%this.Vector_2D_Goal_Size.Y*0.5));

%Sprite_Goal=new Sprite()
{

Position=%Vector_2D_Randomized_Offset;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%this.Ass_Image_Goal);
Image="Module_Gameplay:Image_Goal";
Animation="Module_Gameplay:Animation_Goal";
class="Class_Goal";
BodyType="static";
SceneLayer=17;

BlendColor="1.0 1.0 1.0 1.0";

CollisionCallback="true";

SceneGroup=26;//Dynamic world objects.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

};

%Sprite_Goal.setCollisionGroups(0);

%Sprite_Goal.Collision_Shape_Index=%Sprite_Goal.createPolygonBoxCollisionShape(%Sprite_Goal.Size);

%Sprite_Goal.setCollisionShapeIsSensor(%Sprite_Goal.Collision_Shape_Index,true);

Scene_Rubberto_Duckie.add(%Sprite_Goal);

}
