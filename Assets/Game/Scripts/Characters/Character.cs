using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Color currentColor;

    public Color CurrentColor 
    {
        get
        {
            return currentColor;
        }
        set
        {
            GetComponent<MeshRenderer>().material.color = value;
            currentColor = value;
        }
    }
}
