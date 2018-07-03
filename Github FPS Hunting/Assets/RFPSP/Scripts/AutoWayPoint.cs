//AutoWaypoint.cs by Azuline Studios© All Rights Reserved
//Creates waypoint groups based on line of sight, draws editor waypoint lines,
//and finds the waypoint closest to a position.
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AutoWayPoint : MonoBehaviour {
	[HideInInspector]
	public List<AutoWayPoint> connected = new List<AutoWayPoint>();
	static public AutoWayPoint[] waypointsObj;//list containing all waypoints in the scene
	static float kLineOfSightCapsuleRadius = 0.25f;
	public int waypointGroup = 0;//waypoint group number of this waypoint
	public int waypointNumber = 0;//number of this waypoint in path sequence
	//LayerMask for only letting world collision objects block waypoint line of sight 
	private LayerMask capsuleMask = 10;
	
	public AutoWayPoint FindClosest ( Vector3 pos , int waypointsToFollow  ){
		// The closer two vectors, the larger the dot product will be.
		AutoWayPoint closest = null;
		float closestDistance = 75.0f;
		for (int i = connected.Count - 1; i > -1; i--){
			float distance = Vector3.Distance(connected[i].transform.position, pos);
			if (distance < closestDistance){
				//track this waypoint only if it is in our waypoint group 
				if(waypointsToFollow == connected[i].GetComponent<AutoWayPoint>().waypointGroup){
					closestDistance = distance;
					closest = connected[i];
				}
			}
		}
		return closest;
	}
	
	[ContextMenu ("Update Waypoints")]
	void UpdateWaypoints (){
		RebuildWaypointList();
	}
	
	void Awake (){
		RebuildWaypointList();
	}

	//draw the waypoint lines only when one of the waypoints is selected
	void OnDrawGizmosSelected (){
		
		RebuildWaypointList();
		
		for (int i = connected.Count - 1; i > -1; i--){
			if (Physics.Linecast(transform.position, connected[i].transform.position)) {
				Gizmos.color = Color.red;
				Gizmos.DrawLine (transform.position, connected[i].transform.position);
			} else {
				Gizmos.color = Color.green;
				Gizmos.DrawLine (transform.position, connected[i].transform.position);
			}
		}
	}
	
	void RebuildWaypointList (){
		waypointsObj = FindObjectsOfType(typeof(AutoWayPoint)) as AutoWayPoint[];
		
		for (int i = waypointsObj.Length - 1; i > -1; i--){
			waypointsObj[i].RecalculateConnectedWaypoints();
		}
	}
	
	void RecalculateConnectedWaypoints (){
		connected.Clear();
		for (int i = waypointsObj.Length - 1; i > -1; i--){
			// Do we have a clear line of sight?
			if (!Physics.CheckCapsule(transform.position, waypointsObj[i].transform.position, kLineOfSightCapsuleRadius, capsuleMask)) {
				//only add this waypoint to the connected waypoint array if it is in our waypoint group
				if(waypointsObj[i].GetComponent<AutoWayPoint>().waypointGroup == waypointGroup){
					connected.Add(waypointsObj[i]);
				}
			}
		}
	}
}