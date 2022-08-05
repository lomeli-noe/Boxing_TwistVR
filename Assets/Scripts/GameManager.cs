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
        CreateTargetPlane();
    }

    // Update is called once per frame
    void Update()
    {
        if(count == 0)
        {
            Destroy(planeObject);
        }
    }

    public void CreateTargetPlane()
    {
        Vector3 random = new Vector3(Mathf.Sin(Random.Range(0, 360) * Mathf.Deg2Rad), 0, Mathf.Cos(Random.Range(0, 360) * Mathf.Deg2Rad));
        Vector3 randomPosition = gameObject.transform.position + random;

        planeObject = Instantiate(targetPlanePrefab, randomPosition, targetPlanePrefab.transform.rotation);
        planeObject.transform.LookAt(gameObject.transform, Vector3.forward);

    }
}
