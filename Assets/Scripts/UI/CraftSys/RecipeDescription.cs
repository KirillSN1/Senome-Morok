using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class RecipeDescription : MonoBehaviour
{
    [Header("Описание рецепта (UI)")]
    public Item InteractObj;
    public Sprite image;
    public int id;
    [Header("Детальное описание")]
    public string Name;
    [Multiline(5)]
    public string DDesc;
    public Text DItemName;
    public Text DDescription;
    public GameObject DDescriptionObj;
    public GameObject BG_ItemName;
    
    [Header("Ссылка на предмет рецепта и количество получаемого матер.")]
    public ItemDescription _0;
    public int nCount0;

    [Header("Требуемые ресурсы и их кол-во.")]
    public int id1;
    public int id2;
    public Item InteractObj1;
    public Item InteractObj2;
    [Space]
    [Space]
    [Space]
    public ItemDescription _1;
    public int nCount1;
    public ItemDescription _2;
    public int nCount2;
    private int eCount1;
    private int eCount2;
    
    
    
    
    [Header("Вывод трубуемых ресурсов в описание")]
    public GameObject First;
    public GameObject Second;
    [Header("Контейнер инвентаря")]
    public GameObject ContentObj;


    [Header("Вспомогательные переменные")]
    public Text ItemName;
    public Text ItemDescription;
    public Image ItemIcon;
    
    

    private void Start()
    {
        BG_ItemName.SetActive(false);
        DDescriptionObj.SetActive(false);
        ItemName.text = Name;
        ItemDescription.text = InteractObj.Description;
        ItemIcon.sprite = image;
        
    }

    private void Update()
    {
        eCount1 = _1.currentCount;
        eCount2 = _2.currentCount;
        First.transform.GetChild(2).GetComponent<Text>().text = (eCount1 + "/" + nCount1);
        Second.transform.GetChild(2).GetComponent<Text>().text = (eCount2 + "/" + nCount2);
        if (eCount1 < nCount1)
        {
            First.transform.GetChild(2).GetComponent<Text>().color = Color.red;
        }
        else First.transform.GetChild(2).GetComponent<Text>().color=Color.black;
        if (eCount2 < nCount2)
        {
            Second.transform.GetChild(2).GetComponent<Text>().color = Color.red;
        }
        else Second.transform.GetChild(2).GetComponent<Text>().color = Color.black;
    }










    public void OnClickButton()
    {
        if (_1.currentCount >= nCount1 && _2.currentCount >= nCount2)
        {
            _1.currentCount = _1.currentCount - nCount1;
            _2.currentCount = _2.currentCount - nCount2;
            _0.currentCount = _0.currentCount + nCount0;
        }
    }

    public void ClickItemEvent()
    {
        DDescriptionObj.SetActive(true);
        BG_ItemName.SetActive(true);
        DItemName.text=Name;
        DDescription.text = DDesc;
        First.transform.GetChild(0).GetComponent<Text>().text = InteractObj1.ObjName;
        Second.transform.GetChild(0).GetComponent<Text>().text = InteractObj2.ObjName;
        First.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/Item" + id1);
        Second.transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/Item" + id2);
        
    }
}
