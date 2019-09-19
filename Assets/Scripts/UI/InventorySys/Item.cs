﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Item : MonoBehaviour
{
    //public bool RandomCount=false;

    //[Range(0,15)]
    //public int minCount;
    //[Range(2,30)]
    //public int maxCount;

    //private int PCount;
    public int PCount;
    public string ObjName;
    public string Description;
    public KeyCode CollectButton;
    public string id;
    private Sprite Sprite1;
    [Header("Вспомогательные переменные")]
    public GameObject CellObj;
    public GameObject NameObj;
    public GameObject DescObj;
    public UiCount CountObj;
    public GameObject IconObj;



    private Text Name;
    private Text Desc;
    private Image Icon;
    private GameObject InvObj;

    private bool collisionBool=false;
    
    

    private void Awake()
    {   
        Sprite1 = Resources.Load<Sprite>("Icons/Item"+id);
        Name = NameObj.GetComponent<Text>();
        Desc = DescObj.GetComponent<Text>();
        Icon = IconObj.GetComponent<Image>();
    }
    private void Update()
    {
        UpdateCollision();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collisionBool = true;
                
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collisionBool = false;
    }

    void UpdateCollision()
    {
        if (collisionBool)
        {
            if (Input.GetKeyDown(CollectButton))
            {
                Destroy(gameObject);
                CellObj.SetActive(true);
                Name.text = ObjName;
                Desc.text = Description;
                CountObj.Count = CountObj.Count + PCount;
                Icon.sprite = Sprite1;
                
            }
        }
    }





}
