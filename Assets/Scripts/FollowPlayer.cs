using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
