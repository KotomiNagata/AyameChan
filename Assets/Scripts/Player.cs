using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Animator animator;

    string state;                  // プレイヤーの状態管理
    string prevState;              // 前の状態を保存
    bool buttonON;

    void Start () {

        this.animator = GetComponent<Animator>();
        buttonON = false;

	}

    void Update()
    {
        GetInputKey();          // ボタンによって状態を変更する
        ChangeAnimation();      // 状態に応じてアニメーション
    }

    void GetInputKey(){

        //普段の状態
        state = "USUALLY";

        //上キーを押した場合、攻撃１
        if (Input.GetKey(KeyCode.UpArrow))
        {
            state = "ATTACK1";
        }

        //右キーを押した場合、攻撃２
        if (Input.GetKey(KeyCode.RightArrow))
        {
            state = "ATTACK2";
        }

        //下キーを押した場合、攻撃３
        if (Input.GetKey(KeyCode.DownArrow))
        {
            state = "ATTACK3";
        }

        //左キーを押した場合、防御
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            state = "DEFENSE";
        }
    }

    void ChangeAnimation(){

        //状態が変わった場合のみアニメーションを変更する
        if (prevState != state)
        {
            switch (state)
            {
                case "USUALLY":
                    animator.SetBool("isUsually", true);
                    animator.SetBool("isAttack1", false);
                    animator.SetBool("isAttack2", false);
                    animator.SetBool("isAttack3", false);
                    animator.SetBool("isDefense", false);
                    buttonON = true;
                    break;
                case "ATTACK1":
                    animator.SetBool("isUsually", false);
                    animator.SetBool("isAttack1", true);
                    animator.SetBool("isAttack2", false);
                    animator.SetBool("isAttack3", false);
                    animator.SetBool("isDefense", false);
                    buttonON = true;
                    break;
                case "ATTACK2":
                    animator.SetBool("isUsually", false);
                    animator.SetBool("isAttack1", false);
                    animator.SetBool("isAttack2", true);
                    animator.SetBool("isAttack3", false);
                    animator.SetBool("isDefense", false);
                    buttonON = true;
                    break;
                case "ATTACK3":
                    animator.SetBool("isUsually", false);
                    animator.SetBool("isAttack1", false);
                    animator.SetBool("isAttack2", false);
                    animator.SetBool("isAttack3", true);
                    animator.SetBool("isDefense", false);
                    buttonON = true;
                    break;
                case "DEFENSE":
                    animator.SetBool("isUsually", false);
                    animator.SetBool("isAttack1", false);
                    animator.SetBool("isAttack2", false);
                    animator.SetBool("isAttack3", false);
                    animator.SetBool("isDefense", true);
                    buttonON = true;
                    break;
            }

            //状態の変更を判定するために状態を保存しておく
            //prevState = state;

        }

        }
    }


