using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}