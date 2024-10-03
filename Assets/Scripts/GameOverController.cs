using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;  // Make sure to include the TextMeshPro namespace

public class GameOverController : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;

    public void Start()
    {
        gameOverPanel.SetActive(true);
        if (GameManager.Instance)
        {
            scoreText.text = "Score: " + GameManager.Instance.score.ToString();
        }

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
