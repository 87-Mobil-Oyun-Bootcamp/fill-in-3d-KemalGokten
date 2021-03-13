using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private BlockSpawner blockspawner;

    [SerializeField]
    private GameObject BlocksContainer;

    private int cubesnumbers;

    LevelInfo levelInfo;
    private bool isStarted = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isStarted)
        {
            cubesnumbers = blockspawner.numberofCubes;
            for(int x=0; x <cubesnumbers; x++)
            {
                GameObject cubeObj = Instantiate(BlocksContainer, transform);
                cubeObj.transform.localPosition = BlocksContainer.transform.position;
                cubeObj.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                cubeObj.GetComponent<Renderer>().material.color = Color.yellow;
            }
            isStarted = true;
        }
    }
}
