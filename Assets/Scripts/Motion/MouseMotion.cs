using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMotion : MonoBehaviour
{

    
    
    public int MouseButton=1;
    private bool moveOn=false;  
    public float offset=4;
    [Header("Вспомогательные переменные")]
    public Vector2 StartPos;
    public Vector2 target;



    void Update()
    {
        PlayerAnimEvents();
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        //Vector2 StartPos = player.transform.position;
        StartPos = transform.position;
        GameObject Pause = GameObject.FindGameObjectWithTag("PausePanel");

        if (!Pause)
        { 
             if (Input.GetMouseButtonUp(MouseButton))
             {          
                 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                 moveOn = true;
             }
        }
        if (moveOn)
        {
            //player.transform.position = Vector2.MoveTowards(StartPos, target, Time.deltaTime * offset);
            transform.position = Vector2.MoveTowards(StartPos, target, Time.deltaTime * offset);
        }
        if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.S))
        {
            moveOn = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveOn = false;
        
    }

    void PlayerAnimEvents()
    {
        //GameObject player = GameObject.FindGameObjectWithTag("Player");

        //Vector2 PlayerPos = player.transform.position;
        Vector2 PlayerPos = transform.position;
        //По вертикали и горизонтали
        if (target.x > PlayerPos.x)
        {
            
        }
        else if (target.x < PlayerPos.x)
        {

        }

        if (target.y > PlayerPos.y)
        {

        }
        else if (target.y < PlayerPos.y)
        {

        }
        //По даогоналям
        if(target.x> PlayerPos.x && target.y > PlayerPos.y)//вправо вверх
        {

        }
        else if(target.x < PlayerPos.x && target.y < PlayerPos.y)//влево вниз
        {

        }

        if(target.x < PlayerPos.x && target.y > PlayerPos.y)//влево вверх
        {

        }
        else if(target.x > PlayerPos.x && target.y < PlayerPos.y)//вправо вниз
        {

        }
        //Idle
        if (target == PlayerPos)
        {

        }
        


    }
}
