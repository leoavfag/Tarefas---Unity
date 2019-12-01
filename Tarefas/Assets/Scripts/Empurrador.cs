using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empurrador : MonoBehaviour
{
    public GameObject Player;
    public GameObject Isso;
    private float distancia;
    private float velocidade = 1.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("MovC",0);
        float horizontal;
        float vertical;
        distancia = Vector2.Distance(Isso.transform.position, Player.transform.position);
        if(distancia<2 && Input.GetKey("e"))
        {
            Debug.Log("Entrou");
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            Vector2 position = rb.position;
            position.x = position.x + velocidade *horizontal*Time.deltaTime;
            position.y = position.y + velocidade *vertical*Time.deltaTime;
            PlayerPrefs.SetInt("MovC",1);
            rb.MovePosition(position);
        }
    }

}
