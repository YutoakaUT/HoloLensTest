using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

/// <summary>
/// IIputClickHandlerはAirTAapに関するイベントが入っているので絶対覚える
/// </summary>
public class DifferentiateOnObjectOrNot : MonoBehaviour, IInputClickHandler
{

    void Start()
    {
        //いかなる時もジェスチャーを反応させる
        InputManager.Instance.AddGlobalListener(gameObject);
    }

    // AirTapイベントハンドラ
    public void OnInputClicked(InputClickedEventData eventData)
    {
        // 何もGazeがヒットしてないとき動作する
        if (!GazeManager.Instance.HitObject)
        {
            // ログ吐き（デバッグで使うので覚える）
            Debug.Log("空間をAirTapしました！");
        }
        else
        {
            //Gazeがヒットしているとき
            Debug.Log("オブジェクトをAirTapしました！");
        }
    }
}
