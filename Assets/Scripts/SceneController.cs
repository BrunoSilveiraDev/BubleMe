﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public static void Jogar() {
        SceneManager.LoadScene("SampleScene");
    }

    public static void Menu() {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public static void Sair() {
        Application.Quit();
    }

}