using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlane : MonoBehaviour
{

    public Target[] targets;
    protected int targetCount;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.count = 0;
        targetCount = 0;
        targets = gameObject.GetComponentsInChildren<Target>();
        
        for(int i = 0; i < targets.Length; i++)
        {
            int num = UnityEngine.Random.Range(0, 2);
            targets[i].gameObject.SetActive(Convert.ToBoolean(num));
            if(num == 1)
            {
                targetCount++;
            }
        }        
        GameManager.Instance.count = targetCount;
        audioSource.Play(0);
    }
}
