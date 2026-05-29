using UnityEngine;

public class Heal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<HP>().Heal(20);
        }
    }
}

