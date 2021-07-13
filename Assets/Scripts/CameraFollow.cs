using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;
    [SerializeField]
    private float minX, maxX;

    
    // Start is called before the first frame update
    public CameraFollow()
    {
        this.minX = -60f;
        this.maxX = 60f;
    }
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        minX = -60f;
        maxX = 60f;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player) return;

        tempPos = transform.position;
        tempPos.x = player.position.x;

        if(tempPos.x<minX)
        {
            tempPos.x = minX;
        }
        if (tempPos.x>maxX)
        {
            tempPos.x = maxX;
        }

        transform.position = tempPos;
    }
}
