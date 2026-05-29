using UnityEngine;

public class RemovePoints : MonoBehaviour
{
    public int pointsToRemove;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            PointSytem.Instance.RemovingPoints(pointsToRemove);
        }
    }

}
