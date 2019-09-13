using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public List<Item> item;
    public GameObject ItemCont;
    public KeyCode InvButton;
    public KeyCode TakeButton;
    private GameObject player;
    private ItemTrigger trigger;
    public GameObject SelectedObj;


    void Start()
    {
        GameObject trigObj = GameObject.FindGameObjectWithTag("Collectable");
        trigger=trigObj.GetComponent<ItemTrigger>();
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
        Collect();
        
    }

    void ShowInventory()
    {        
        if (Input.GetKeyDown(InvButton)) 
        {
            if (ItemCont.activeInHierarchy == false)
            {
                ItemCont.SetActive(true);
                
            }
            else ItemCont.SetActive(false);
        }
    }
    void ShowItem()
    {
        for (int i = 0; i < item.Count; i++)
        {                         
                Transform cell = ItemCont.transform.GetChild(i);
                Transform icon = cell.transform.GetChild(0);
                Image img = icon.GetComponent<Image>();
            if (item[i].id != 0)
            {

                img.enabled = true;
                img.sprite = Resources.Load<Sprite>(item[i].iconPath);

            }
            else
            {
                img.enabled = false;
                img.sprite = null;
            }
            break;
        }
    }

    void Collect()
    {
        if (trigger.OnItemTrigger)
        {
            if (Input.GetKeyDown(TakeButton))
            {
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i].id == 0)
                    {
                        item[i] = trigger.ItemObj.GetComponent<Item>();
                        ShowItem();
                        Destroy(trigger.ItemObj);
                    }
                    break;
                }
            }
        }
    }

    
}
