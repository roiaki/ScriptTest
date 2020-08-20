using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力

    private int mp = 53; //*課題


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 魔法攻撃関数　課題
    public void MagicAttack()
    {       
        if (this.mp >= 5)
        {
            this.mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp)         
        } else if(mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }  
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // Magic関数呼び出し 課題
        for (int i= 0; i <10; i++)
        {
            lastboss.MagicAttack();
        }
       
        lastboss.MagicAttack();


        // Lesson4課題------------
        // 配列宣言初期化
        int[] array = new int[5];
        
        for (int i = 0; i < 5; i++)
        {
            array[i] = i;
        }

        // 順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        //-------------------------
    }

    // Update is called once per frame
    void Update()
    {

    }
}