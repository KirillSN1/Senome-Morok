using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    private GameObject Tip;
    public float timer=5;

    void Start()
    {
        Tip = GameObject.FindGameObjectWithTag("Tips");
        Tip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        
        
         while (timer != 0)
         {
            if (timer <= 0)
            { 
                timer -= Time.deltaTime;
            }
         }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("true");
        Tip.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        Debug.Log("false");
        Tip.SetActive(false);
    }
}
