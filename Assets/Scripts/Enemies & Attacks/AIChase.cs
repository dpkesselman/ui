using UnityEngine;


public class AIChase : MonoBehaviour
{
    public GameObject target; //Acá ponen el personaje que quieren que sea perseguido
    [SerializeField] private float speed; //La velocidad que va a tener el npc que nos va a perseguir
    //No se olviden de asignar los datos en el inspector!!
    private Rigidbody2D rb;
    [SerializeField] private float distanceBetween; //A qué distancia entre el target y el npc queremos que el npc se empiece a mover
    private float distance;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position); //Acá setteamos la variable distance
        Vector2 direction = target.transform.position - transform.position;
        direction.Normalize();


        if (distance < distanceBetween) //Acá indicamos que para que el npc empiece a moverse la distancia entre ambos objetos tiene que ser menor a la indicada en distanceBetween
        {
            rb.transform.position = Vector2.MoveTowards(this.rb.transform.position, target.transform.position, speed * Time.deltaTime);
        }
       
    }
}
