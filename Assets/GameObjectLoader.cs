using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameObjectLoader : MonoBehaviour
{
    public GameObject gameObjectToLoad;
    public Vector3 loadPosition = new Vector3(0, 0, 0);
    public Quaternion loadRotation = Quaternion.identity;

    public void LoadGameObject()
    {
        Instantiate(gameObjectToLoad, new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void LoadGameObjectAtPosition(Vector3 position)
    {
        Instantiate(gameObjectToLoad, loadPosition, Quaternion.identity);
    }

    public void LoadGameObjectWithRotation(Quaternion rotation)
    {
        Instantiate(gameObjectToLoad, new Vector3(0, 0, 0), loadRotation);
    }
}