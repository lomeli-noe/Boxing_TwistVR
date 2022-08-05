using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPlane : MonoBehaviour
{

    public Target[] targets;
    protected int targetCount;

    // Start is called before the first frame update
    void Awake()
    {
        targets = FindObjectsOfType<Target>();
        for(int i = 0; i < targets.Length; i++)
        {
            int num = UnityEngine.Random.Range(0, 2);
            targets[i].gameObject.SetActive(Convert.ToBoolean(num));
            if(num == 1)
            {
                targetCount++;
            }
        }
    }

    private void Start()
    {
        GameManager.Instance.count = targetCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
