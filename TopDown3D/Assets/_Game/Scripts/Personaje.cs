using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public bool WeaponS;
    public GameObject S1 , S2;
    // Start is called before the first frame update
    void Start()
    {
        WeaponS = false;
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        checkWeapon();
        Debug.Log(WeaponS);
    }

    #region GUI


    
    public void Inputs()
    {
        if ( Input.GetButtonDown("Y") )
        {
            
            if (WeaponS)
            {
                WeaponS = false;
            }
            else
            {
                WeaponS = true;
            }
            Debug.Log("P");
        }
       
    }

    public void checkWeapon()
    {
        if (WeaponS)
        {
            S1.SetActive(true);
            S2.SetActive(false);
        }
        else if(!WeaponS)
        {
            S1.SetActive(false);
            S2.SetActive(true);
            
        }
    }

    #endregion
}
