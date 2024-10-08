using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    #region Singleton
        public static UIManager instance;
     private void Awake()
     {
         instance = this;
     }
    #endregion

    [SerializeField] Button[] botoes;
    [SerializeField] TextMeshProUGUI sequenciaTexto;
    [SerializeField] TextMeshProUGUI acertouTexto;
    [SerializeField] TextMeshProUGUI errouTexto;

    private void Start()
    {
        for (int i = 0; i < botoes.Length; i ++)
        {
            int x = i;

            
            botoes[i].onClick.AddListener(() => GameManager.instance.ChecarCor(x));
        }
    }

   public void AtualizarAcertos(int acertos)
   {
        
       acertouTexto.text = "acertou".ToString();
   }

   public void AtualizarErros(int erros)
   {
        
        errouTexto.text = "errou".ToString();
   }

   public void LimparTexto()
   {
        sequenciaTexto.text = " ";
   }

    public void AtualizarSequencia(string cor)
    {
        sequenciaTexto.text += cor + " ";
    }

}


