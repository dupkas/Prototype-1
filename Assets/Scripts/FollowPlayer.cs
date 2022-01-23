using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    private Vector3 offsetPosViewMode0 = new Vector3(0, 5f, -6.98f);
    private Vector3 offsetRotViewMode0 = new Vector3(23.587f, 0, 0);
    
    private Vector3 offsetPosViewMode1 = new Vector3(1.22f, 1.19f, 2.53f);
    private Vector3 offsetRotViewMode1 = new Vector3(10, 0, 0);

    private Vector3 offsetPosViewMode2 = new Vector3(1.22f, 1.82f, 0.84f);
    private Vector3 offsetRotViewMode2 = new Vector3(0, 0, 0);

    private int viewMode = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            viewMode += 1;
        }

        if (viewMode == 0)
        {
            // Offset the camera behind and above the player
            transform.position = player.transform.position + offsetPosViewMode0;
            transform.rotation = player.transform.rotation * Quaternion.Euler(offsetRotViewMode0);
        }
        else if (viewMode == 1)
        {
            transform.position = player.transform.position + offsetPosViewMode1;
            transform.rotation = player.transform.rotation * Quaternion.Euler(offsetRotViewMode1);
        }
        else if (viewMode == 2)
        {
            transform.position = player.transform.position + offsetPosViewMode2;
            transform.rotation = player.transform.rotation;
        }
        else if (viewMode == 3)
            viewMode = 0;
    }
}
