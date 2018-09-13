using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;    //シーン切り替えのための準備
using UnityEngine;

public class GameDifficult : MonoBehaviour
{

    StageIconEnemy stageIconEnemy;

    void Start()
    {
        stageIconEnemy = GetComponent<StageIconEnemy>();
        //指定されたコルーチンを呼び出す
        StartCoroutine("Rhythm");
    }

    private IEnumerator Rhythm()
    {
        // 4テンポ = 1460f
        //LUCK LUCK
        yield return new WaitForSeconds(3.5f);

        //LUCK
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.8f);

        //LUCK
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.8f);


        //1
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);

        //2 
        stageIconEnemy.IconLeft();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);


        //3 
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);

        //4
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);

        //5 
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);

        //6 
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.366f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);

        //7
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);

        //8
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.911f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.366f);

        //しょうたいは　だ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.7f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.562f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);

        //れも　しらない　ひ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //みつの
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.73f);

        //ヒーロー
        stageIconEnemy.IconLeft();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.73f);

        //あくやくの　よ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.732f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.546f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);

        //うにしても　みん
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //なはね　わ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.73f);

        //かってる
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.73f);

        //マスクに
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.914f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);

        //かくされ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.548f);

        //た　つよい
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.914f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);

        //やさしさ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.548f);

        //に　ずっと
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.914f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);

        //あこがれ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.548f);

        //て
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(2.95f);

        //ざわめく
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.914f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);

        //まちの
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.92f);

        //そらを
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(1.1f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);


        //みあげる
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(1.1f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(4.4f);

        //1 2 3 4 キ (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.365f);

        //ラキラキラ　ラッ (1回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //キーラッキーラッキー　み (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.184f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);

        //らいはほら　ハッ (1回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.365f);

        //ピーハッピーハッピー　そ (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);

        //らからいま　キ (1回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //ラキラキラ　co- (1回目)
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        // ming now
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.095f);

        //1 2 3 4 キ (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.365f);

        //ラキラキラ　ハッ (2回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //ピーハッピーハッピー　み (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);

        //らいはほら　ラッ (2回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.365f);

        //キーラッキーラッキー　キ (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);

        //ラキラキラ　ド (2回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        //キドキドキ　fa- (2回目)
        stageIconEnemy.IconLeft();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.365f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.365f);

        // ling love
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.7f);

        //キラキラキラー
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(5f);

        //キラキラキラー
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.183f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.182f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(3.8f);

        //かんぜんキラキラキラキラー
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.36f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.36f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.36f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.36f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.18f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.18f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.18f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(10f);

        //シーン切り替え
        SceneManager.LoadScene("GameCrear");


    }
}
