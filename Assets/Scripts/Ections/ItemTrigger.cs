using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    
    
    public bool OnItemTrigger=false;
    public GameObject ItemObj;
    
    

    void Start()
    {
        
    }

    
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        ItemObj = gameObject;
        if (collision.CompareTag("Player"))
        {
            OnItemTrigger = true;
        }
    }

   

}
