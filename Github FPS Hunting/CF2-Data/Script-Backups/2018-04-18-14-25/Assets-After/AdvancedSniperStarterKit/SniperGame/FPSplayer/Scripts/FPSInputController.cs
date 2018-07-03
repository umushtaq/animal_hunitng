using UnityEngine;
using System.Collections;

[RequireComponent(typeof(FPSController))]


public class FPSInputController : MonoBehaviour
{
	private GunHanddle gunHanddle;
	private FPSController FPSmotor;


	
	void Start(){
		Application.targetFrameRate = 60;
		MouseLock.MouseLocked = true;

	}
	void Awake ()
	{
		FPSmotor = GetComponent<FPSController> ();		
		gunHanddle = GetComponent<GunHanddle> (); 
	}

	void Update ()
	{

		FPSmotor.Aim(new Vector2(ControlFreak2.CF2Input.GetAxis("Mouse X"),ControlFreak2.CF2Input.GetAxis("Mouse Y")));
		FPSmotor.Move (new Vector3 (ControlFreak2.CF2Input.GetAxis ("Horizontal"), 0, ControlFreak2.CF2Input.GetAxis ("Vertical")));
		FPSmotor.Jump (ControlFreak2.CF2Input.GetButton ("Jump"));
		
		if(ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift)){
			FPSmotor.Boost(1.7f);	
		}
		
		FPSmotor.Holdbreath(1);	
		
		if(ControlFreak2.CF2Input.GetKey(KeyCode.LeftShift)){
			FPSmotor.Holdbreath(0);	
		}
		if(ControlFreak2.CF2Input.GetButton("Fire1")){
			gunHanddle.Shoot();	
		}
		if(ControlFreak2.CF2Input.GetButtonDown("Fire2")){
			gunHanddle.Zoom();	
		}
		if (ControlFreak2.CF2Input.GetAxis("Mouse ScrollWheel") < 0){
			gunHanddle.ZoomAdjust(-1);	
		}
		if (ControlFreak2.CF2Input.GetAxis("Mouse ScrollWheel") > 0){
			gunHanddle.ZoomAdjust(1);	
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.R)){
			gunHanddle.Reload();
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.Q)){
			gunHanddle.SwitchGun();
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.Z)){
			gunHanddle.OffsetAdjust(new Vector2(0,-1));
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.X)){
			gunHanddle.OffsetAdjust(new Vector2(0,1));
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.C)){
			gunHanddle.OffsetAdjust(new Vector2(-1,0));
		}
		if(ControlFreak2.CF2Input.GetKeyDown(KeyCode.V)){
			gunHanddle.OffsetAdjust(new Vector2(1,0));
		}

	}

}
