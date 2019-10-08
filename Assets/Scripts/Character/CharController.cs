using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    public float healthPoint;
    public List<Disease> diseaseList;
    private Vector2 _moveVelocity;
    public float speed;
    private Rigidbody2D _rb;
    private bool _onCol;
    [Header("ObjSelect")] private GameObject Selected;

    void Start()
    {
        diseaseList = new List<Disease>();
        _rb = GetComponent<Rigidbody2D>();
        healthPoint = 100;
    }

    private void Update()
    {
    }

    void FixedUpdate()
    {
        if (diseaseList.Count > 0)
        {
            Damage();
        }

        Vector2 MInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _moveVelocity = MInput.normalized * speed;
        _rb.MovePosition(_rb.position + _moveVelocity * Time.fixedDeltaTime);
        if (Selected)
        {
           if(Input.GetKeyDown(KeyCode.E)) 
               OnSelect();
        }
    }

    private void OnSelect()
    {
        if (Selected.tag.Equals("Npc"))
        {
            Disease diseas = Selected.GetComponent<NpcController>().OnActive();
            healthPoint -= diseas.HpAction;
            diseaseList.Add(diseas);
        }
        if (Selected.tag.Equals("Item"))
        {
            Selected.GetComponent<Item>().OnActive();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _onCol = true;
        Selected = other.gameObject;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _onCol = false;
        Selected = null;
    }

    void Damage()
    {
        Debug.Log(healthPoint);
        foreach (var disease in diseaseList)
        {
            healthPoint -= disease.HpTeak * Time.fixedDeltaTime / 100;
        }
    }
}