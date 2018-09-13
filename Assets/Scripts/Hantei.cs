using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hantei : MonoBehaviour {

    Instantiate instantiate; // Instantiateコンポーネント
    Combo combo;
    Score score;
    PlayerHP playerHP;
    public bool Perfect;
    public bool Good;
    public bool Bad;
    public bool Out;     // アイコンがグレーに
    public bool Heal;
    int pointC = 1;      // コンボ値
    int pointSP = 1000;  // Perfectのポイント値
    int pointSG = 500;   // Goodのポイント値
    int htm = 1;         // 差し引かれるHP値

	void Start () {
        
        // Instantiateコンポーネントを取得
        instantiate = GetComponent<Instantiate>();

        Perfect = false;
        Good = false;
        Bad = false;
        Out = false;
        Heal = false;
	}

    public void Appearance () {
        
        if (Perfect)
        {
            instantiate.Perfect();
            instantiate.Hit();
            instantiate.Bomb();
            Perfect = false;

            FindObjectOfType<Combo>().AddCombo(pointC);
            FindObjectOfType<Score>().AddPointP(pointSP);
        }
        if (Good)
        {
            instantiate.Good();
            instantiate.Hit();
            instantiate.Bomb();
            Good = false;

            FindObjectOfType<Combo>().AddCombo(pointC);
            FindObjectOfType<Score>().AddPointG(pointSG);
        }
        if (Bad)
        {
            instantiate.Bad();
            Bad = false;
            FindObjectOfType<Combo>().RemoveCombo(pointC);
            FindObjectOfType<PlayerHP>().RemoveHP(htm);
        }
        if(Out)
        {
            instantiate.Deviate();
            Out = false;
            FindObjectOfType<Combo>().RemoveCombo(pointC);
            FindObjectOfType<PlayerHP>().RemoveHP(htm);
        }
        if(Heal)
        {
            Heal = false;
            FindObjectOfType<PlayerHP>().AddHP(htm);
        }

	}

}
