﻿using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FirstInputScript : MonoBehaviour, IInputClickHandler {

    // AirTapのイベントハンドラ
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("AirTapされました！！！");
    }
}
