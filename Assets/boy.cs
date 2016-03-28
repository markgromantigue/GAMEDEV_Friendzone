using UnityEngine;
using System.Collections;

public class boy : MonoBehaviour {

	public int timer;
	public float jumpForce;
	public bool duck;
	private Vector2 duc;
	private Rigidbody2D rb2d;
    private Animator animator;
    private Vector2 charPos;

	// Use this for initialization
	void Start () {
		duck = false;
		timer = 0;
		duc = transform.localScale;
		rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
        charPos = transform.position;
		if (timer == 100) {
			duck = false;
            animator.SetBool("GBSliding", false);
			timer = 0;
		} else if (timer != 0 && timer < 100) {
			timer++;
		}
        
        if (charPos.y <= -1.5f) {
			animator.SetBool("GBJumping", false);
		}else{
            animator.SetBool("GBJumping", true);
        }

		if (Input.GetKeyDown("up")) {
            animator.SetBool("GBJumping", true);
			rb2d.AddForce(new Vector2(0f, jumpForce));
		}

		if (Input.GetKeyDown("down") && !duck) {
			duck = true;
            animator.SetBool("GBSliding", true);
			timer++;
		}
	
	}
}