using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public SpawnDiamondBom spawnDiamondBom;
    public SpawnMap spawnMap;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            transform.position += new Vector3(0, 0,10f);
            spawnDiamondBom.Swpan();
            spawnMap.Swpan();
        }
    }
}
