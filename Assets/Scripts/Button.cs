using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;    //シーン切り替えのための準備

public class Button : MonoBehaviour {

    PlayerHP playerHP;
    GameOver gameOver;

	void Start()
	{
        playerHP = GetComponent<PlayerHP>();
        gameOver = GetComponent<GameOver>();
	}

	void Update () {
        
        Vector3 scale = this.gameObject.transform.localScale;

        //拡大する
        gameObject.transform.localScale = new Vector3(
            scale.x,
            scale.y + 0.1f,
            scale.z
        );

        if (scale.y > 1)
        {
            gameObject.transform.localScale = new Vector3(
            scale.x,
            scale.y,
            scale.z
        );

        }
	}

    public void OnClickStart()
    {
        //シーン切り替え
        SceneManager.LoadScene("Select");
    }

    public void OnClickEasy()
    {
        //シーン切り替え
        SceneManager.LoadScene("Easy");
        playerHP.Easy();

    }

    public void OnClickDifficult()
    {
        //シーン切り替え
        SceneManager.LoadScene("Difficult");
        playerHP.Difficult();
    }

    /*
    public void OnClickRetry()
    {
        if (gameOver.easy == true)
        {
            SceneManager.LoadScene("Easy");
        }
        if (gameOver.difficult == true)
        {
            SceneManager.LoadScene("Difficult");
        }
    }
    */

    public void OnClickTitle()
    {
        //シーン切り替え
        SceneManager.LoadScene("Title");
    }

}
