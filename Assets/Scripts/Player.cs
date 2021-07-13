using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float moveForce;
    
    [SerializeField]
    private float jumpForce;
   
    private float movementX;
    private Rigidbody2D playerbody;
    private Animator anim;
    private string WALK_ANIMATION;

    [SerializeField]
    private float minX, maxX;

    private string GROUND_TAG;

    private string ENEMY_TAG;

    private SpriteRenderer spriteRenderer;

    private bool onGround;
    public Player(){
        moveForce=10.0f;
        jumpForce=11.0f;
        minX=-68f;
        maxX = 68f;
        WALK_ANIMATION = "Walk";
        GROUND_TAG = "Ground";
        ENEMY_TAG = "Enemy";
        onGround=false;
        

    }

    void Awake()
    {
        playerbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        minX=-68f;
        maxX = 68f;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
        PlayerJump();

        
    }

    void FixedUpdate()
    {
        
    }

    

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX,0f,0f) * Time.deltaTime * moveForce;
        
        
    }

    void AnimatePlayer()
    {
        if(movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            spriteRenderer.flipX=false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            spriteRenderer.flipX=true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
        
    }

    void PlayerJump()
    {
        if(Input.GetButtonDown("Jump") && onGround)
        {
            playerbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            onGround=false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag(GROUND_TAG))
        {
            onGround = true;

        }

        if(collision.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
        }
    }
}
