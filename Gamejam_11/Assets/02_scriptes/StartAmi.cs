using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAmi : MonoBehaviour
{
    public bool AmiStart;
    public GameObject Title;
    public GameObject CatBackground;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (AmiStart == true)
        {
            Vector3 velo = Vector3.zero;

            Vector3 target = new Vector3(550, 2500, 0);
            Title.transform.position = Vector3.SmoothDamp(Title.transform.position, target, ref velo, 0.09f);

            Vector3 targett = new Vector3(550, -1500, 0);
            CatBackground.transform.position = Vector3.SmoothDamp(CatBackground.transform.position, targett, ref velo, 0.06f);
        }
    }
}
