using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class ChangeColorByAirTap : MonoBehaviour, IInputClickHandler
{
    // AirTapのイベントハンドラ
    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("色を変えました！");
        GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

    }
}
