using UnityEngine;


public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    [SerializeField] private float speed;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointA.transform;
    }


    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == pointA.transform)
        {
            rb.linearVelocity = new Vector2(0, speed);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, -speed);
        }


        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }


        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);
    }

}
