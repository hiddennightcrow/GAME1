using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [Header("跟隨目標")]
    public Transform target;
    //[Header("跟隨速度"), Range(0f, 100f)]
    //public float speed = 2f;

    /// <summary>
    /// 跟隨目標功能
    /// </summary>
    private void Track()
    {
       

        // 三維向量 目標座標 = 新 三維向量(目標.座標.X，限制後的 Y，-10) - 攝影機 Z 預設為 -10
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, -10);

        // 攝影機.座標 = 三維向量.插值(攝影機.座標，目標座標，百分比 * 速度 * 一幀的時間)
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }

    // 在 Update 執行後才執行 LateUpdate，適合用於跟隨
    private void LateUpdate()
    {
        Track();
    }
}
