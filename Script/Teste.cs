using UnityEngine;

public class Teste : MonoBehaviour
{
    public KeyCode TeclaDesejada;
    public GameObject ObjetoReferencia;

    public GameObject Ref_PreFab;
    public Transform Ref_Posicao;
    public Transform Ref_Pai;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(TeclaDesejada))
        {
            Debug.Log("Tecla Pressionada");
            //ObjetoReferencia.SetActive(false);

            //Destroy(ObjetoReferencia);

            Instantiate(Ref_PreFab, Ref_Posicao.position, Quaternion.identity, Ref_Pai);
        }

        if (Input.GetKeyUp(TeclaDesejada))
        {
            Debug.Log("Tecla Solta");
            //ObjetoReferencia.SetActive(true);
        }
    }
}
