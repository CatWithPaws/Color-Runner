using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour,IPointerDownHandler
{
    public static System.Action OnGameStart;

    [SerializeField] bool asdasdasd;
    
     public void OnPointerDown(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        OnGameStart();
    }
}
