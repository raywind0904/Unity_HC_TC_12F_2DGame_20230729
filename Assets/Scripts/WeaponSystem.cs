using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    [Header("生成武器間隔"), Range(0, 6)]
    public float interval = 3;
    [Header("武器預製物")]
    public GameObject prefabWeapon;
    [Header("武器發射力道")]
    public Vector2 v2Power = new Vector2(0, 100);

    private void Awake()
    {
        // SpawnWeapon();

        // 重複呼叫 SpawnWeapon 間隔為 interval
        InvokeRepeating("SpawnWeapon", 0, interval);
    }

    private void SpawnWeapon()
    {
        GameObject temp = Instantiate(prefabWeapon, transform.position, transform.rotation);
        temp.GetComponent<Rigidbody2D>().AddForce(v2Power);
    }
}
