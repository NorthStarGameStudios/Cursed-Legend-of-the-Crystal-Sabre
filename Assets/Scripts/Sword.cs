using UnityEngine;
using System.Collections;

public class Sword : MonoBehaviour {
	public bool GFY;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.X)) {
			if (Input.GetKeyDown (KeyCode.X) && GFY) {
				transform.Rotate (-transform.rotation.x + 90, 0, 0);
			}

		} else {
			transform.Rotate (-transform.rotation.x * 100, 0, 0);
		}
	}
}
