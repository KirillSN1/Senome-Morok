using UnityEngine;
using System.Linq;


public class NpcController : MonoBehaviour
{
    public Disease disease;

    private void Awake()
    {
        var diseaseList = GetComponent<Disease>().List();
        var id = Random.Range(diseaseList.First().Id, diseaseList.Last().Id + 1);
        disease = diseaseList.Single(x => x.Id == id);
    }

    public Disease OnActive()
    {
        return disease;
    }
}
