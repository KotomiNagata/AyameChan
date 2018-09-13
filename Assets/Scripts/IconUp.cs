using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconUp : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow))
        {

            if (-5.04 <= pos.x && pos.x <= -4.84)            //Perfect範囲
            {
                hantei.Perfect = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (-5.24 <= pos.x && pos.x < -5.04 ||           //Good範囲
                     -4.84 < pos.x && pos.x <= -4.64)
            {
                hantei.Good = true;
                hantei.Appearance();
                Destroy(gameObject);
            }

            if (pos.x < -5.24)                              //Bad範囲
            {
                hantei.Bad = true;
                hantei.Appearance();
                Destroy(gameObject);
                One = false;
            }
        }

        if (pos.x < -5.24)                                  //グレーに変わるタイミング
        {                      
            hantei.Out = true;
            hantei.Appearance();
            Destroy(gameObject);
        }

        }
    }
