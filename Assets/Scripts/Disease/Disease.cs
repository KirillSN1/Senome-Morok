using System.Collections.Generic;
using UnityEngine;


public class Disease : MonoBehaviour
{
    public int Id;
    public string Name;
    public int HpTeak;
    public int HpAction;

    public Disease(int id, string name, int HPTeak, int HPAction)
    {
        Id = id;
        Name = name;
        HpTeak = HPTeak;
        HpAction = HPAction;
    }

    public ICollection<Disease> List()
    {
        return new List<Disease>
        {
            new Disease(1, "1", 1, 5),
            new Disease(2, "2", 2, 10),
            new Disease(3, "3", 3, 20),
            new Disease(4, "4", 5, 40)
        };
    }
}