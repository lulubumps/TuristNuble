using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class CambiarScene : MonoBehaviour
{
    public void SceneAr(string nombrescene)
    {
        SceneManager.LoadScene(1);
    }

    public void SceneMenu(string nombrescena)
    {

        SceneManager.LoadScene(0);
    }
}
