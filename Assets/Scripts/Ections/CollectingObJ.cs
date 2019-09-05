using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingObJ : MonoBehaviour
{

    private GameObject Player;
    private MouseMotion PlayerPos;
    public float time=5;
    public float Dtime;
    private bool Timer=false;
    private GameObject ProgressB;
    private Slider PB;
    
   
    void Start()
    {
        Dtime = time;
        Player = GameObject.FindGameObjectWithTag("Player");
        PlayerPos = Player.GetComponent<MouseMotion>();
        ProgressB = GameObject.FindGameObjectWithTag("Tips");
        PB = ProgressB.GetComponent<Slider>();
        ProgressB.SetActive(false);
        PB.minValue = -time;
    }

    private void Update()
    {
   


    }

    private void FixedUpdate()
    {
        
        if (Timer)
        {
            
            PB.value = -time;
            time = time - 0.04f;
            if (time < 0)
            {
               Destroy(gameObject);
               ProgressB.SetActive(false);
            }
            if(Input.GetKey(KeyCode.A) ^ Input.GetKey(KeyCode.W) ^ Input.GetKey(KeyCode.D) ^ Input.GetKey(KeyCode.S))
            {
                Timer = false;
                ProgressB.SetActive(false);
            }

        }
        if (!Timer)
        {
            
            time = Dtime;
        }
       
        
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            ProgressB.SetActive(true);
            Timer = true;
            Player = GameObject.FindGameObjectWithTag("Player");

        }
    }

    






}
