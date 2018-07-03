using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changepanel : MonoBehaviour {

	public GameObject lft;
	public GameObject rght;
	public GameObject[] scenepanel;
	public int vindex;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		foreach (GameObject go in scenepanel) {
			go.SetActive (false);
		}

		scenepanel [vindex].SetActive (true);

		if (vindex == 0) {
			scenepanel [0].SetActive (true);
		} else
			scenepanel [1].SetActive (true);

	}


	public void SceneClick(string click)
	{

		switch (click) {

		case "rght":
			vindex++;
			if (vindex > 1) {
				vindex = 0;
			}
			break;
		case "lft":
			vindex--;
			if (vindex < 0) {
				vindex = 1;
			}
			break;
		}
	}

}
