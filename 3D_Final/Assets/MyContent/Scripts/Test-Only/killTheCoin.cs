using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killTheCoin : MonoBehaviour {

    public Door theDoor;
    private Coin coin;
    private float timeTracker;
    private bool killed;
    

	// Use this for initialization
	void Start ()
    {
        coin = theDoor.getCoin();
        killed = false;
	}
	
	// Update is called once per frame
	void Update () {
        timeTracker += Time.deltaTime;
        if(timeTracker >= 3.0f && !killed)
        {
            Debug.Log("KILL THE COIN!");
            theDoor.removeCoin(coin);
            killed = true;
        }
	}
}
