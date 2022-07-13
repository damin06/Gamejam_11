using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnLock : MonoBehaviour
{
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject cat5;
    public GameObject cat6;

    public Image catt2;

    // Update is called once per frame
    void Update()
    {
        if (SkinChoose.skin.Cat2 == true)
        {
            catt2.color = Color.white;
        }
    }
}
