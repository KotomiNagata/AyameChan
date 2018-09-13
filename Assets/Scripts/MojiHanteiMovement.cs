using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MojiHanteiMovement : MonoBehaviour {

    Renderer rend;
    Color color;
    float alpha;

	void Start () {
        rend = GetComponent<Renderer>();
        alpha = 1;
	}

	void Update () {

        Vector3 scale = this.gameObject.transform.localScale;

        //拡大する
        gameObject.transform.localScale = new Vector3(
            scale.x + 0.05f,
            scale.y + 0.05f,
            scale.z
        );

        //もし大きさが0.6を超えたら拡大を止める
        if(scale.x > 0.6){
            gameObject.transform.localScale = new Vector3(
            scale.x,
            scale.y,
            scale.z
        );
        }

        //もし、サイズが0.6を超えたらフェードアウトする
        if(scale.x > 0.6){
            alpha = alpha - Time.deltaTime * 3f;
            rend.material.color = new Color(1f, 1f, 1f, alpha);
        }

        //もし完全に消えたらオブジェクトを消す
        if (alpha < 0)
        {
            Destroy(gameObject);
        }
	}
}
