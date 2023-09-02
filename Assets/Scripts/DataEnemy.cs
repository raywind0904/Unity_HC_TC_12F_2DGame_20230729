using UnityEngine;

[CreateAssetMenu(menuName = "KID/Data Enemy", fileName = "Data Enemy")]
public class DataEnemy : ScriptableObject
{
    [Header("移動速度"), Range(0, 30)]
    public float speed = 2.5f;
    [Header("攻擊力"), Range(0, 5000)]
    public float attack = 20;
    [Header("血量"), Range(0, 10000)]
    public float hp = 100;
    [Header("掉落經驗值機率"), Range(0, 1)]
    public float expProbability = 0.7f;
    [Header("經驗值預製物")]
    public GameObject expPrefab;
}
