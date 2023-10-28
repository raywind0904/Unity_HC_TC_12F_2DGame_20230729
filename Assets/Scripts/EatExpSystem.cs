using UnityEngine;

public class EatExpSystem : MonoBehaviour
{
    private string nameExp = "經驗值";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains(nameExp))
        {
            collision.gameObject.GetComponent<ExpObject>().enabled = true;
        }
    }
}
