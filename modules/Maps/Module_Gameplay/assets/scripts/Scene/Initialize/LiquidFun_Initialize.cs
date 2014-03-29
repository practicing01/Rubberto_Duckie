function Module_Gameplay::LiquidFun_Initialize(%this)
{

%LiquidFun_Object=new LiquidFunObject()
{

Position=%this.Vector_2D_World_Limits.X*0.5 SPC %this.Vector_2D_World_Limits.Y*0.5;
Size="1 1";
Image="Module_Gameplay:Image_Rubberto_Duckie";
class="Class_LiquidFun";
BodyType="static";

Module_ID_Parent=%this;

ParticleRadius=1;

ShapeType="Polygon";

PolygonSize=38.90;

Solid=false;

LiquidType="WaterParticle";

};

Scene_Rubberto_Duckie.add(%LiquidFun_Object);

}
