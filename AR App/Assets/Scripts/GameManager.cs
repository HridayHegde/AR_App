using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dance()
    {
        Player.GetComponent<Animator>().SetTrigger("Dance");
    }
}
