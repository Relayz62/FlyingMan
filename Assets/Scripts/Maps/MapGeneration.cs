using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneration : MonoBehaviour
{
    public List<MapObjects> mapObjects = new List<MapObjects>();
    private int index=0;
    public GameObject MapPoint;
    private GameObject _instMap;
    [SerializeField] private ReloadZone _reloadZone;

    private void Start()
    {
        Generate();
    }
    private void OnEnable()
    {
        _reloadZone.OnMapGenerated += Generate;
        _reloadZone.OnMapClear += ClearMap;
    }
    private void OnDisable()
    {
        _reloadZone.OnMapGenerated -= Generate;
        _reloadZone.OnMapClear -= ClearMap;
    }
    public void Generate()
    {
        Debug.Log("Создал карту");
        Debug.Log(index);
        _instMap = Instantiate(mapObjects[index].mapsObject[0].gameObject, MapPoint.transform);
        index++;
        if (index == mapObjects.Count) index = 0;
    }

    public void ClearMap()
    {
        Debug.Log("Удалил карту");
        Destroy(_instMap);
    }

    
}
