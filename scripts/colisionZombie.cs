using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionZombie : MonoBehaviour
{
    public Animator animator; // Referencia al componente Animator
    private int fuerzaDelGoblin;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("estoy en colision");
        // Verifica si la colisión es con el objeto deseado
        if (collision.gameObject.CompareTag("goblin"))
        {
            GoblinMovement goblinComponent = collision.gameObject.GetComponent<GoblinMovement>();

            if (goblinComponent != null)
            {
                // Obtiene la fuerza del Goblin
                fuerzaDelGoblin = goblinComponent.fuerza;

                // Utiliza la fuerza del Goblin en el Zombie
                Debug.Log("Fuerza del Goblin: " + fuerzaDelGoblin);

                Zombie zombie = GetComponent<Zombie>();

                int vidaActual = zombie.restarVida(fuerzaDelGoblin);
                Debug.Log("me choco con vida " + vidaActual.ToString());
                // Aquí establecemos la variable "estamuerto" en true
           
           
                if (vidaActual <= 0)
                {
                    animator.SetBool("estoyMuerto", true);

                }
            }
        }
    }
    public void MetodoAlFinalDeLaAnimacion()
    {
        animator.SetBool("estoyMuerto", false);
        // Coloca aquí el código que deseas ejecutar al final de la animación.
    }
}
