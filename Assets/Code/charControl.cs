using UnityEngine;

public class charControl : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 3f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    private void Update()
    {
        controller.Move(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed * Time.deltaTime);
        controller.Move(new Vector3(0, 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }
}
