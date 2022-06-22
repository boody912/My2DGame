using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {
                //SceneManager.LoadScene(1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
                      
        }

    }
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");

    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

}
