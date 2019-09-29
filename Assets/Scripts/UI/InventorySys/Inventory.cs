using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Inventory : MonoBehaviour
{
    [Header("RecDesc")]
    public KeyCode OpenInv;
    public GameObject Inv;
    public Scrollbar InvScroll;
    public Scrollbar DDscroll;
    public GameObject DDTitle;
    public GameObject DText;
    [Header("DropItem")]
    public int IdSelectedItem;
    public KeyCode DropItem;
    public GameObject Content;
    public int ChildCount;
    private int SelectedNumber;
    private GameObject Player;
    


    private void Start()
    {
        
        Inv.SetActive(false);
        InvScroll.value = 1;       
        DDTitle.SetActive(false);
        DText.SetActive(false);

        Player = GameObject.FindGameObjectWithTag("Player");

        ChildCount = Content.transform.childCount;
    }

    void Update()
    {
        OpenInventory();
        //DropSelectedItem();
    }

    void OpenInventory()
    {
        if (Input.GetKeyDown(OpenInv))
        {
            if (Inv.activeSelf)
            {
                Inv.SetActive(false);
            }
            else
            {                
                Inv.SetActive(true);
            }
        }
    }
    //void DropSelectedItem()
    //{
       // if (Input.GetKeyDown(DropItem) & IdSelectedItem != 0)
        //{
           // for (SelectedNumber = 0; SelectedNumber < ChildCount; SelectedNumber++)
           // {
                //if (Content.transform.GetChild(SelectedNumber).GetComponentInChildren<ItemDescription>().id == IdSelectedItem)
                //{
                   // DropEvent();
                   // IdSelectedItem = 0;

               // }
           // }


        //}
   // }
    //void DropEvent()
    //{
        //GameObject InstObj;
       // InstObj=Content.transform.GetChild(SelectedNumber).GetComponentInChildren<ItemDescription>().CorrespObj;
        //Transform Selected = Content.transform.GetChild(SelectedNumber);
       // Selected.gameObject.SetActive(false);
       // Instantiate(InstObj,Player.transform.position,Quaternion.identity);
    //}

    

}
