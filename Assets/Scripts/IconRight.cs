using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconRight : MonoBehaviour {
    
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

        if (Input.GetKey(KeyCode.RightArrow))
        {

            if (-4.96 <= pos.x && pos.x <= -4.76)            //Perfect範囲
            {
                hantei.Perfect = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (-5.16 <= pos.x && pos.x < -4.96 ||           //Good範囲
                     -4.76 < pos.x && pos.x <= -4.56)
            {
                hantei.Good = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (pos.x < -5.16)                              //Bad範囲
            {
                hantei.Bad = true;
                hantei.Appearance();
                Destroy(gameObject);
                One = false;
            }
        }

        if (pos.x < -5.16)                                  //グレーに変わるタイミング
        {
            hantei.Out = true;
            hantei.Appearance();
            Destroy(gameObject);
        }

    }
}