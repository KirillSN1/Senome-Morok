using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSpawn : MonoBehaviour
{
    [Header("Random Spawn")]
    public List<GameObject> itemObj = new List<GameObject>();
    private int index;
    private float randomInt;
    [Header("Timer")]
    private float timer;
    private bool on=false;

    void Start()
    {
        randomInt = Random.Range(0, itemObj.Count);
        index = Mathf.RoundToInt(randomInt);
        Instantiate(itemObj[index], transform.position, Quaternion.identity);      
    }

    private void FixedUpdate()
    {
        
    }
}
