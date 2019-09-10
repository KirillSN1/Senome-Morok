using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    List<Item> item;
    public GameObject ItemCont;
    public KeyCode InvButton;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        int ChildCount = ItemCont.transform.childCount;
        item = new List<Item>();
        for(int i=0; i < ChildCount; i++)
        {
            item.Add(new Item());
        }
        ItemCont.SetActive(false);
    }

    
    void Update()
    {
        ShowInventory();
    }



    void ShowInventory()
    {        
        if (Input.GetKeyDown(InvButton)) 
        {
            if (ItemCont.activeInHierarchy == false)
            {
                ItemCont.SetActive(true);
                
            }
            else
            {
                ItemCont.SetActive(false);
                
            }
        }
    }
}
