using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSnowMan : MonoBehaviour
{
    public GameObject TargetPosition;
    float speed = 2.0f;
    float time = 0.0f;

    private LifeManager lifemanager = null;

    void Start()
    {

        GameObject lmObject = GameObject.Find("LifeManager");
        lifemanager = lmObject.GetComponent<LifeManager>();

       
    }

    void Update()
    {
        time += Time.deltaTime; 
        if(time > 60.0f)
        {
            speed = 4.0f;
        }
        else if(time > 180.0f)
        {
            speed = 6.0f;
        }

        transform.LookAt(TargetPosition.transform);
        transform.position += transform.forward * Time.deltaTime * speed;

        if(Mathf.Sqrt(Mathf.Pow(transform.position.x, 2) + Mathf.Pow(transform.position.y, 2) + Mathf.Pow(transform.position.z, 2)) < 5)
        {
            lifemanager.SnowManHit();   
            Destroy(gameObject);  
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
            Destroy(gameObject);
    }
}
