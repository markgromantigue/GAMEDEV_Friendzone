using UnityEngine;
using System.Collections;

public class scroller : MonoBehaviour {

	public float speed;
	private Vector2 newPos;

	// Use this for initialization
	void Start () {
		newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		newPos.x = newPos.x - speed;
		transform.position = newPos;
		if (newPos.x < -21.71f) {
			newPos.x = 21.73f;
			transform.position = newPos;
		}
	}
}
