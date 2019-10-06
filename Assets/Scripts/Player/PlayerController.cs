using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
		if (Input.GetKey(KeyCode.A))
        {
			WalkLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
			WalkRight();
        }
    }
	
	void WalkLeft()
	{
		transform.localScale = new Vector3(-1, 1, 1);
		transform.Translate(Vector2.left * Time.deltaTime);
	}
	
	void WalkRight()
	{
		transform.localScale = new Vector3(1, 1, 1);
		transform.Translate(Vector2.right * Time.deltaTime);
	}
}
