using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

	public GameObject spawner = null;
	public GameObject spawner2 = null;
	public GameObject spawner3 = null;
	public int fairness;

	// Use this for initialization
	void Start () {
		fairness = 0;
	}

	// Update is called once per frame
	void Update () {
		float rand = Random.value;
		if (fairness == 100) {
			fairness = 0;
		} else if (fairness > 0) {
			fairness = fairness + 1;
		}
		if (rand >= 0.995 && fairness == 0) {
			GameObject spawning = Instantiate (spawner, new Vector2 (23f, 2f), Quaternion.identity) as GameObject;
			fairness = 1;
		} else if (rand >= 0.99 && fairness == 0) {
			GameObject spawning = Instantiate (spawner, new Vector2 (23f, -5f), Quaternion.identity) as GameObject;
			fairness = 1;
		} else if (rand >= 0.989 && rand < 0.99) {
			GameObject spawning = Instantiate (spawner2, new Vector2 (23f, (float)(11*Random.value - 4)), Quaternion.identity) as GameObject;
		} else if (rand >= 0.988 && rand < 0.989) {
			GameObject spawning = Instantiate (spawner3, new Vector2 (23f, (float)(11*Random.value - 4)), Quaternion.identity) as GameObject;
		}
	}
}
