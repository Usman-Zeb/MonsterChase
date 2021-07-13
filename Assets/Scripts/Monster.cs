using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody2D monsterbody;

    void Awake()
    {
        monsterbody = GetComponent<Rigidbody2D>();
        speed=2.0f;
    }

    void FixedUpdate()
    {
        monsterbody.velocity = new Vector2(speed, monsterbody.velocity.y);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
