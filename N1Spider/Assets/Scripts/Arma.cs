using UnityEngine;

public class Arma : MonoBehaviour
{
    public GameObject bala;  // munição da arma;
    public Transform arma;  // posiçao do tiro;
    private bool tiro;     // Input do tiro;
    [SerializeField] private float forçaTiro;   // Velocidade da bala
    public float direcaoBala ;
       
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiro = Input.touchCount > 0;
        Atirar();
    }

    private void Atirar()
    {
        if(tiro == true)
        {
            GameObject temp = Instantiate(bala);
            temp.transform.position = arma.position;
            temp.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0f, forçaTiro);
            Destroy(temp.gameObject, 3f);
          

        }
    }
}
