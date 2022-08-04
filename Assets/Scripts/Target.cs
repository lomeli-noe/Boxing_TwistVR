using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public new ParticleSystem particleSystem;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        particleSystem.Play();
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * 600);
        audioSource.Play();
        Destroy(gameObject, .5f);
    }
}
