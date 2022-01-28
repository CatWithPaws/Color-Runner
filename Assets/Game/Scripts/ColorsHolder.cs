using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsHolder : MonoBehaviour
{
    public static ColorsHolder instance;

    public static Dictionary<Color,Material> ColorsList = new Dictionary<Color,Material>();

    private void Start()
    {
        instance = this;

        ColorsList[Color.red] = Resources.Load("Material/Red") as Material;
        ColorsList[Color.green] = Resources.Load("Material/Green") as Material;
        ColorsList[Color.blue] = Resources.Load("Material/Blue") as Material;
    }
}
