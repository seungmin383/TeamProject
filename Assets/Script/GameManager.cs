using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 144;
        Screen.SetResolution(1920,1080,true);
    }

    private void Update()
    {

    }
}
