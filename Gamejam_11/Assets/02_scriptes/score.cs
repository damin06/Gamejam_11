using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    [SerializeField]Text timeText;
    private float time;

    void Update()
    {
        time += Time.deltaTime;

         timeText.text = string.Format("{0:N2}", time);
    }
}
