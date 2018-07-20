using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    private Transform trans;
    public Door wallRef;

	// Use this for initialization
	void Start ()
    {
        trans = GetComponent<Transform>();
    }
	
	// Update is called once per frame
    /*Spins the coin on the y-axis*/
	void Update () {
        Vector3 axis;
        axis = new Vector3 (0.0f,1.0f,0.0f);
#pragma warning disable CS0618 // Type or member is obsolete
        trans.transform.RotateAroundLocal(axis: axis, angle: 0.1f);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    private void OnTriggerEnter(Collider other)
    {
        /*Destory if it overlaps the player*/
        if( other.CompareTag("Player"))
        {
            //wallRef.decreseCount();
           // wallRef.removeCoin(this);   
            //DestroyObject(this.gameObject);
            Destroy(this);

        }
    }
}