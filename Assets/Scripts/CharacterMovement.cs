using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float velocidad = 5f;
    private Vector3 direccionMovimiento;

    public Animator animator; // Asigna el Animator en el inspector

    void Update()
    {
        direccionMovimiento = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            direccionMovimiento = Vector3.left;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            animator.SetBool("CanDance", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            direccionMovimiento = Vector3.right;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("CanDance", false);
        }
    if (Input.GetKeyDown(KeyCode.Alpha1) && direccionMovimiento == Vector3.zero)
    {
    Debug.Log("El jugador presionó 1 y está quieto");
    animator.SetBool("CanDance", true);
    }
        // Activar animación solo si se está moviendo
        bool estaCaminando = direccionMovimiento != Vector3.zero;
        animator.SetBool("IsWalKing", estaCaminando);

        // Mover al personaje
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime, Space.World);
    }
}