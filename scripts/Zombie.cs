using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int vida = 100;
    public int restarVida(int cantidad)
    {
        vida = vida - cantidad;
        return vida;
    }
}
