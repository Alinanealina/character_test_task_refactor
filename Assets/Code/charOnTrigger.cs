using System.Collections;
using UnityEngine;

public class charOnTrigger : MonoBehaviour
{
    private character chara;
    private void Start()
    {
        chara = GetComponent<character>();
    }

    private IEnumerator interaction()
    {
        while (chara.interactable != null)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                chara.interactable.interact();
                chara.interactable = null;
            }
            yield return null;
        }
    }

    private void triggering(Collider other)
    {
        if ((chara.interactable == null) &&
            ((chara.interactable = other.gameObject.GetComponent<Iinteractable>()) != null))
            StartCoroutine(interaction());
    }
    private void OnTriggerEnter(Collider other)
    {
        triggering(other);
    }
    private void OnTriggerStay(Collider other)
    {
        triggering(other);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Iinteractable>() == chara.interactable)
            chara.interactable = null;
    }

}
