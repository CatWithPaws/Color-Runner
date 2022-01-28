using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUI : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;

    void Start()
    {
        MainCharacter.OnWin += () => { WinPanel.SetActive(true); };
    }
    public void WinButtClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
