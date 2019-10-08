using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Disease;

public class charController : MonoBehaviour
{

    float HealthPoint;
    public List<DiseaseModel> DList = new List<DiseaseModel>();
    [Header("charMovement")]
    public Vector2 MVelos;
    public float Speed;
    private Rigidbody2D RigidB;
    private bool onCol;
    [Header("ObjSelect")]
    private GameObject Selected;

    void Start()
    {
        RigidB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
            
        
    }

    void FixedUpdate()
    {
        if (DList.Count>0)
        {
            Damage();
        }
        Vector2 MInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MVelos = MInput.normalized * Speed;
        RigidB.MovePosition(RigidB.position + MVelos * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        onCol = true;
        Selected = other.gameObject;
        if (Selected.tag == "NPC")
        {
            DiseaseModel diseas = Selected.GetComponent<NpcController>().OnActive();
            HealthPoint -= diseas.DegreeStep;
            DList.Add(diseas);
            Debug.Log(HealthPoint);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        onCol = false;         
    }

    void Damage()
    {
        Debug.Log(HealthPoint);
        DiseaseModel diseas = Selected.GetComponent<NpcController>().OnActive();
        foreach (var disease in DList)
        {
            HealthPoint -= diseas.DegreeSpeed * Time.fixedDeltaTime/100;
        }
    }




}
