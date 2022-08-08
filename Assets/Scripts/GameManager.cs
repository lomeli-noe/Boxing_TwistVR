using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject targetPlanePrefab;
    private GameObject planeObject;
    public AudioSource audioSource;

    public ParticleSystem particleSystem;

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
        float angle = Random.Range(0.0f, Mathf.PI * 2);
        float range = 1f;
        Vector3 V = new Vector3(Mathf.Sin(angle), 1.3f, Mathf.Cos(angle));
        V *= range;

        planeObject = Instantiate(targetPlanePrefab, V, targetPlanePrefab.transform.rotation);
        planeObject.transform.LookAt(gameObject.transform, Vector3.forward);
    }

    public void TargetHit(Transform targetTransform)
    {
        count--;
        audioSource.Play(0);
        particleSystem.transform.position = targetTransform.position;
        particleSystem.Play();
    }
}
