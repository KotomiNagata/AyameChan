using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconLeft : MonoBehaviour {

    private Hantei hantei;                     // Hanteiコンポーネント
    bool One;                                  // Instantiateを１回だけ呼ぶための準備

    private void Start()
    {
        // Hanteiコンポーネントを取得
        hantei = GetComponent<Hantei>();
    }

    void Update()
    {

        Vector3 pos = this.gameObject.transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            if (-5.2 <= pos.x && pos.x <= -5.0)            //Perfect範囲
            {
                hantei.Perfect = true;
                hantei.Heal = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (-5.4 <= pos.x && pos.x < -5.2 ||           //Good範囲
                     -5.0 < pos.x && pos.x <= -4.8)
            {
                hantei.Good = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (pos.x < -5.4)                              //Bad範囲
            {
                hantei.Bad = true;
                hantei.Appearance();
                Destroy(gameObject);
                One = false;
            }
        }

        if (pos.x < -5.4)                                  //グレーに変わるタイミング
        {
            hantei.Out = true;
            hantei.Appearance();
            Destroy(gameObject);
        }

    }

}
