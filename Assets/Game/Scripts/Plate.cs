using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] Character[] secondaryCharList1;
    [SerializeField] Character[] secondaryCharList2;
    [SerializeField] Character[] mainCharList;

    [SerializeField] ChangingColorCircle circleOfChangingColor;

    List<Color> colors = new List<Color>();



    private void Start()
    {
        colors.Add(Color.red);
        colors.Add(Color.green);
        colors.Add(Color.blue);

        int colorIndex = Random.Range(0, colors.Count);

        Color tempColor = colors[colorIndex];
        
        colors.Remove(colors[colorIndex]);
        foreach (Character character in mainCharList)
        {
            character.CurrentColor = tempColor;
        }
        circleOfChangingColor.ColorToChange = tempColor;

        colorIndex = Random.Range(0, colors.Count);
        tempColor = colors[colorIndex];
        colors.Remove(tempColor);
        foreach (Character character in secondaryCharList1)
        {
            character.CurrentColor = tempColor;
        }
       
        colorIndex = Random.Range(0, colors.Count);
        tempColor = colors[colorIndex];
        foreach (Character character in secondaryCharList2)
        {
            character.CurrentColor = tempColor;
            
        }
    }
}
