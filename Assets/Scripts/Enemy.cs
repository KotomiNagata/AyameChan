using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    Animator animator;
    Renderer rend;         // 色設定
    Color color;           // 色設定
    float alpha;           // 色設定
    public int speed = -5; // 移動速度
    string state;          // エネミーの状態管理
    string prevState;      // 前の状態を保存
    bool die;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        die = false;

        //色設定
        rend = GetComponent<Renderer>();
        alpha = 1;
        //移動
        GetComponent<Rigidbody2D>().velocity = transform.right.normalized * speed;
    }

    void Update()
    {
        
        Vector3 pos = this.gameObject.transform.position;

        if(0.5 < pos.x){
        }

        if(pos.x < -0.5){
            alpha = alpha - Time.deltaTime * 5f;
            rend.material.color = new Color(1f, 1f, 1f, alpha);
            if (alpha < 0)
            {
                Destroy(gameObject);
            }
        }

        if(die){

            GetComponent<Rigidbody2D>().velocity = transform.right.normalized * 0;
            Vector3 v = new Vector3(transform.position.x + 0.3f, transform.position.y + 0.3f, transform.position.z);
            transform.position = v;
            transform.Rotate(new Vector3(0, 0, -360) * Time.deltaTime, Space.World);

            // Y = 10 を過ぎたらオブジェクトを削除
            if (10 < transform.position.y)
            {
                Destroy(gameObject);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D c){
        die = true;
    }

}