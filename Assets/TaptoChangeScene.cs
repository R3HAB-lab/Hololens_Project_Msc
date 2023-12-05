using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;

public class TaptoChangeScene : MonoBehaviour, IInputClickHandler
{

    public void OnInputClicked(InputClickedEventData eventData)
    {

        switch (this.gameObject.name)
        {
            case ("ButtonScene2"):
                SceneManager.LoadSceneAsync("Scenes/SampleScene", LoadSceneMode.Single);
                break;

            case ("ButtonScene3"):
                SceneManager.LoadSceneAsync("Scenes/Scene2", LoadSceneMode.Single);
                break;
            case ("ButtonScene1"):
                SceneManager.LoadSceneAsync("Scenes/SampleScene", LoadSceneMode.Single);
                break;

        }
    }
}
