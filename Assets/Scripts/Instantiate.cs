using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {

    private Animator animator;       // アニメーターコンポーネント
    public GameObject hit;           // 当たり判定に入った時のオブジェクト
    public GameObject deviate;       // 当たり判定に外れた時のオブジェクト
    public GameObject perfect;       // おりゃあ！  or HP回復！
    public GameObject good;          // トゥ！
    public GameObject bad;           // あれれ・・・
    public GameObject bomb;          // Bomb生成
    bool hitB;
    bool deviateB;
    bool perfectB;
    bool goodB;
    bool badB;
    bool bombB;

	void Start () {
        // アニメーターコンポーネントを取得
        animator = GetComponent<Animator>();
        hitB = true;
        deviateB = true;
        perfectB = true;
        goodB = true;
        badB = true;
        bombB = true; 
	}

    // アニメーターコンポーネントの取得
    public Animator GetAnimator()
    {
        return animator;
    }

    public void Hit()                // 当たり判定に入った時のオブジェクト作成
    {
        if (hitB)
        {
            Instantiate(hit, transform.position, Quaternion.identity);
            hitB = false;
        }
    }

    public void Deviate()            // 当たり判定に外れた時のオブジェクト作成
    {
        if (deviateB)
        {
            Instantiate(deviate, transform.position, Quaternion.identity);
            deviateB = false;
        }
    }

    public void Perfect()
    {
        if (perfectB)
        {
            Instantiate(perfect);
            perfectB = false;
        }
    }

    public void Good()
    {
        if (goodB)
        {
            Instantiate(good);
            goodB = false;
        }
    }

    public void Bad()
    {
        if (badB)
        {
            Instantiate(bad);
            badB = false;
        }
    }

    public void Bomb(){
        if(bombB){
            Instantiate(bomb);
            bombB = false;
        }
    }
}
