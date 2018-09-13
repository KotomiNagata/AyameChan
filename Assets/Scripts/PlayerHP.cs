using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    // シーン切り替えのための準備
using UnityEngine.UI;                 // Sliderを入れるための準備

public class PlayerHP : MonoBehaviour {

    GameOver gameOver;
    private Slider hpSlider;
    private int maxHP = 20;  // 最大体力
    private int HP;          // 体力
    bool easy;
    bool difficult;

	void Start ()
    {
        gameOver = GetComponent<GameOver>();
        //Buttonから教えてくれる
        easy = false;
        difficult = false;

        hpSlider = GameObject.Find("Slider").GetComponent<Slider>();
        hpSlider.value = maxHP;
        HP = maxHP;
	}

	void Update () {

        hpSlider.value = HP;

		if(HP <= 0)
        {
            if(easy)
            {
                gameOver.Easy();
            }
            if(difficult)
            {
                gameOver.Difficult();
            }

            SceneManager.LoadScene("GameOver");
        }
	}

    public void RemoveHP(int hpm)
    {
        HP = HP - hpm;
    }

    public void AddHP(int hpm)
    {
        HP = HP + hpm;
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
