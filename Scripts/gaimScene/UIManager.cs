using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject PanelWin;
    [SerializeField] private GameObject PanelLose;

    public void Win()
    {
        PanelWin.SetActive(true);
    }

    public void Lose()
    {
        PanelLose.SetActive(true);
    }

    public void Back()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("main");
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
