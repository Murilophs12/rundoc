using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena_Mouse : MonoBehaviour
{
    public string NomeDaCena;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(NomeDaCena);
        }

    }
}
