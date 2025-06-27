using UnityEngine;

public class CanoScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreScript.instance.IncreaseScore();
        }
    }
}
