using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("角色資料")]
    public DataBasic data;

    private float hp;

    private void Awake()
    {
        hp = data.hp;
    }

    private void Damage(float damage)
    {
        hp -= damage;

        if (hp <= 0) Dead();
    }

    private void Dead()
    {

    }
}
