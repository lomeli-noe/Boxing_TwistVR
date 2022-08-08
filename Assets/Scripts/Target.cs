using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public LayerMask layerMask;
    

    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.TargetHit(gameObject.transform);
        Destroy(gameObject);
    }
}
