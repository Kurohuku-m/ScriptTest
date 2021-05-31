using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // 要素数5の配列を初期化する
        int[] points = { 1, 2, 3, 5, 7 };

        // 配列の各要素の値を順番に表示する
        for (int i = 0; i < 5; i++)
            {
            Debug.Log(points[i]);
            }

        // 配列の各要素の値を順番に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }
    } 
    
    // Update is called once per frame
    void Update()
    {
        
    }
}



