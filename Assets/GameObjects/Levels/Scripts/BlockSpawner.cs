﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    Vector3 blockPos = Vector3.zero;
    public int numberofCubes = 0;
    public List<GameObject> CreateBlockFromImage(LevelInfo levelInfo, Transform transform)
    {
        List<GameObject> createdCubes = new List<GameObject>();

        for (int x = 0; x < levelInfo.sprite.texture.width; x++)
        {
            for (int y = 0; y < levelInfo.sprite.texture.height; y++)
            {
                Color color = levelInfo.sprite.texture.GetPixel(x, y);

                if (color.a == 0)
                {
                    continue;
                }

                blockPos = new Vector3(
                    levelInfo.size * (x - (levelInfo.sprite.texture.width * .5f)),
                    levelInfo.size * .5f,
                    levelInfo.size * (y - (levelInfo.sprite.texture.height * .5f)));

                GameObject cubeObj = Instantiate(levelInfo.baseObj, transform);
                cubeObj.transform.localPosition = blockPos;
                cubeObj.GetComponent<FilledCubes>().RColor = color;
                cubeObj.GetComponent<Renderer>().material.color = Color.grey;
                cubeObj.transform.localScale = Vector3.one * levelInfo.size;
                cubeObj.GetComponent<Collider>().isTrigger = true;
                numberofCubes++;
                createdCubes.Add(cubeObj);
            }
        }

        return createdCubes;
    }
}
