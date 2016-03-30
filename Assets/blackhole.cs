using UnityEngine;
using System.Collections;

public class blackhole : MonoBehaviour {

    public float speed = 10f;
    public float scaleStep = 0;

    private CircleCollider2D myCollider;

    void Start() {
        myCollider = transform.GetComponent<CircleCollider2D>();
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.back, speed * Time.deltaTime);

        scaleStep += 0.001f;
        transform.localScale = new Vector2(scaleStep, scaleStep);

        myCollider.radius += 0.00001f;
	}
}
