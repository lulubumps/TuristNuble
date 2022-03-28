using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class funcionbotones : MonoBehaviour
{
    public GameObject panel2,panellogin,panelra,sli,panelbotones,panelprincipiora;

    public void abrirregistro()
    {
        panel2.SetActive(true);
    }

    public void abrirra()
    {
        SceneManager.LoadScene("ra");
    }

    public void cerrarpanelprincipiora()
    {
        panelprincipiora.SetActive(false);
    }

    public void cerrarregistro()
    {
        panel2.SetActive(false);
    }

    public void abrirpanelsli()
    {
        sli.SetActive(true);
    }
    public void cerrarbotones()
    {
        panelbotones.SetActive(false);
    }
       

    public void volvermenu()
    {
        SceneManager.LoadScene("MenuPrincipal");

    }

    public void cerrarpanelra()
    {
        panelra.SetActive(false);
    }

    public void abrirlogin()
    {
        panellogin.SetActive(true);

    }

    public void cerrarlogin()
    {
        panellogin.SetActive(false);
    }


}
