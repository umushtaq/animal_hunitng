using UnityEngine;
using System.Collections;

public class HideMouse : MonoBehaviour 
{
	private bool MouseToggle;

	void Start () 
	{
		MouseToggle = true;
		ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
		ControlFreak2.CFCursor.lockState = CursorLockMode.Confined;
		ControlFreak2.CFCursor.visible = false;
	}

	void Update () 
	{
		if (ControlFreak2.CF2Input.GetKeyDown(KeyCode.Escape))
		{
			MouseToggle = !MouseToggle;
		}

		if(MouseToggle)
		{
			ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
			ControlFreak2.CFCursor.lockState = CursorLockMode.Confined;
			ControlFreak2.CFCursor.visible = false;
		}

		if(!MouseToggle)
		{
			ControlFreak2.CFCursor.lockState = CursorLockMode.None;
			ControlFreak2.CFCursor.visible = true;
		}
	}
}
