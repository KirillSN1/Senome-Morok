using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    [Header("Motion")]
    public float NormalSpeed=4;
    public float SprintSpeed = 6;
   
    private float Speed;
    private Rigidbody2D RB;
    private Vector2 MVelos;
    

    [Header("WallFix")]
    public LayerMask CollLayer;
    
    
    void Start()
    {
        
        RB = GetComponent<Rigidbody2D>();
        Speed = NormalSpeed;
    }

    
    void Update()
    {
      Vector2 MInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
      MVelos = MInput.normalized * Speed;
      RayCollision();
      SpriteChangerFliper();
      Sprint();
        
    }


    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + MVelos * Time.deltaTime);
        
    }



    void RayCollision()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        RaycastHit2D hit;
        Vector2 sPos = transform.position;
        Vector2 ePos = new Vector2(x, y);

        GameObject player = this.gameObject;
        CapsuleCollider2D Coll = player.GetComponent<CapsuleCollider2D>();
        Coll.enabled = false;
        hit = Physics2D.Linecast(sPos, ePos, CollLayer);
        Coll.enabled = true;
    }
   void SpriteChangerFliper()
   {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        SpriteRenderer Rend = player.GetComponent<SpriteRenderer>();
        if (Input.GetKeyDown(KeyCode.A) ^ (Input.GetKeyDown(KeyCode.LeftArrow)))
        {
            Rend.flipX = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) ^ (Input.GetKeyDown(KeyCode.RightArrow)))
        {
            Rend.flipX = false;
        }
        
   }
    void Sprint()
    {
            if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.S))
            {

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    Speed = SprintSpeed;


                }
                else if (Input.GetKeyUp(KeyCode.LeftShift))
                {
                    Speed = NormalSpeed;
                }
            }

            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                Speed = NormalSpeed;
            }
        
    }
    
        
}




