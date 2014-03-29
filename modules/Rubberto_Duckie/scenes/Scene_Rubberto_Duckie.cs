function Window_Create_Rubberto_Duckie()
{

if (!isObject(Window_Rubberto_Duckie))
{

new SceneWindow(Window_Rubberto_Duckie);   

Window_Rubberto_Duckie.Profile=Gui_Profile_Window_Rubberto_Duckie;

Canvas.setContent(Window_Rubberto_Duckie);                     

}

Window_Rubberto_Duckie.stopCameraMove();
Window_Rubberto_Duckie.dismount();
Window_Rubberto_Duckie.setViewLimitOff();
Window_Rubberto_Duckie.setRenderGroups(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setRenderLayers(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setObjectInputEventGroupFilter(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setObjectInputEventLayerFilter(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setLockMouse(true);
Window_Rubberto_Duckie.setCameraPosition(0,0);
Window_Rubberto_Duckie.setCameraZoom(1);
Window_Rubberto_Duckie.setCameraAngle(0);

Rubberto_Duckie.Resolution=getRes();
%Y_Times_100=100*Rubberto_Duckie.Resolution.Y;
%Cam_Y=%Y_Times_100/Rubberto_Duckie.Resolution.X;

Window_Rubberto_Duckie.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Rubberto_Duckie_Overlay))
{

new GuiControl(Gui_Rubberto_Duckie_Overlay)
{

Position="0 0";
Extent=Rubberto_Duckie.Resolution;
Profile=gui_profile_modalless;

};   

Window_Rubberto_Duckie.addGuiControl(Gui_Rubberto_Duckie_Overlay);

Gui_Rubberto_Duckie_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Rubberto_Duckie()
{
    
if (isObject(Window_Rubberto_Duckie))
{

Window_Rubberto_Duckie.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Rubberto_Duckie()
{

if (isObject(Scene_Rubberto_Duckie))
{

Scene_Rubberto_Duckie.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Rubberto_Duckie))
{

error("Cannot set Rubberto_Duckie Scene to Window as the Scene is invalid.");
return;

}
    
Window_Rubberto_Duckie.setScene(Scene_Rubberto_Duckie);

Window_Rubberto_Duckie.stopCameraMove();
Window_Rubberto_Duckie.dismount();
Window_Rubberto_Duckie.setViewLimitOff();
Window_Rubberto_Duckie.setRenderGroups(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setRenderLayers(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setObjectInputEventGroupFilter(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setObjectInputEventLayerFilter(Rubberto_Duckie.All_Bits);
Window_Rubberto_Duckie.setLockMouse(true);
Window_Rubberto_Duckie.setCameraPosition(0,0);
Window_Rubberto_Duckie.setCameraZoom(1);
Window_Rubberto_Duckie.setCameraAngle(0);

Rubberto_Duckie.Resolution=getRes();
%Y_Times_100=100*Rubberto_Duckie.Resolution.Y;
%Cam_Y=%Y_Times_100/Rubberto_Duckie.Resolution.X;

Window_Rubberto_Duckie.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Rubberto_Duckie()
{

Scene_Destroy_Rubberto_Duckie();

new Scene(Scene_Rubberto_Duckie);

if (!isObject(Window_Rubberto_Duckie))
{

error("Rubberto_Duckie: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Rubberto_Duckie to use an invalid Scene.");
return;

}
   
Scene_Destroy_Rubberto_Duckie();

%Scene.setName("Scene_Rubberto_Duckie");

//%Scene.class="Class_Scene_Rubberto_Duckie";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Rubberto_Duckie::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
