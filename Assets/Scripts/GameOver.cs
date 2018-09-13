using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    //PlayerHPから教えてくれる
    public bool easy;
    public bool difficult;

	void Start () {
        easy = false;
        difficult = false;
	}

	void Update () {
		
	}

    public void Easy()
    {
        easy = true;
    }

    public void Difficult()
    {
        difficult = true;
    }
}
