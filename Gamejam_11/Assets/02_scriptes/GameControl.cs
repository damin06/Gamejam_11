using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;

    public bool Language = true;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (control == null)
        {
            control = this;
        }
        else if (control != this)
        {
            Destroy(this);
        }
    }
}
