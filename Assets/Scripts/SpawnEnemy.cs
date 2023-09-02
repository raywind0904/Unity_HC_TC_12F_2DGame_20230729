using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [Header("生成敵人間隔"), Range(0, 10)]
    public float interval = 3;
    [Header("敵人預製物")]
    public GameObject prefabEnemy;

    private void Awake()
    {
        InvokeRepeating("SpawnEnemyMethod", 0, interval);
    }

    private void SpawnEnemyMethod()
    {
        Instantiate(prefabEnemy, transform.position, transform.rotation);
    }
}
