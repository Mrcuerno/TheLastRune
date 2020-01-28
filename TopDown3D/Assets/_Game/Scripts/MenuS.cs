using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuS : MonoBehaviour
{

    public bool optionsmenu;
    public GameObject PMenu, POptions;
   
    // Start is called before the first frame update
    void Start()
    {
        optionsmenu = false;
        PMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (optionsmenu)
        {
            POptions.SetActive(true);
            PMenu.SetActive(false);
        }
        else
        {
            PMenu.SetActive(true);
            POptions.SetActive(false);

        }
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void OptionsMenu()
    {
        optionsmenu = true;
        Debug.Log(optionsmenu);
    }
    public void OnMenu()
    {
        optionsmenu = false;
    }
    public void Credits()
    {
        SceneManager.LoadScene(5);
    }

    public void VLowRes()
    {
        Screen.SetResolution(800, 600, true);
    }

    public void LowRes()
    {
        Screen.SetResolution(1024, 720, true);
    }
    public void HDRes()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    
}
