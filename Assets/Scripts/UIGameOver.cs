using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIGameOver : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
        Debug.Log("Lose");
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
