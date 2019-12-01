using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adiciona : MonoBehaviour
{
    // Start is called before the first frame update
    private int Pontuacao;
    private GameObject este;
    void Start()
    {
        este = GameObject.FindGameObjectWithTag("Pontua");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Pontuacao = PlayerPrefs.GetInt("Pontua");
        if(collision.gameObject.tag == "Player")
        {
            Destroy(este);
            Pontuacao++;
            PlayerPrefs.SetInt("Pontua",Pontuacao);
        }
    }
}
