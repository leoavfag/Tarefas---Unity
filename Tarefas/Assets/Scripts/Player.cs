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
        PlayerPrefs.SetInt("Pontua",0);
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Pontuacao();
    }
    void Movimento()
    {
        int movimento = PlayerPrefs.GetInt("MovC");
        if(movimento!=1)
        {
            float horizonta = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector2 position = rb.position;

            position.x = position.x + velocidade * horizonta * Time.deltaTime;
            position.y = position.y + velocidade * vertical * Time.deltaTime;

            rb.MovePosition(position);
        }
        
    }
    void Pontuacao()
    {
        if(Input.GetKey("p")) Debug.Log(PlayerPrefs.GetInt("Pontua"));
    }

}
