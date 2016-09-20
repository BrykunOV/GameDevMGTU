using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Transform EndPoint;
	public Transform LeftPoint;
	public float Speed;
	// Use this for initializationввв
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("d")) {
			
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,EndPoint.transform.position, Time.deltaTime * Speed);
		}
		else if(Input.GetKey("a")){
			gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,LeftPoint.transform.position, Time.deltaTime * Speed);
		}
	}
}
