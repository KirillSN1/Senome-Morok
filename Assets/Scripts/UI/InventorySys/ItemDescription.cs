using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class ItemDescription : MonoBehaviour
{
    [Multiline(15)]
    public string DDesc;
    public Inventory InvScript;
    private Text CurrentName;
    public Text DDItemName;
    public Text DDescription;
    public GameObject CorrespObj;
    private Item Links;
    public int id;
    


    private void Start()
    {
        CurrentName = gameObject.transform.GetChild(2).GetComponentInChildren<Text>();        
    }

    private void Update()
    {

    }



    public void ClickItemEvent()
    {
        InvScript.DDTitle.SetActive(true);
        InvScript.DText.SetActive(true);
        DDItemName.text = CurrentName.text;
        DDescription.text = DDesc;
        InvScript.IdSelectedItem = id;
    }
    
}

