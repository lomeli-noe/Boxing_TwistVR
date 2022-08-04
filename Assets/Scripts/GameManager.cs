using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : TargetPlane
{
    public static GameManager Instance;
    public GameObject targetPlanePrefab;
    private GameObject planeObject;
    public int count;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        planeObject = Instantiate(targetPlanePrefab, gameObject.transform);
        Debug.Log(count);
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            Destroy(planeObject);
        }
    }
}
