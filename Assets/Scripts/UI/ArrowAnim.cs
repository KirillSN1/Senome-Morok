using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ArrowAnim : MonoBehaviour
{
   
    public float time = 0;
    [HideInInspector]
    public bool TimerOn = false;
    public float craftTime;
    public GameObject RecipeContent;

    private void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    private void Update()
    {
        Timer();
    }

    private void Timer()
    {
        
        if (TimerOn)
        {
            time = time + Time.fixedDeltaTime;
            GetComponent<Animator>().SetFloat("Speed", -1);
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (time >= craftTime)
        {
            time = default;
            TimerOn = false;
            GetComponent<Animator>().SetFloat("Speed", 0);
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
    public void bool_timer()
    {
        
        for(int i = 0; i < RecipeContent.transform.childCount; i++)
        {
            RecipeDescription Recipe = RecipeContent.transform.GetChild(i).GetComponent<RecipeDescription>();
            if (Recipe.Selected)
            {
                if (Recipe.eCount1 < Recipe.nCount1 && Recipe.eCount2 < Recipe.nCount2)
                {
                    Debug.Log("Мало ресурсов");
                }
                else if (Recipe.eCount1 >= Recipe.nCount1 && Recipe.eCount2 >= Recipe.nCount2)
                {
                    TimerOn = true;
                }
            }
        }
    }
}
