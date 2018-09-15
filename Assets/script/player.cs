using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float speed;
    Vector3 position;

    GameObject bullet;

    Rigidbody2D rigid;

    Animator animator;


	// Use this for initialization
	void Start () {
        position = transform.position;
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        MoveUpdate();
	}

    void MoveUpdate()
    {
        animator.SetInteger("motion", 0);
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("motion", 1);
            transform.Translate(new Vector3(-1 * speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("motion", 1);
            transform.Translate(new Vector3(1 * speed * Time.deltaTime, 0, 0));
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if(Input.GetKey(KeyCode.Z))
        {
            animator.SetInteger("motion", 2);
        }
    }

    void Jump()
    {

    }

    void Shoot()
    {

    }
}
