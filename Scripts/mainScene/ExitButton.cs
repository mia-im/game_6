using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{

    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1f);
    }

    void OnMouseUp()
    {
        GetComponent<Image>().color = new Color32(94, 147, 183, 255);
        transform.localScale = new Vector3(1.2f, 1.2f, 1f);        
        Application.Quit();    // закрыть приложение
    }
}
