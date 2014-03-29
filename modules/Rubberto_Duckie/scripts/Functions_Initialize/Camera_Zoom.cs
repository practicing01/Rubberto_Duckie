function Class_Rubberto_Duckie_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Rubberto_Duckie.setCameraZoom(Window_Rubberto_Duckie.getCameraZoom()+$pref::Rubberto_Duckie::cameraMouseZoomRate);

}

function Class_Rubberto_Duckie_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Rubberto_Duckie.setCameraZoom(Window_Rubberto_Duckie.getCameraZoom()-$pref::Rubberto_Duckie::cameraMouseZoomRate);

}
