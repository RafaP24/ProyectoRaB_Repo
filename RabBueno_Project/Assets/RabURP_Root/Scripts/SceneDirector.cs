using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public int specificSceneToLoad;






    public void Sceneloader(int sceneToLoad)
    {
        //Esta acción carga la escena del espacio igual al entero que indiquemos
        SceneManager.LoadScene(sceneToLoad);
    }

    public void SceneLoadOnPlay()
    {
        SceneManager.LoadScene(specificSceneToLoad);

    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
