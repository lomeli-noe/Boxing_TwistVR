using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public new ParticleSystem particleSystem;

    private void OnTriggerEnter(Collider other)
    {
        particleSystem.Play();
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * 600);
        Destroy(gameObject, .5f);
        GameManager.Instance.count--;
        GameManager.Instance.audioSource.clip = GameManager.Instance.audioClips[0];
        GameManager.Instance.audioSource.Play();
    }
}
