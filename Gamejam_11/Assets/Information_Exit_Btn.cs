using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information_Exit_Btn : MonoBehaviour
{
    public GameObject Information_PopUp;
    public GameObject Information_Exit_Btnn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OutClick()
    {
        Information_PopUp.SetActive(false);
        Information_Exit_Btnn.SetActive(false);
    }
}
