using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseManager : MonoBehaviour
{
    public bool Fire_red = false;
    public bool Fire_blue = false;
    public bool Fire_tur = false;

    public void Choose_Red()
    {
        Fire_red = true;
        Fire_blue = false;
        Fire_tur = false;
    }

    public void Choose_Blue()
    {
        Fire_red = false;
        Fire_blue = true;
        Fire_tur = false;
    }

    public void Choose_Turquoise()
    {
        Fire_red = false;
        Fire_blue = false;
        Fire_tur = true;
    }
}
