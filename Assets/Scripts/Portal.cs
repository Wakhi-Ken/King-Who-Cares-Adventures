using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int requiredIngredients = 5;
    public string nextLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (IngredientCollect.collected >= requiredIngredients)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}