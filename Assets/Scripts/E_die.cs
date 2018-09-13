using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_die : MonoBehaviour {
    
	void Update()
	{
        Vector3 v = new Vector3(transform.position.x + 0.3f, transform.position.y + 0.3f, transform.position.z);
        transform.position = v;
        transform.Rotate(new Vector3(0, 0, -360) * Time.deltaTime, Space.World);

        // Y = 10 を過ぎたらオブジェクトを削除
        if (10 < transform.position.y)
        {
            Destroy(gameObject);
        }
	}

}
