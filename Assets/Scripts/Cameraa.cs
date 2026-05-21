using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cameraa : MonoBehaviour
{
    [SerializeField] private Transform target; // Ac� en vez de un GameObject entero, seleccionamos el componente Transform de un GameObject para poder manipularlo
    [SerializeField] private float smooth; // Variable que vamos a utilizar luego programar un movimiento de c�mara m�s suave
    [SerializeField] private Vector3 offset; // Debe coincidir el valor Z del c�digo con el valor Z del Transform de la c�mara


    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smooth);
        transform.position = smoothedPosition;
    }
}
