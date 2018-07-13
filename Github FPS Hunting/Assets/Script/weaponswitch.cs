using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour {

	public int selectedweapon=0;
	public bool tru = false;

	void Start () {
		SelectWeapon ();
	}
	void Update () { 
		int prevselectedweapon = selectedweapon; 
		if (tru) {
			if (selectedweapon >= transform.childCount - 12)
				selectedweapon = 0;
			else
				selectedweapon++;

			tru = false;
		}
		if (prevselectedweapon != selectedweapon) {
			SelectWeapon ();
		}
	}
	public void SwitchWeapon ()
	{
		tru = true;
	}
	void SelectWeapon (){
		int i = 0;
		foreach(Transform weapon in transform){
			if (i == selectedweapon) 
				weapon.gameObject.SetActive (true);
				else
					weapon.gameObject.SetActive (false);
			i++;
		}
	}
}
