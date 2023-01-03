using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRespone : MonoBehaviour
{
    public GameObject[] prefabs;
    float time = 0.0f;
    private List<GameObject> gameObject = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 1.0)
        {
            Spawn();
            time = 0.0f;
        }

    }

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance); // 관리
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;
        
        label:
            float posX = Random.Range(-60, 60);
            float posY = Random.Range(-10, 30);
            float posZ = Random.Range(-60, 60);

        if(Mathf.Sqrt(Mathf.Pow(posX, 2)+Mathf.Pow(posY, 2) + Mathf.Pow(posZ,2)) < 30)
        {
            goto label;
        }

        else
        {
            Vector3 spawnPos = new Vector3(posX, posY, posZ);
            return spawnPos;
        }

        
    }
}
