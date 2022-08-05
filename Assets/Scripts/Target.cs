using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public LayerMask layerMask;
    

    private void OnTriggerEnter(Collider other)
    {
        if (((1 << other.gameObject.layer) & layerMask) != 0)
        {
            GameManager.Instance.TargetHit(gameObject.transform);
            Destroy(gameObject);
        }
    }
}
