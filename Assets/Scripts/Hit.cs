using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    
    Renderer rend;
    Color color;
    float alpha;

	void Start () {

        rend = GetComponent<Renderer>();
        alpha = 1;
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * 10;
	}
	
	void Update () {

        //フェードアウト
        alpha = alpha - Time.deltaTime * 3f;
        rend.material.color = new Color(1f, 1f, 1f, alpha);

        // Y = 6 を過ぎたらオブジェクトを削除
        if ( 6 < transform.position.y)
        {
            Destroy(gameObject);
        }
	}
}
