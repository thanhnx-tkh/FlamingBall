using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiamondBom : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform pointSpawn;
    private Vector3 point;
    private void Start()
    {
        float index1 = Random.Range(5, 10);
        float index2 = Random.Range(-3, 3);
        point = pointSpawn.position + new Vector3(index2, 0, index1);
    }

    public void Swpan()
    {

        for (int i = 0; i < 10; i++)
        {
            int index = Random.Range(0, prefabs.Length);
            GameObject newObj = Instantiate(prefabs[index]);
            newObj.transform.position = point;

            float index1 = Random.Range(0, 10);
            float index2 = Random.Range(-3, 3);
            point = new Vector3(0, 0, point.z);
            point += new Vector3(index2, 0, index1);
        }


    }
}
