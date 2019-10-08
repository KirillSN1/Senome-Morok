using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DesiaseClass {
    public static List<Desiase> ListDesiase = new List<Desiase>()
    {
        new Desiase(1, "1", 1, 5),
        new Desiase(2, "2", 2, 10),
        new Desiase(3, "3", 3, 20),
        new Desiase(4, "4", 5, 40)
    };
}

public struct Desiase
{
    public int id;
    public string name;
    public int HPTeak;
    public int HPAction;
    public Desiase(int id, string name, int HPTeak, int HPAction)
    {
        this.id = id;
        this.name = name;
        this.HPTeak = HPTeak;
        this.HPAction = HPAction;
    }
}