using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController Player;
    public float levelRestartDelay = 2f;

    private void Start()
    {
        Player = GetComponent<PlayerController>();       
    }
    public void EndGame()
    {
        Player.enabled = false;
        Invoke("RestartLevel", levelRestartDelay);
        Debug.Log("over game");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
