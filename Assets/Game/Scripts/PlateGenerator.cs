using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateGenerator : MonoBehaviour
{
    
    
    
    [SerializeField] GameObject[] prefabs;
    [SerializeField] GameObject endLevelPlatform;
    [SerializeField] float PlateScale;
    [SerializeField] Transform startPlatePos;
    private int plateCount = 0;

    private int level;
    private int startPlateCount = 5;
    private int plateCountInLvl;
    
    private void Awake()
    {
        plateCountInLvl = startPlateCount + (3 * level);
        PlateScale = prefabs[0].transform.localScale.z;
        GeneratePlates();
    }

    private void GeneratePlates()
    {
        for(int i = 0; i < plateCountInLvl; i++)
        {
            GeneratePlate();
        }
        GameObject.Instantiate(endLevelPlatform, startPlatePos.position + (Vector3.forward * PlateScale * (plateCountInLvl) + (Vector3.forward * PlateScale * 0.6f)), Quaternion.Euler(0, 180, 0));
        plateCount++;
    }

    private void GeneratePlate()
    {
        GameObject randomPrefab = prefabs[Random.Range(0,prefabs.Length-1)];
        GameObject.Instantiate(randomPrefab, startPlatePos.position + (Vector3.forward * PlateScale * (plateCount + 1)), Quaternion.Euler(0,180,0));
        plateCount++;
    }

}
