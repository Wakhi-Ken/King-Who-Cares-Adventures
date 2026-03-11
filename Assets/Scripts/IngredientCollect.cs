using UnityEngine;

public class IngredientCollect : MonoBehaviour
{
    public static int collected = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            collected++;
            Destroy(gameObject);
        }
    }
}