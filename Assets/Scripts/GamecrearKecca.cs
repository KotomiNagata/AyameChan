using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Textを使うのに必要なコード

public class GamecrearKecca : MonoBehaviour {

    Score score;
    public Text scoreText;  // スコアテキスト
    private int score2;     // 結果のスコア
    int score3;             // 代入するスコア

	void Start () {
        score = GetComponent<Score>();
	}
	
	/*
	void Update () {
        scoreText.text = score.ToString("D8"); // 8桁まで表示
	}

    public void ScoreKecca(int score3)
    {
        score = score + (pointSG * combo2);
    }
    */

}
