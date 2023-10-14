using UnityEngine;

[CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "Data Enemy")]
public class DataEnemy : DataBasic
{
    [Header("攻擊力"), Range(0, 5000)]
    public float attack = 20;
    [Header("掉落經驗值機率"), Range(0, 1)]
    public float expProbability = 0.7f;
    [Header("經驗值預製物")]
    public GameObject expPrefab;
    [Header("傳送攻擊時間"), Range(0, 5)]
    public float attackSendTime = 0.6f;
    [Header("攻擊間隔"), Range(0, 5)]
    public float attackInterval = 3;
    [Header("攻擊停止距離"), Range(0.5f, 5)]
    public float attackDistance = 3;
}
