using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class login2 : MonoBehaviour
{

    private string url = "http://turistnuble.loverandom.cl/conections_app";
    public Text estado;
    public Text nombrecito;
    public GameObject login;
    public InputField correo, pass;
    float delay = 3;



    public void loguearme()
    {
        if (!string.IsNullOrEmpty(correo.text) && !string.IsNullOrEmpty(pass.text))
        {
            StartCoroutine(LoginSystem());
        }
        else
        {
            estado.text = "Porfavor ingresa los campos";
        }
    }

    IEnumerator LoginSystem()
    {
        yield return new WaitForEndOfFrame();
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("correo", correo.text);
        wwwForm.AddField("pass", pass.text);
        WWW www = new WWW(url + "/login.php", wwwForm);
        yield return www;

        estado.text = www.text;
        if (estado.text == "logueado")
        {

            estado.text = "Logueado con exito";
            yield return new WaitForSeconds(4);
            login.SetActive(false);

            ///agregamos nombre que recibe como parametro
            ///

            nombrecito.text = "Correo: " + correo.text;




        }


        

    }
}
