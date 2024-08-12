using System.Collections;
using System.Collections.Generic;
using TMPro;
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


}
