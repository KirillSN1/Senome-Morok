using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Disease;
using System.Linq;


public class NpcController : MonoBehaviour
{
    public DiseaseModel disease;

    private void Awake()
    {
        var diseaseList = GetComponent<DiseaseList>().List();
        var id = Random.Range(1, 4);
        disease = diseaseList.Single(x => x.Id == id);
    }
    public DiseaseModel OnActive()
    {
        return disease;
    }
    
    
}
