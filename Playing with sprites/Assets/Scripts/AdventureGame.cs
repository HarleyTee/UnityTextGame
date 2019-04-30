﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }
    void Update()
    {
        ManageState();
    }
     private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            state = startingState;
        }
        textComponent.text = state.GetStateStory();
    }
}    

