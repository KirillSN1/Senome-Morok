using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject PausePanel;
    public GameObject CraftMenu;
    public KeyCode Pause;
    public KeyCode OpenInv;


    void Start()
    {
        PausePanel.SetActive(false);
        Inventory.SetActive(false);
    }

    void Update()
    {

        OpenInventory();
        if (Input.GetKeyDown(Pause))
        {
            PausePanel.SetActive(true); 
        }
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (PausePanel.activeInHierarchy && Inventory.activeInHierarchy)
        {
            player.GetComponent<Motion>().enabled = false;
            player.GetComponent<MouseMotion>().enabled = false;
        }
        else
        {
            player.GetComponent<Motion>().enabled = true;
            player.GetComponent<MouseMotion>().enabled = true;
        }
        if (Inventory.activeInHierarchy)
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

    void OpenInventory()
    {
        if (Input.GetKeyDown(OpenInv))
        {
            if (Inventory.activeSelf)
            {
                Inventory.SetActive(false);
            }
            else
            {
                Inventory.SetActive(true);
            }
        }
    }
}
