using UnityEngine;
using System.Collections;

public class blackhole : MonoBehaviour {

    public float speed = 10f;

	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}
}
