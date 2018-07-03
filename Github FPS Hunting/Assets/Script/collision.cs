using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization

	void OnCollisionEnter(Collision col){

		if(col.gameObject.tag == "finish")
		{
			Debug.Log ("Levelcomplete");

		}

		else if(col.gameObject.tag == "enem")
		{
			Debug.Log ("game over");

		}

	}
}
