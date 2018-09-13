using System.Collections;
using System.Collections.Generic; 
using UnityEngine.SceneManagement;    //シーン切り替えのための準備
using UnityEngine;

public class GameEasy : MonoBehaviour {

    StageIconEnemy stageIconEnemy;

	void Start()
	{
        stageIconEnemy = GetComponent<StageIconEnemy>();
        //指定されたコルーチンを呼び出す
        StartCoroutine("Rhythm");
	}

    private IEnumerator Rhythm()
    {
        //LUCK LUCK
        yield return new WaitForSeconds(3.47f);

        //LUCK         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();         yield return new WaitForSeconds(1.666f);          //LUCK         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();         yield return new WaitForSeconds(0.416f);         stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();         yield return new WaitForSeconds(1.666f);

        //1
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.3f);

        //2
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.833f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.55f);

        //3
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.416f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.3f);

        //4
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.8f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.833f);

        //5
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.3f);

        //6
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.75f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.75f);

        //7
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.35f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.25f);

        //8
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.2f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.416f);

        //しょうたいは　だ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.749f);

        //れも　しらない　ひ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.749f);

        //みつの
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);

        //ヒーロー
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.7f);

        //あくやくの　よ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.749f);

        //うにしても　みん
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.7f);

        //なはね　わ
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);

        //かってる
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.7f);

        //マスクに
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.7f);

        //かくされ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.7f);

        //た　つよい
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.7f);

        //やさしさ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.7f);

        //に　ずっと
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.7f);

        //あこがれ
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.749f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.7f);

        //て
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(3f);

        //ざわめく
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(1.123f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //まちの
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.123f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //そらを
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(1.123f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //みあげる
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.123f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(4.3f);

        //1 2 3 4 キ (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.374f);

        //ラキラキラ　ラッ (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //キーラッキーラッキー　み (1回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //らいはほら　ハッ (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //ピーハッピーハッピー　そ (1回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //らからいま　キ (1回目)
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
        yield return new WaitForSeconds(0.374f);

        //ラキラキラ　co- (1回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        // ming now
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(1.1f);

        //1 2 3 4 キ (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(0.374f);

        //ラキラキラ　ハッ (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //ピーハッピーハッピー　み (2回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //らいはほら　ラッ (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //ッキーラッキーラッキー　キ (2回目)
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        //ラキラキラ　ド (2回目)
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
        yield return new WaitForSeconds(0.374f);

        //キドキドキ　fa- (2回目)
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);

        // ling love
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(1.8f);

        //キラキラキラー
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(4.8f);

        //キラキラキラー
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconLeft();
        stageIconEnemy.Kutushita();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(3.3f);

        //かんぜんキラキラキラキラー
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconRight();
        stageIconEnemy.Broccoli();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconUp();
        stageIconEnemy.Ribon();
        yield return new WaitForSeconds(0.374f);
        stageIconEnemy.IconDown();
        stageIconEnemy.Sojiki();
        yield return new WaitForSeconds(10f);

        //シーン切り替え
        SceneManager.LoadScene("GameCrear");

    }

}
