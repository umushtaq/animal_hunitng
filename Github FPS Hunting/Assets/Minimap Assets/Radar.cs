using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Radar : MonoBehaviour 
{
	public GameObject[] trackedobjects;
	IList<GameObject> radarobjects;
	public GameObject radarprefab;
	IList<GameObject> borderobjects;
	public float switchDistance;
	public Transform helptransform;

	public GameObject[] radarprefabname ;

	public bool startradar = false;

	void Awake()
	{
		startradar = false;
		StartCoroutine (waitforradar ());
		Invoke("callFunction" ,0);
	}

//	void Start()
//	{
//		startradar = false;
//		Invoke("callFunction" ,0);
//	}

	public void callFunction()
	{
		trackedobjects = GameObject.FindGameObjectsWithTag("Flesh");	
		createRadarObjects ();
	}


	public void DestroypreviousRadarPrefabs()
	{
		radarprefabname = GameObject.FindGameObjectsWithTag ("radarprefab");
		foreach(GameObject go in radarprefabname)
		{
			Destroy(go);
		}
	}
	IEnumerator waitforradar()
	{
		yield return new WaitForSeconds (2.0f);
		startradar = true;
	}

	void Update()
	{
		if(PlayerPrefs.GetInt("minimap") == 1 )
		{
			if(startradar)
			{

//				Debug.Log ("rada count    " + radarobjects.Count);

				for(int i = 0; i < radarobjects.Count ; i ++)
				{
					if(radarobjects[i] != null && borderobjects[i] != null)
					{
						if(Vector3.Distance(radarobjects[i].transform.position , transform.position) > switchDistance)
						{
							//switch to borderobjects
							helptransform.LookAt(radarobjects[i].transform);
							borderobjects[i].transform.position = transform.position + switchDistance*helptransform.forward;
							borderobjects[i].layer = LayerMask.NameToLayer("Radar"); 
							radarobjects[i].layer = LayerMask.NameToLayer("Invisible");
						}
						else
						{
							//switch to radarobjects
							borderobjects[i].layer = LayerMask.NameToLayer("Invisible");
							radarobjects[i].layer = LayerMask.NameToLayer("Radar");
						}
					}
				}
			}
		}
	}
	void createRadarObjects ()
	{
		radarobjects = new List<GameObject>();
		borderobjects = new List<GameObject>();

		foreach(GameObject o in trackedobjects)
		{
			GameObject k = Instantiate(radarprefab , o.transform.position , Quaternion.identity) as GameObject;
			k.transform.name = "radarprefab";
			k.transform.parent = o.transform;
			radarobjects.Add(k);

			GameObject j = Instantiate(radarprefab , o.transform.position , Quaternion.identity) as GameObject;
			j.transform.parent = o.transform;
			borderobjects.Add(j);
		}


	}

}
