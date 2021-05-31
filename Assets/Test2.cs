using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int mp = 53;   //　マジックポイント

    // 魔法攻撃用のMagic関数
    public void Magic(int consumption)
    {
        if (this.mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            // mpが5以上の場合は残りmpを減らす
            this.mp -= consumption;
        }
        else
        {
            // mpが5より小さい場合
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

}

public class Test2 : MonoBehaviour
{

    void Start()
    {
         // Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();

        //11回処理を繰り返す
        for (int consumption = 0; consumption < 11; consumption++)
            {   // Magic関数を呼び出す
                lastboss.Magic(5);
            }
    }

    // Update is called once per frame
    void Update()
    {


    }
}