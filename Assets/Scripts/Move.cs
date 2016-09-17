using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	Rigidbody RB;
	public bool OnGround;
	public bool RDP;
	public int Speed;
	GameObject TO;
	GameObject[] objectsWithTag;
	GameObject closestObject;
	// Use this for initialization
	void Start () {
		RDP = true;
		Speed = 10;
		RB = this.gameObject.GetComponent<Rigidbody> ();
		objectsWithTag = GameObject.FindGameObjectsWithTag("Look");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (GameObject obj in objectsWithTag) {
			if (!closestObject) {
				closestObject = obj;
			}
			//compares distances
			if(Vector3.Distance(transform.position, obj.transform.position) <= Vector3.Distance(transform.position, closestObject.transform.position)) {
				closestObject = obj;
			}
		}
		TO = closestObject;
		if (Input.GetAxis ("Fire2") > 0.01f) {
			Vector3 point = TO.transform.position;
			transform.LookAt (point);
		} else {
			transform.Rotate (0, Input.GetAxis ("Horizontal1") * 2.5f, 0);
		}
		if (OnGround) {
			if (Input.GetAxis ("Fire1") > 0.1f) {
				Speed = 50;
			} else {
				Speed = 10;
			}
			if (Mathf.Abs (RB.velocity.z) < Speed && Mathf.Abs (RB.velocity.x) < Speed) {
				RB.AddRelativeForce (Input.GetAxis ("Horizontal") * 2500, 0, Input.GetAxis ("Vertical") * 2500);
			}
			if (Input.GetAxis ("Horizontal") == 0 && Input.GetAxis ("Vertical") == 0) {
				RB.AddForce (-RB.velocity.x * 50, 0, -RB.velocity.z * 50);
			}
		}
		if (Physics.Raycast (transform.position, Vector3.down, 8)) {
			OnGround = true;
		} else {
			OnGround = false;
			RB.AddForce (0, -5000, 0);
		}
		if (Input.GetKey (KeyCode.JoystickButton2)) {
			RaycastHit Hit;
			if (Physics.Raycast (transform.position, transform.forward, out Hit, 9)) {
				if (Hit.distance < 5) {
					Destroy(GameObject.Find("Evil"));
				}
			}
		}
	}
}