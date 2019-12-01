using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interator : MonoBehaviour
{
    public GameObject Player;
    public GameObject Isso;
    public Text Acao;
    private float distancia;
    private bool ativo=true;
    void start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        distancia = Vector2.Distance(Isso.transform.position, Player.transform.position);
        if(ativo == true)
        {
            if(distancia < 2)
            {
                Acao.enabled = true;
                if(Input.GetKey("a"))
                {
                    Destroy(Acao);
                    Destroy(Isso);
                    ativo = false;
                }
            }
            else
            {
                Acao.enabled = false;
            }
        }
    }
}
