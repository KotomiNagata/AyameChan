using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconDown : MonoBehaviour
{
    
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

        if (Input.GetKey(KeyCode.DownArrow))
        {

            if (-5.06 <= pos.x && pos.x <= -4.86)            //Perfect範囲
            {
                hantei.Perfect = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (-5.26 <= pos.x && pos.x < -5.06 ||           //Good範囲
                     -4.86 < pos.x && pos.x <= -4.66)
            {
                hantei.Good = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (pos.x < -5.26)                              //Bad範囲
            {
                hantei.Bad = true;
                hantei.Appearance();
                Destroy(gameObject);
                One = false;
            }
        }

        if (pos.x < -5.26)                                  //グレーに変わるタイミング
        {
            hantei.Out = true;
            hantei.Appearance();
            Destroy(gameObject);
        }

    }
}
