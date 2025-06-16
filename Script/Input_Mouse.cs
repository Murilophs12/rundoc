using UnityEngine;

public class Input_Mouse : MonoBehaviour
{
    public SpriteRenderer imagemReferencia;
    public Color cor1;
    public Color cor2;
    public Color cor3;

    // Ativa quando o mouse entra em um objeto com colisor
    void OnMouseEnter()
    {
        Debug.Log("MOUSE ENTROU NO OBJETO");
        imagemReferencia.color = cor1;
    }
    // Ativa quando o mouse sai de um objeto com colisor
    void OnMouseExit()
    {
        Debug.Log("MOUSE Saiu do OBJETO");
        imagemReferencia.color = cor3;
    }
    // Ativa quando clicamos em um objeto com colisor
    void OnMouseDown()
    {
        Debug.Log("Clicou no objeto");
        imagemReferencia.color = cor2;
    }
}
