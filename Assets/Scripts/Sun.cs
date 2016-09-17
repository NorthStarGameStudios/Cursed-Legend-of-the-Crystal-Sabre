using UnityEngine;
using System.Collections;

public class Sun : MonoBehaviour {
	float Speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Rotate (1f * Time.fixedDeltaTime, 0, 0);
	}
}
