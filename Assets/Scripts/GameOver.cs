using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void onCollisionEnter(Collision collision)
    {
        if(collision.fisherman.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
}
