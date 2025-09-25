using UnityEngine;

public class Dano : MonoBehaviour
{
    public  int currentLife = 100; //vida atual 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            currentLife--;
        }
    }
}
