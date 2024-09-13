using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomController : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particleSystemBom;
    [SerializeField]
    private ParticleSystem particleSystemFire;
    private MeshRenderer meshRenderer;
    
    [SerializeField]
    private GameObject Boom;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
        particleSystemBom.Stop();
        particleSystemFire.Play();
    }
    public void ActionBoom(){
        particleSystemBom.Play();
        particleSystemFire.Stop();
        meshRenderer.enabled = false;
        Invoke(nameof(DestroyBoom),0.5f);
    }
    
    public void DestroyBoom(){
        Destroy(gameObject);
    }
}
