using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour
{
    public float duration = 20f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            StartCoroutine(Boost(player));
            Destroy(gameObject);
        }
    }

    IEnumerator Boost(PlayerController player)
    {
        player.speed = 10f;
        player.jumpForce = 15f;

        yield return new WaitForSeconds(duration);

        player.speed = 6f;
        player.jumpForce = 10f;
    }
}