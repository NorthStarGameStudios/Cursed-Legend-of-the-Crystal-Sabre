using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {
	Light lights;
	int Randy;
	// Use this for initialization
	void Start () {
		lights = this.gameObject.GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Randy = Random.Range (50, 150);
		if (lights.range < Randy) {
			while (lights.range < Randy) {
				++lights.range;
			}
		} else if (lights.range > Randy) {
			while (lights.range > Randy) {
				--lights.range;
			}
		} else {
			lights.range = lights.range;
		}
	}
}
