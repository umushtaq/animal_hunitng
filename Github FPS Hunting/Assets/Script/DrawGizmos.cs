using UnityEngine;

public class DrawGizmos : MonoBehaviour 
{
	public Color color = Color.green;
	public float size = 1;

	void OnDrawGizmos() 
	{
		Gizmos.color = color;
		Gizmos.DrawSphere(transform.position, size);
	}
}
