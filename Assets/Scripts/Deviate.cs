using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deviate : MonoBehaviour {

    public GameObject deviate;
    public int speed = -5;
    private Hantei hantei;
    bool One;

	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
        hantei = GetComponent<Hantei>();
        One = true;
	}
	
	void Update () {

        Vector3 pos = this.gameObject.transform.position;

        //Miss範囲
        if (pos.x < -7)
        {
            if (One)
            {
                Instantiate(deviate);
                One = false;
                hantei.Out = true;
                hantei.Appearance();
            }
        }

        // X = -8 を過ぎたらオブジェクトを削除
        if (transform.position.x < -8)
        {
            Destroy(gameObject);
        }
	}
}
