using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Firefireball : MonoBehaviour
{
    public GameObject Fireball_red;
    public GameObject Fireball_blue;
    public GameObject Fireball_turquoise;

    private ChooseManager choosemanager = null;
    private LifeManager lifemanager = null;

    public Transform arCamera;
    private float power = 30.0f;

    void Start()
    {
        GameObject cmObject = GameObject.Find("ChooseManager");
        choosemanager = cmObject.GetComponent<ChooseManager>();

        GameObject lmObject = GameObject.Find("LifeManager");
        lifemanager = lmObject.GetComponent<LifeManager>();
    }

    void Update()
    {
        if (lifemanager.GameOver == true)
            return;

        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began)
            return;

        if (choosemanager.Fire_red == false && choosemanager.Fire_blue == false && choosemanager.Fire_tur == false)
            return;

        if (choosemanager.Fire_red == true)
        {
            GameObject fireball_red = Instantiate(Fireball_red, arCamera.position, arCamera.rotation) as GameObject;
            fireball_red.GetComponent<Rigidbody>().velocity = (arCamera.forward * power);
        }
        else if (choosemanager.Fire_blue == true)
        {
            GameObject fireball_blue = Instantiate(Fireball_blue, arCamera.position, arCamera.rotation) as GameObject;
            fireball_blue.GetComponent<Rigidbody>().velocity = (arCamera.forward * power);
        }
        else if (choosemanager.Fire_tur == true)
        {
            GameObject fireball_tur = Instantiate(Fireball_turquoise, arCamera.position, arCamera.rotation) as GameObject;
            fireball_tur.GetComponent<Rigidbody>().velocity = (arCamera.forward * power);
        }
    }
}