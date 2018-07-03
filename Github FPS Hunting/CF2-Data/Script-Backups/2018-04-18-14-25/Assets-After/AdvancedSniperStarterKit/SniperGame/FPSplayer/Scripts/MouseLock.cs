using UnityEngine;
using System.Collections;

public static class MouseLock
{
	private static bool mouseLocked;

	
	public static bool MouseLocked {
		get {
			return mouseLocked;
		}
		set {
			mouseLocked = value;
			
			#if UNITY_4_6
				ControlFreak2.CFScreen.lockCursor = mouseLocked;
			#else
				ControlFreak2.CFCursor.visible = !value;
				if (ControlFreak2.CFCursor.visible) {	
					ControlFreak2.CFCursor.lockState = CursorLockMode.None;
				} else {
					ControlFreak2.CFCursor.lockState = CursorLockMode.Locked;
			
				}
			#endif
		}
	}
	

}

