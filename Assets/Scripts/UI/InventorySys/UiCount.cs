using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class UiCount : MonoBehaviour
{
    public int Count;   
    private Text TextC;



    void Start()
    {
        TextC=GetComponent<Text>();
    }

    
    void Update()
    {
        TextC.text = Count.ToString();
    }
}
