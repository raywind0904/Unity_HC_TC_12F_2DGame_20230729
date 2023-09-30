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

    public void Damage(float damage)
    {
        hp -= damage;

        if (hp <= 0) Dead();

        print($"<color=#f96>{gameObject.name} 受傷，血量剩下 {hp}</color>");
    }

    private void Dead()
    {
        print($"<color=#f96>{gameObject.name} 死亡</color>");
    }
}
