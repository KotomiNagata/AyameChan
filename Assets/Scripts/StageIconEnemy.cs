using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageIconEnemy : MonoBehaviour {

    public GameObject iconUp;
    public GameObject iconDown;
    public GameObject iconRight;
    public GameObject iconLeft;
    public GameObject broccoli;
    public GameObject ribon;
    public GameObject kutushita;
    public GameObject sojiki;

    public void IconUp()
    {
        Instantiate(iconUp);
    }

    public void IconDown()
    {
        Instantiate(iconDown);
    }

    public void IconRight()
    {
        Instantiate(iconRight);
    }

    public void IconLeft()
    {
        Instantiate(iconLeft);
    }

    public void Broccoli()
    {
        Instantiate(broccoli);
    }

    public void Ribon()
    {
        Instantiate(ribon);
    }

    public void Kutushita()
    {
        Instantiate(kutushita);
    }

    public void Sojiki()
    {
        Instantiate(sojiki);
    }
}
