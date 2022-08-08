using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoOffset : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameOver gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - speed);

        if (gameObject.transform.position.y < 0)
        {
            gameOver.MenuActivator();
            
        }
    }
}
