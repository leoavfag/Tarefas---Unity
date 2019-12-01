using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Administrador : MonoBehaviour
{
    // Start is called before the first frame update
    public Text VerP; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TVerNoConsole();
    }
    void TVerNoConsole()
    {
        int pontuacao;
        pontuacao = PlayerPrefs.GetInt("Pontua");
        if(pontuacao>0)
        {
            VerP.enabled = true;
        }
        else
        {
            VerP.enabled = false;
        }
    }
}
