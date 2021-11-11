using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePanelOpen : MonoBehaviour
{
    void OnTriggerEnter2D ()
    {
        Camera.main.GetComponent<UIManager>().Lose();
        Time.timeScale = 0;
    }
}
