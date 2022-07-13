using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent_information : MonoBehaviour
{
    public GameObject Information_PopUp;
    public GameObject Information_Exit_Btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        Information_PopUp.SetActive(true);
        Information_Exit_Btn.SetActive(true);
    }
}
