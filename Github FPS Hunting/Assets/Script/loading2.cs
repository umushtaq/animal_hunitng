using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class loading2 : MonoBehaviour {
	public Slider loading;

	void Start () {
		Time.timeScale = 1;
		loading.value = loading.minValue;
	}

	void Update () {
		loading.value +=(Time.timeScale * 0.01f);
		if (loading.value >= .99) {
			SceneManager.LoadScene ("GamePlay");
	}
}
}