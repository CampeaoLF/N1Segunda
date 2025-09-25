using UnityEngine;
using UnityEngine.UIElements;

public class Movimentation : MonoBehaviour
{
    
    private Rigidbody2D rb;
    


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if(t.phase == TouchPhase.Moved)
            {
                transform.position += (Vector3) t.deltaPosition/350;
               
            }
            
        }
    }
}
