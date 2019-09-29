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
    public Text DItemName;
    public Text DDescription;
    public GameObject InteractObj;
    private Item Links;
    public int id;

    //UiCount
    public int currentCount;
    private Text TextC;



    private void Awake()
    {
        TextC = transform.GetChild(4).GetComponent<Text>();
        CurrentName = gameObject.transform.GetChild(2).GetComponentInChildren<Text>();        
    }

    private void Update()
    {
        TextC.text = currentCount.ToString();
    }



    public void ClickItemEvent()
    {
        InvScript.DDTitle.SetActive(true);
        InvScript.DText.SetActive(true);
        DItemName.text = CurrentName.text;
        DDescription.text = DDesc;
        InvScript.IdSelectedItem = id;
    }
    
}

