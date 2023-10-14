using TMPro;
using UnityEngine;

public class DamageBasic : MonoBehaviour
{
    [Header("角色資料")]
    public DataBasic data;
    [Header("傷害值預製物")]
    public GameObject prefabDamage;

    protected float hp;
    protected float hpMax;

    protected virtual void Awake()
    {
        hp = data.hp;
        hpMax = hp;
    }

    public virtual void Damage(float damage)
    {
        hp -= damage;
        GameObject tempDamage = Instantiate(prefabDamage, transform.position, Quaternion.identity);
        Destroy(tempDamage, 1);
        tempDamage.transform.GetChild(0).GetComponent<TextMeshPro>().text = damage.ToString();

        if (hp <= 0) Dead();

        // print($"<color=#f96>{gameObject.name} 受傷，血量剩下 {hp}</color>");
    }

    protected virtual void Dead()
    {
        // print($"<color=#f96>{gameObject.name} 死亡</color>");
    }
}
