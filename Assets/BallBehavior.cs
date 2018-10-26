using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
    public int velx;
    public int vely;
    int posx;
    int posy;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        posx += velx;
        posy += vely;
	}
}
