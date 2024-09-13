using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem particleSystem;
    private Rigidbody rb;
    [SerializeField]
    private float speed;
    private float speedUp;
    private void Start()
    {
        particleSystem.Stop();
        rb = GetComponent<Rigidbody>();
        speedUp = 2f;
    }
    private void Update()
    {
        speedUp+= Time.deltaTime*0.1f;
        speed += Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontal*speed, 0, speedUp).normalized;
        rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Diamond"))
        {
            particleSystem.Play();
            Destroy(other.gameObject);
            UIManager.Instance.UpdateScore(1);
        }
        if (other.CompareTag("Boom"))
        {
            other.GetComponent<BoomController>().ActionBoom();            
        }
    }


    private IEnumerator MyCo(GameObject obj)
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(obj);
    }
}
