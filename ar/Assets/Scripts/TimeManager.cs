using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    private float time = 0.0f;
    private int min = 0;
    private int sec = 0;

    public TextMeshProUGUI timetext = null;

    void Update()
    {
        time += Time.deltaTime;
        min = (int)(time / 60);
        sec = (int)(time - (min * 60));

        timetext.text = min.ToString() + " : " + sec.ToString();
    }
}
