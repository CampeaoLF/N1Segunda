using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int currentLife = 100; //vida atual 
    public TextMeshProUGUI life;  // mostra a vida na hud
    private int damage = -5;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            currentLife--;
        }
    }

    void Start()
    {
        life.text = "Vida: 100";
    }

    // Update is called once per frame
    void Update()
    {

        if (currentLife <= 0)
        {
            SceneManager.LoadScene("Perdeu");
        }

       
    }
}
