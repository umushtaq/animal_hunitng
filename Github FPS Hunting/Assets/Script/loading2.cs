using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class loading2 : MonoBehaviour {
	public Slider loading;

	// Use this for initialization
	void Start () {

		Time.timeScale = 1;
		loading.value = loading.minValue;

	}
	
	// Update is called once per frame
	void Update () {
		loading.value +=(Time.timeScale * 0.01f);
		if (loading.value >= .99) {
			SceneManager.LoadScene ("MilitaryScene");
			Debug.Log ("Loading");
		//	Application.LoadLevel (1);
	}
}
}