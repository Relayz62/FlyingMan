using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New StoreObject", menuName = "Store/StoreObject")]
public class StoreEntity : ScriptableObject
{
    public Sprite Icon;
    public new string name;
    public int save = 0;
    public GameObject Model;
    public enum Accses { Locked, Opened }
    public Accses accsesType; 
}
