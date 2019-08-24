using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    private GameObject Panel;
    



    void Start()
    {
        Panel = GameObject.FindGameObjectWithTag("PausePanel");
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(true);
            
            
        }
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (Panel.activeInHierarchy)
        {
            player.GetComponent<MotionScript1>().enabled=false;
        }
        else player.GetComponent<MotionScript1>().enabled = true;

    }
    
    public void DisableO()
    {
        
    }


    public void AppExit()
    {
        Application.Quit();
    }
}
