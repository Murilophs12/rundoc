using UnityEngine;
using UnityEngine.SceneManagement;

public class troca : MonoBehaviour
{
   public string NomeDaCena;
   
    void OnMouseDown()
    {
       SceneManager.LoadScene(NomeDaCena);
    }
}
