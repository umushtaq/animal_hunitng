using UnityEngine;
using System.Collections;

public class PAthFollow  : MonoBehaviour
	{
	public float height = 0.5f; 
	public Transform[] wayPointList;
	public	float distanceToTruck = 10;
	public int currentWayPoint = 0; 
	public float speed = 4f;
	public float Rotate_Speed = 4f;
	float t;
	Transform targetWayPoint;
	int lastPt;
	RaycastHit hit;
	bool moveback;
	public bool nowMove = true;
	public bool walkMan ; 
	float waitTime;
	float tempSpeed;
	public bool pauseTyre;
	bool incresse;
	int HornCounter; 

	void Start()
	{ 

		if (walkMan) 
		{
			gameObject.GetComponent<Animator> ().SetBool ("Walk", true); 
		}
		incresse = false;
		tempSpeed = speed;
	}
	
	IEnumerator make()
	{
	
		if (walkMan)
			t = 3f;
		else
			t = .5f;
		yield return new WaitForSeconds (t);

		if(walkMan)
			gameObject.GetComponent<Animator> ().SetBool ("Walk", true); 
		nowMove = true;
		pauseTyre = false;
		if(HornCounter>3)
		HornCounter = 0;


	}


	IEnumerator makeSlowSpeed()
	{
		yield return new WaitForSeconds (4.2f);
		speed = tempSpeed;
		incresse = false;

	}

	void Update () 
	{
		if (distanceToTruck <0) {
			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), transform.forward, out hit, distanceToTruck)) {
				if (hit.collider.tag == "Play" || hit.collider.tag == "traffic") {
					if (nowMove) {
						HornCounter++;
						if (HornCounter > 2)
							gameObject.GetComponent<AudioSource> ().Play ();
						gameObject.GetComponent<Animator> ().SetBool ("walk", false); 
//						pauseTyre = true;
					nowMove = false;
						StartCoroutine (make ());
					} 
				} 
			}	
			
			
//			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), -transform.forward, out hit, distanceToTruck +1)) {
//				if (hit.collider.tag == "Player" || hit.collider.tag == "traffic" )
//				{
//					if (!incresse) 
//					{
//						speed = speed * 2;
//						
//						StartCoroutine (makeSlowSpeed ());
//						incresse = true;
//					}
//				} 
//			}	
			
			
			//			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), transform.right, out hit, distanceToTruck - 13)) {
			//				if (hit.collider.tag == "Player" || hit.collider.tag == "traffic" || hit.collider.tag == "passenger"|| hit.collider.tag == "civilian") {
			//					if (nowMove) {
			//						HornCounter++;
			//						if (HornCounter > 1)
			//							gameObject.GetComponent<AudioSource> ().Play ();
			//						pauseTyre = true;
			//						StartCoroutine (make ());
			//						nowMove = false;
			//					} 
			//				} 
			//			}
			//
			//			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), -transform.right, out hit, distanceToTruck - 13)) {
			//				if (hit.collider.tag == "Player" || hit.collider.tag == "traffic" || hit.collider.tag == "passenger"|| hit.collider.tag == "civilian") {
			//					if (nowMove) {
			//						HornCounter++;
			//						if (HornCounter > 1)
			//							gameObject.GetComponent<AudioSource> ().Play ();
			//						pauseTyre = true;
			//						nowMove = false;
			//						StartCoroutine (make ());
			//					} 
			//				} 
			//			}
			
			
			
			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), transform.forward * distanceToTruck, Color.red);
//			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), -transform.forward * (distanceToTruck+1), Color.red);
			//			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), -transform.right * 5, Color.green);
			//			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), transform.right * 5, Color.blue);
		
			if (nowMove)
			{
			if (currentWayPoint < this.wayPointList.Length)
			{
				if (targetWayPoint == null)
				{	
					targetWayPoint = wayPointList [currentWayPoint];
				}

					walk ();
				
				}
				
			} 
		}

		if (distanceToTruck > 5) 
		{
			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), transform.forward, out hit, distanceToTruck)) {
				if (hit.collider.tag == "Play" || hit.collider.tag == "traffic" || hit.collider.tag == "passenger"|| hit.collider.tag == "civilian") {
					if (nowMove) {
						HornCounter++;
						if (HornCounter > 1)
			//gameObject.GetComponent<AudioSource> ().Play ();
						pauseTyre = true;
						nowMove = false;
						StartCoroutine (make ());
					} 
				} 
			}	


			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), -transform.forward, out hit, distanceToTruck +1)) {
				if (hit.collider.tag == "Play" || hit.collider.tag == "traffic" )
				{
					if (!incresse) 
					{
						speed = speed * 2;
			 
						StartCoroutine (makeSlowSpeed ());
						incresse = true;
					}
				} 
			}	


//			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), transform.right, out hit, distanceToTruck - 13)) {
//				if (hit.collider.tag == "Player" || hit.collider.tag == "traffic" || hit.collider.tag == "passenger"|| hit.collider.tag == "civilian") {
//					if (nowMove) {
//						HornCounter++;
//						if (HornCounter > 1)
//							gameObject.GetComponent<AudioSource> ().Play ();
//						pauseTyre = true;
//						StartCoroutine (make ());
//						nowMove = false;
//					} 
//				} 
//			}
//
//			if (Physics.Raycast (transform.position + new Vector3 (0, height, 0), -transform.right, out hit, distanceToTruck - 13)) {
//				if (hit.collider.tag == "Player" || hit.collider.tag == "traffic" || hit.collider.tag == "passenger"|| hit.collider.tag == "civilian") {
//					if (nowMove) {
//						HornCounter++;
//						if (HornCounter > 1)
//							gameObject.GetComponent<AudioSource> ().Play ();
//						pauseTyre = true;
//						nowMove = false;
//						StartCoroutine (make ());
//					} 
//				} 
//			}


			
			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), transform.forward * distanceToTruck, Color.red);
			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), -transform.forward * (distanceToTruck+1), Color.red);
//			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), -transform.right * 5, Color.green);
//			Debug.DrawRay (transform.position + new Vector3 (0, height, 0), transform.right * 5, Color.blue);
			if (currentWayPoint < this.wayPointList.Length)
			{
				if (targetWayPoint == null)
				{	
					targetWayPoint = wayPointList [currentWayPoint];
				}
				if (nowMove)
					walk ();
				
				
				
			} 
		}
	
	}

	
	void walk()
	{

		transform.forward = Vector3.RotateTowards(transform.forward, new Vector3(targetWayPoint.position.x,transform.position.y,targetWayPoint.position.z)- transform.position , Rotate_Speed*Time.deltaTime, 0.0f);
		
	
		targetWayPoint.position  =new Vector3(targetWayPoint.position.x, transform.position.y,targetWayPoint.position.z);
		transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position,   speed*Time.deltaTime);
//		if (distanceToTruck < 3) 
		if(nowMove)
		transform.LookAt ( targetWayPoint.position);
//		transform.position = Vector3.MoveTowards(transform.position,
//		                                         new Vector3( targetWayPoint.position.x,transform.position.y, targetWayPoint.position.z)
//		                                         , speed*Time.deltaTime);


		if(transform.position == targetWayPoint.position)
		{
			currentWayPoint ++ ;
			lastPt = currentWayPoint;
			if(currentWayPoint == wayPointList.Length )
				currentWayPoint = 0;
			targetWayPoint = wayPointList[currentWayPoint];
		}
	} 
}