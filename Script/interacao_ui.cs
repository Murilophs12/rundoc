using UnityEngine;
using TMPro;
public class interacao_ui : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

  public int Pontos = 0;
  public TMP_Text Texto;
  
  public void AdicionarPontos()
{
   Pontos = Pontos + 10;
   Texto.text = Pontos.ToString();
      



}




  public void MensagemDebug()
   {

      Debug.Log("Mensagem Debug");



   }
}