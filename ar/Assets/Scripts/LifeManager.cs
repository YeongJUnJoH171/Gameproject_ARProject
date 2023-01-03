using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    public bool GameOver = false;
    public int Life = 3;

    public TextMeshProUGUI LifeText = null;
    public GameObject GMUI;
    public GameObject BackButton;
    // Start is called before the first frame update
    void Start()
    {
        LifeText.text = "Life : 3";
    }
    public void SnowManHit()
    {
        Life -= 1;
        LifeText.text = "Life : " + Life.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        if (Life == 0)
        {
            GameOver = true;
            GMUI.SetActive(true);
            BackButton.SetActive(true);
        }
    }
}
