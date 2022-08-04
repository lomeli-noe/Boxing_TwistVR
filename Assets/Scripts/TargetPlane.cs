using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlane : MonoBehaviour
{

    public Target[] targets;

    // Start is called before the first frame update
    void Start()
    {
        targets = FindObjectsOfType<Target>();
        for(int i = 0; i < targets.Length; i++)
        {
            int num = UnityEngine.Random.Range(0, 2);
            targets[i].gameObject.SetActive(Convert.ToBoolean(num));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
