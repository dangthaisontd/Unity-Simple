using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physic : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        rd.AddForce(Vector2.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }
}
