using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject targetPlanePrefab;
    private GameObject planeObject;
    public AudioSource audioSource;

    public int count;

    public float timeRemaining = 5;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            CreateTargetPlane();
        }
    }

    void Update()
    {
        if (timeRemaining < 0 || count == 0)
        {
            Destroy(planeObject);
            CreateTargetPlane();
            timeRemaining = 5;
        }
        else
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    public void CreateTargetPlane()
    {
        Vector3 random = new Vector3(Mathf.Sin(Random.Range(0, 360) * Mathf.Deg2Rad), 0, Mathf.Cos(Random.Range(0, 360) * Mathf.Deg2Rad));
        Vector3 randomPosition = gameObject.transform.position + random;

        planeObject = Instantiate(targetPlanePrefab, randomPosition, targetPlanePrefab.transform.rotation);
        planeObject.transform.LookAt(gameObject.transform, Vector3.forward);
    }

    public void TargetHit()
    {
        count--;
        audioSource.Play(0);
    }
}
