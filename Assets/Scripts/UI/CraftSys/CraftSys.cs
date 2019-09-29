using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftSys : MonoBehaviour
{
    
    
    public GameObject Content;
    public List<ItemDescription> Items = new List<ItemDescription>();
    public GameObject RecipeBook;

    void Start()
    {
        RecipeBook.SetActive(false);
    }


    void Update()
    {
        ActiveItem();
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (RecipeBook.activeInHierarchy == false)
            {
                RecipeBook.SetActive(true);
            }
            else RecipeBook.SetActive(false);
        }
    }

    public void ActiveItem()
    {
        for(int i=0; i<Content.transform.childCount; i++)
        {
            Items[i] = Content.transform.GetChild(i).gameObject.GetComponent<ItemDescription>();
            if (Items[i].currentCount <=0)
            {
                Items[i].gameObject.SetActive(false);
            }
            else
            if (Items[i].currentCount >= 0)
            {
                Items[i].gameObject.SetActive(true);
            }
        }

    }
    
}
