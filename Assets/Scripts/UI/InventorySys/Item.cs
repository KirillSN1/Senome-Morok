using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string ItemName;
    public int id;
    public bool Stackable;
    [Header("Колличество предметов в стаке")]
    public int ItemCount;

    [Multiline(6),Header("Описание предмета")]
    public string Description;
    [Header("Путь к префабу предмета и его иконке")]
    public string iconPath;
    public string PrefabPath;
}
