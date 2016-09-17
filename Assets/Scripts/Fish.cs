using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	float Randy;
	public Rigidbody RB;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Randy = Random.Range (0, 50);
		if (Physics.Raycast (transform.position, new Vector3 (-1, -0.1f, 0), 5)) {
			transform.Rotate (0, 180, 0);
			transform.Translate (-50 * Time.deltaTime, 0, 0);
		} else {
			transform.Translate (-10 * Time.deltaTime, 0, 0);
		}
		if (Randy > 1 && Randy < 2) {
			RB.AddRelativeForce (0, 5, 0);
		}
		if (Randy > 4 && Randy < 3) {
			RB.AddRelativeForce (0, -5, 0);
		}
		if (Randy > 40 && Randy < 42.5f) {
			RB.AddRelativeTorque (0, 5, 0);
		}
		if (Randy >  42.5f && Randy < 45) {
			RB.AddRelativeTorque (0, -5, 0);
		}
		if (Randy > 45 && Randy < 47.5f) {
			RB.AddRelativeTorque (0, 15, 0);
		}
		if (Randy > 47.5f && Randy < 50) {
			RB.AddRelativeTorque (0, -15, 0);
		}
	}
}
