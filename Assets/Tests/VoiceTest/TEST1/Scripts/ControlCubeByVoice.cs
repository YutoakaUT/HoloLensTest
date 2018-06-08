using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 音声でオブジェクトを操作するクラス
/// </summary>
public class ControlCubeByVoice : MonoBehaviour {

    // オブジェクトのサイズを1/2倍にするメソッド
    public void OnRecognaizedBigger()
    {
        transform.localScale *= 2.0f;
    }

    // オブジェクトのサイズを2倍にするメソッド
    public void OnRecognizedSmaller()
    {
        transform.localScale /= 2.0f;
    }

    // オブジェクトの色を変えるメソッド
    public void OnRecognizedChangeColor()
    {
        GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}
