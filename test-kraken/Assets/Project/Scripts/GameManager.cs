using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public int totalCoins = 5;
    private void Awake()
    {
        if (instance != null && instance != this) 
        {
            Destroy(gameObject);
            return;
        }
        instance = this;

        DontDestroyOnLoad(gameObject);

    }
    public void AddScorePoint(int points)
    {
        score += points;
        Debug.Log($"Score: {score}");
    }
    private void Update()
    {
        if (score == totalCoins)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
