using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Player Life")]
    public int playerLives = 3;
    public Text livesText;

    [Header("Ingredients")]
    public int totalIngredients;
    public int collectedIngredients;
    public Text ingredientText;

    void Awake()
    {
        // Singleton so other scripts can access GameManager
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        UpdateUI();
    }

    // Called when player takes damage
    public void LoseLife()
    {
        playerLives--;

        if (playerLives <= 0)
        {
            GameOver();
        }

        UpdateUI();
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    // Called when ingredient is collected
    public void CollectIngredient()
    {
        collectedIngredients++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (livesText != null)
            livesText.text = "Lives: " + playerLives;

        if (ingredientText != null)
            ingredientText.text = "Ingredients: " + (totalIngredients - collectedIngredients);
    }
}