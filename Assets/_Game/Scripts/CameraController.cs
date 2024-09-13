using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offSet;
    [SerializeField]
    private PlayerController playerController;
    private void Start() {
        offSet = transform.position - playerController.transform.position;
    }

    private void LateUpdate() {
        transform.position = playerController.transform.position + offSet;
    }

   
}
