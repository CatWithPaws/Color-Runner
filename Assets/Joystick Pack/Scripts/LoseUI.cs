using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseUI : MonoBehaviour
{
    [SerializeField] private GameObject LosePanel;
    private void Start()
    {
        MainCharacter.OnLoose += () => { LosePanel.SetActive(true); };
    }

    public void LoseButtClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
