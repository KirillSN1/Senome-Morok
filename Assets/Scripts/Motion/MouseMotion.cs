using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMotion : MonoBehaviour
{

    
    
    public int MouseButton;
    private bool moveOn=false;
    private Vector3 target;
    
  
    public float offset;


    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector2 StartPos = player.transform.position;
        
        if (Input.GetMouseButtonUp(MouseButton))
        {
            
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveOn = true;
        }
        if (moveOn)
        {
            player.transform.position = Vector2.MoveTowards(StartPos, target, Time.deltaTime * offset);
        }
        if (Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.S))
        {
            moveOn = false;
        }
                
    }
}
