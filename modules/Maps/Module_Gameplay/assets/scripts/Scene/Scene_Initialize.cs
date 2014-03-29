function Module_Gameplay::Scene_Initialize(%this)
{

exec("./Initialize/Initialize.cs");

%this.LiquidFun_Initialize();

%this.Rubberto_Duckie_Initialize();

%this.World_Limits_Initialize();

%this.Movement_Initialize();

%this.Goal_Initialize();

%this.Score_Initialize();

%this.Kinematic_Paddles_Initialize();

}
