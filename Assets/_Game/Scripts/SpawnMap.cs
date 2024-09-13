using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    public GameObject prefab;
    public Transform pointSpawn;
    private Vector3 point;
    private void Start()
    {
        point = pointSpawn.position;
    }

    public void Swpan()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject newObj = Instantiate(prefab);
            newObj.transform.position = point;
            point += new Vector3(0, 0, 50);
        }


    }
}
