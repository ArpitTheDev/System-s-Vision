using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGame : MonoBehaviour
{
    public static int objectIndex;

    [SerializeField]
    private GameObject[] ObjToLoadPrefabs;
    [SerializeField]
    private InputManager inputManager;
    [SerializeField] 
    private ModelPainter modelPainter;
    [SerializeField] 
    private ModelViewNew modelViewNew;

    void Start()
    {
        GameObject objLoad = (GameObject)Instantiate(ObjToLoadPrefabs[objectIndex]) as GameObject;
        objLoad.transform.parent = transform;
        modelPainter.input = inputManager.currentInputStrategy;
        modelViewNew.input = inputManager.currentInputStrategy;
    }
}
