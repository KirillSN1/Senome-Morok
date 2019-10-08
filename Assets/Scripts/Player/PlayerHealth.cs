using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	int currentHP = 100;
	int maxHP = 100;
	bool inBed = false; //находимя ли на кровати
	bool recovery = false; //восстановление жизни
	
	public Image HPBar;
	
    void Start()
    {
		InvokeRepeating("ChangeHP", 0, 1);
    }
	
	void Update()
	{
		if (inBed && Input.GetKeyDown(KeyCode.E))
		{
			recovery = !recovery;
		}
	}
	
	void ChangeHP()
	{
		if(recovery)
		{
			currentHP += 10;
			if(currentHP > maxHP) currentHP = maxHP;
		}
		else
		{
			--currentHP;
		}
		HPBar.fillAmount = (float)currentHP / (float) maxHP;
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Bed"))
		{
			inBed = true;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Bed"))
		{
			inBed = false;
			recovery = false;
		}
	}
}
