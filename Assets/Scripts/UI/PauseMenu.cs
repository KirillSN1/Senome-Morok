using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private GameObject InvObj;
    private GameObject PausePanel;
    public KeyCode Pause;



    void Start()
    {
        InvObj = GameObject.FindGameObjectWithTag("Inventory");
        PausePanel = GameObject.FindGameObjectWithTag("PausePanel");
        PausePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(Pause))
        {
            PausePanel.SetActive(true);
            
            
        }
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (PausePanel.activeInHierarchy)
        {
            player.GetComponent<Motion>().enabled = false;
            player.GetComponent<MouseMotion>().enabled = false;
        }
        else
        {
            player.GetComponent<Motion>().enabled = true;
            player.GetComponent<MouseMotion>().enabled = true;
        }
        if (InvObj.activeInHierarchy)
        {
            player.GetComponent<Motion>().enabled = false;
            player.GetComponent<MouseMotion>().enabled = false;
        }
        else
        {
            player.GetComponent<Motion>().enabled = true;
            player.GetComponent<MouseMotion>().enabled = true;
        }
    }
    
    public void DisableO()
    {
        
    }


    public void AppExit()
    {
        Application.Quit();
    }
}
