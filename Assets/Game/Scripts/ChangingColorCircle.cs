using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColorCircle : MonoBehaviour
{
    [SerializeField] Color colorToChange;
    [SerializeField] MeshRenderer CircleRenderer;
    public Color ColorToChange
    {
        get
        {
            return colorToChange;
        }
        set
        {
            CircleRenderer.material.color = value;
            colorToChange = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out MainCharacter character))
        {
            character.CurrentColor = colorToChange;
        }
    }
}
