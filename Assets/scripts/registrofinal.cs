using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class registrofinal : MonoBehaviour
{
    private string url = "http://turistnuble.loverandom.cl";
    public Text estado;
    public GameObject login,registro;
    public InputField nombre,correo, pass,pass2;

    public void Register()
    {
        if (!string.IsNullOrEmpty(nombre.text) && !string.IsNullOrEmpty(correo.text) && !string.IsNullOrEmpty(pass.text))
        {
            if (pass.text == pass2.text)
            {
                StartCoroutine(RegisterSystem());
                
            }
            else
                estado.text = "Verifice las contraseñas";

        }
        else
        {
            estado.text = "Rellene todos los campos";
        }
    }


    IEnumerator RegisterSystem()
    {
        WWW conexion = new WWW("http://turistnuble.loverandom.cl/conections_app/registrofinal.php?nameUser=" + nombre.text + "&mailUser=" + correo.text + "&passUser=" + pass.text);
        yield return (conexion);

        estado.text = "Registrado, redireccionando a login";
        yield return new WaitForSeconds(4);
        registro.SetActive(false);
        login.SetActive(true);
        
        //SceneManager.LoadScene("ra");




    }
}
