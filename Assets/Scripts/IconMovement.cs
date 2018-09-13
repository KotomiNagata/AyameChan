using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMovement : MonoBehaviour {

    public int speed = -5;           // 移動スピード
   
    void Start()
    {
        // ローカル座標のY軸での右方向に移動する
        GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
    }
}
