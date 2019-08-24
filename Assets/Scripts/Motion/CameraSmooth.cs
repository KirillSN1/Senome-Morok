using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmooth : MonoBehaviour
{

    public float zAx;
    public float offset;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 EndPos= new Vector3(player.transform.position.x, player.transform.position.y, zAx);
        Vector3 StartPos = transform.position;
        transform.position = Vector3.Lerp(StartPos, EndPos, Time.fixedDeltaTime*offset);
    }
}
