using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CreditoS : MonoBehaviour
{

    public float waitT;
    public GameObject B1,B2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WiatOrBack");
        B1.SetActive(false);
        B2.SetActive(false);
    }

    private IEnumerator WiatOrBack()
    {

        yield return new WaitForSeconds(waitT);
        B1.SetActive(true);
        B2.SetActive(true);

    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
