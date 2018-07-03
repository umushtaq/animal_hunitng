using UnityEngine;
using System.Collections;

public class nullParent : MonoBehaviour 
{
	void Awake () 
	{
		this.transform.parent = null;	
	}
}