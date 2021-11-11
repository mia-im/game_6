using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1f);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1.2f, 1.2f, 1f);
        SceneManager.LoadScene("game");
    }
}
