using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Textを使うのに必要なコード

public class Score : MonoBehaviour {

    Combo combo;
    GamecrearKecca gamecrearKecca;
    public Text scoreText;  // スコアテキスト
    private int score;      // スコア
    int combo2;

	void Start ()
    {
        score = 0;
        combo2 = 0;
        gamecrearKecca = GetComponent<GamecrearKecca>();
	}
	
	void Update ()
    {
        scoreText.text = score.ToString("D8"); // 8桁まで表示

	}

    public void IsCombo(int allcombo)
    {
        combo2 = allcombo + 1;
    }

    //ポイントの追加
    public void AddPointP (int pointSP)
    {
        score = score + (pointSP * combo2);
    }

    //ポイントの追加
    public void AddPointG(int pointSG)
    {
        score = score + (pointSG * combo2);
    }

}
