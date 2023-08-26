using UnityEngine;

public class ControlSystem : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float speed = 3.5f;

    private string parWalk = "開關走路";
}
