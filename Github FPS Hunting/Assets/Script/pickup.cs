using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickup : MonoBehaviour {

	public Text cashText;
	public static GameObject house;
	public static Text scoretxt;
	// Use this for initialization
	void Start () {
			
	//cashText= GetComponent<Text> ();
		cashText= GameObject.FindWithTag("score").GetComponent<Text>();
		cashText.text = PlayerPrefs.GetInt ("Totalcash", 0).ToString();
		house= GameObject.FindGameObjectWithTag ("home");
		house.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		
		if (col.gameObject.tag == "pickup") {
			Debug.Log ("Pickup");
		//	animationonuibutton.Instance.Animat ();
			PlayerPrefs.SetInt ("TotalCash", PlayerPrefs.GetInt ("TotalCash", 0) + 100);
			cashText.text = PlayerPrefs.GetInt ("TotalCash", 0).ToString ();
			house.SetActive (true);

		}

	}

	public void Pick(){
		Destroy(gameObject);
		Debug.Log ("PAssenger");

	}
}