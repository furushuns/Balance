using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    // 固定したいY軸の回転角度
    public float fixedYRotation = 0f;

    void Update()
    {
        // 現在の回転を取得
        Quaternion currentRotation = transform.rotation;

        // オイラー角に変換
        Vector3 euler = currentRotation.eulerAngles;

        // Y軸の回転を固定
        euler.y = fixedYRotation;

        // 回転を更新
        transform.rotation = Quaternion.Euler(euler);
    }
}
