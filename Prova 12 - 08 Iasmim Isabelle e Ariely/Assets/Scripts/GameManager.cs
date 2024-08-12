using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    #region Singleton
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    int corDaVez;
    int acertos;
    int erros;

    int[] sequencia;

    [SerializeField] string[] nomes;

    void Start()
    {
        GerarSequencia();
    }

    void GerarSequencia()
    {
        corDaVez = 0;

        int[] sequencia = new int [Random.Range(3,nomes.Length)];

        UIManager.instance.LimparTexto();

        for (int i = 0; i < sequencia.Length; i++)
        {
            sequencia[i] = Random.Range(0, nomes.Length);
        }

        UIManager.instance.AtualizarSequencia(nomes[sequencia[i]]);
    }

    public void ChecarCor( int corIndex)
    {
        if (corIndex == sequencia[corDaVez])
        {
            corDaVez++;
        }

        if (corDaVez == sequencia.Length)
        {
            acertos++;

            UIManager.instance.AtualizarAcertos(acertos);

            GerarSequencia();
        }
        
        else if ()

    }



   
}
