﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void cambiarScena()
    {
        SceneManager.LoadScene("MenuPlay");
    }
    public void CerrarJuego()
    {
        Application.Quit();
    }
}
