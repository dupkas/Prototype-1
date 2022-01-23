using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChangeP2 : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FPCam;
    public GameObject FPCam2;
    private int CamMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange ());
        }
    }
    
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            NormalCam.SetActive(false);
            FPCam.SetActive(true);
        }
        if (CamMode == 2)
        {
            FPCam2.SetActive(true);
            FPCam.SetActive(false);
        }
    }
}
