using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Map Objects Zone", menuName = "Map/ObjectsZone")]
public class MapObjects : ScriptableObject
{
    new public string name = "Object Zone";
    public List<GameObject> mapsObject = new List<GameObject>();
}
