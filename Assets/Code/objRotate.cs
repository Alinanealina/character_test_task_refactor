using UnityEngine;

public class objRotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 100f * Time.deltaTime);
    }
}
