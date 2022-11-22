using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController movement;
    public float levelRestartDelay = 2f;

    private void Start()
    {
        movement = GetComponent<PlayerController>();
    }
    public void EndGame()
    {
        movement.enabled = false;
        Invoke("RestartLevel", levelRestartDelay);
        Debug.Log("over game");
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
