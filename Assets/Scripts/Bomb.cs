using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    Renderer rend;
    Color color;
    float alpha;
    Collider collider1;

	void Start () {
        rend = GetComponent<Renderer>();
        collider1 = GetComponent<Collider>();
        alpha = 1;
        // Trigger ON 
	}

	void Update () {
        Vector3 scale = this.gameObject.transform.localScale;

        //拡大する
        gameObject.transform.localScale = new Vector3(
            scale.x + 0.3f,
            scale.y + 0.3f,
            scale.z
        );

        //もし大きさが1.3を超えたら拡大を止める
        if (scale.x > 1.3)
        {
            gameObject.transform.localScale = new Vector3(
            scale.x,
            scale.y,
            scale.z
        );
        }

        //もし、サイズが1.3を超えたらフェードアウトする
        if (scale.x > 1.3)
        {
            alpha = alpha - Time.deltaTime * 3f;
            rend.material.color = new Color(1f, 1f, 1f, alpha);
        }
     
        //もし完全に消えたらオブジェクトを消す
        if (alpha <= 0)
        {
            Destroy(gameObject);
        }

	}

}
