using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDWypoint : MonoBehaviour {

	public GameObject hud;
	public GameObject HudMarker;
	public GameObject target;
	private Camera cam;

	private GameObject wp;

	// Use this for initialization
	void Start () {
		cam=GetComponentInChildren<Camera> ();
		wp = Instantiate (HudMarker);
		wp.GetComponent<RectTransform> ().SetParent (hud.transform);
	}
	
	// Update is called once per frame
	void Update () {
		float check= Vector3.Dot ((target.transform.position - cam.transform.position).normalized, cam.transform.forward);

		if (check <= 0f) {
			wp.GetComponent<RawImage> ().enabled = false;
		} else {
			wp.GetComponent<RawImage> ().enabled = true;
			wp.GetComponent<RectTransform>().position = cam.WorldToScreenPoint (target.transform.position);
		}

	}
}
