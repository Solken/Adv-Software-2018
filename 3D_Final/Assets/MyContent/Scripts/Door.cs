using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    

    public Coin[] coins;
    private Coin rightC;
    //private Color color;
    public Material[] mats;
    private Material my_mat;
    private int randC;
    private bool vaild;

	// Use this for initialization
	void Start () {

        setTheCoin();
        setColors(coins);
        setCC(rightC,my_mat);
        vaild = true;

       // Debug.Log(randC);

        {
            //int temp;
            //temp = Random.Range(0, coins.Length-1);
            //Debug.Log(temp);
            //rightC = coins[temp];

            //Vector3 RBG;
            //RBG.x = Random.Range(0, 256);
            //color.r = Random.Range(0, 256);
            //color.g = Random.Range(0, 256);
            //color.b = Random.Range(0, 256);
            //mat = GetComponent<Material>();
            //Debug.Log(mat.GetColor("White"));

            //int color = Random.Range(0, 5);
            //Material[] my_mat;
            //my_mat = GetComponent<Renderer>();
            //my_mat.
            //my_mat[0] = mats[color];
            //Debug.Log(my_mat[0].name);

            //Renderer rend;

            //rend = GetComponent<Renderer>();
            //rend.enabled = true;
            // rend.sharedMaterial = mats[color];
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!vaild)
        {
            //Debug.Log("DESTORY!");
            //DestroyObject(this.gameObject);
            Destroy(this);
        }
    }

    void setTheCoin()
    {
        int temp;
        temp = Random.Range(0, coins.Length);
        randC = temp;
        rightC = coins[temp];
    }

    void setColors(Coin[] coins)
    {
        int color = Random.Range(0, 6);
        my_mat = mats[color];
        Renderer rend;
        for(int i=0;i<coins.Length;i++)
        {
            //Material tempMat = mats[Random.Range(0, 6)];

            rend = coins[i].GetComponent<Renderer>();
            rend.enabled = true;
            if (i == randC)
            {
                //sets the correct coin's color
                rend.sharedMaterial = my_mat;
            }
            else
            {
                color = Random.Range(0, 6);
                while (mats[color] == my_mat)
                {
                    color = Random.Range(0, 6);
                }
                //sets the worng coin's colors
                rend.sharedMaterial = mats[color];
            }
            //rend.sharedMaterial = mats[color];
        }

        //Set the door's color to the correct color
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = my_mat;

    }

    void setCC(Coin coin, Material mat)
    {
        Renderer rend;
        rend = coin.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = mat;
    }

    public void removeCoin(Coin coin)
    {
        for(int i=0; i<coins.Length;i++)
        {
            if(coins[i].GetComponent<Material>() == coin.GetComponent<Material>())
            {
                if (i == randC)
                {
                    //vaild = false;

                    Debug.Log("KILL ME!");
                    //DestroyObject(this.gameObject);
                    
                }
                
            }
        }
    }

    public Coin getCoin()
    {
        return rightC;
    }

   // public void setVaild(vaild)

}
