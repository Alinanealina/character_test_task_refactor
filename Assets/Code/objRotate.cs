using UnityEngine;

public class objRotate : MonoBehaviour
{
    [SerializeField] private GameObject game_obj;
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 1.5f);
    }
}
