using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Animator anim;
    public Rigidbody rb;

    private float inputH;
    private float inputV;
    private bool run;
    //private bool jump;

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        run = false;
        //jump = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }

        if(Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("jump", true);
        }
        else
            anim.SetBool("jump", false);
        { }


        inputH = Input.GetAxis("Horizontal");
        inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);
        anim.SetBool("run",run);

        float moveX = inputH * 20.0f * Time.deltaTime;
        float moveZ = inputV * 50.0f * Time.deltaTime;

        if (moveZ <=0.0f)
        {
            moveX = 0.0f;
        }
        else if(run)
        {
            moveX *= 3.0f;
            moveZ *= 3.0f;
        }

        rb.velocity = new Vector3(moveX, 0.0f, moveZ);
    }
}
