using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanelOpen : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        Camera.main.GetComponent<UIManager>().Win();
        Time.timeScale = 0;
    }
}
