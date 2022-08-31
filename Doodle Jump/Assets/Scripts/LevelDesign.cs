using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesign : MonoBehaviour
{
    public GameObject platformPrefabs;
    [SerializeField] int platformSayisi;


    
    void Start()
    {
        LevelUret();
    }


    void LevelUret()
    {
        Vector2 platformVektor = new Vector2();
        for (int i = 0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefabs);
            platformVektor.x = Random.Range(-2f, 2f);
            platformVektor.y += Random.Range(1.3f, 1.6f);
            tempPlatform.transform.position = platformVektor;
        }
    }

}
