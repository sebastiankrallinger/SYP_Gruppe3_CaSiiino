using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 50;
    public Animator ronaldo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            ronaldo.SetBool("IsRunning", true);
        }
        else
        {
            ronaldo.SetBool("IsRunning", false);
        }
       
        transform.Translate(Vector2.right * speed * horizontal * Time.deltaTime);
        transform.Translate(Vector2.up * speed * vertical * Time.deltaTime);
    }
}
