using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Respawn : MonoBehaviour {

	public GameObject[] enemies;
	public Vector3 SpawnValues;
	public float SpawnWait;
	public float MostWait;
	public float LeastWait;
	public int StartWait;
	public bool Stop;

	int randEnemy;


	// Use this for initialization
	void Start () {
		StartCoroutine (WaitSpawner());
	}
	
	// Update is called once per frame
	void Update () {
		SpawnWait = Random.Range (LeastWait,MostWait);
	}

	IEnumerator WaitSpawner(){

		yield return new WaitForSeconds (StartWait);

		while (!Stop) {
			randEnemy = Random.Range (0,2);

			Vector3 spawnPosition = new Vector3 (Random.Range (-SpawnValues.x, SpawnValues.x), 1, Random.Range (-SpawnValues.z, SpawnValues.z));

			Instantiate (enemies [randEnemy],spawnPosition + transform.TransformPoint(0,0,0),gameObject.transform.rotation);

			yield return new WaitForSeconds (SpawnWait);
		}
	}



}
