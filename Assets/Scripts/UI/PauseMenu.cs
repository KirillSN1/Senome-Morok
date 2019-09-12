using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private GameObject ItemCont;
    private GameObject Panel;
    public KeyCode Pause;



    void Start()
    {
        ItemCont = GameObject.FindGameObjectWithTag("Inventory");
        Panel = GameObject.FindGameObjectWithTag("PausePanel");
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(Pause))
        {
            Panel.SetActive(true);
            
            
        }
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (Panel.activeInHierarchy ^ ItemCont.activeInHierarchy)
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
