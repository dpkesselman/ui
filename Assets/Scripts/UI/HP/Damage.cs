using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<HP>().TakeDamage(20);
        }
    }

}
