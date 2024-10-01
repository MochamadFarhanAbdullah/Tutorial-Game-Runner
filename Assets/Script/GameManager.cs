using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject winPanel;
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        // Menghentikan waktu jika diperlukan
        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        // Menghentikan game
        Time.timeScale = 0f;

        // Menampilkan Win Panel
        winPanel.SetActive(true);
    }
    public void RestartGame()
    {
        // Muat ulang scene saat ini
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Mengembalikan waktu ke normal
        Time.timeScale = 1f;
    }
    public void ReturnToMainMenu()
    {
        // Mengembalikan waktu ke normal
        Time.timeScale = 0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
