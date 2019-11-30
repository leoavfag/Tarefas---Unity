using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizonta = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rb.position;

        position.x = position.x + velocidade * horizonta * Time.deltaTime;
        position.y = position.y + velocidade * vertical * Time.deltaTime;

        rb.MovePosition(position);
    }
}
