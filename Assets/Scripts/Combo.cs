using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Textを使うのに必要なコード

public class Combo : MonoBehaviour {
    
    public Text comboText;     // コンボを表示するText
    private int combo;         // コンボ
    private int allcombo;

	void Start ()
    {
        combo = 0;
	}

	void Update ()
    {
        comboText.text = combo.ToString("D3");  // 3桁まで表示
        AllCombo();
	}

    public void AddCombo(int pointC)
    {
        combo = combo + pointC;
    }

    public void RemoveCombo(int pointC)
    {
        combo = combo - (pointC * combo);
    }

    public void AllCombo()
    {
        allcombo = combo;
        FindObjectOfType<Score>().IsCombo(allcombo);
    }

}
