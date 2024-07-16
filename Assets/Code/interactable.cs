using UnityEngine;

public interface Iinteractable
{
    void interact();
    void show_message();
}

public abstract class interactChar : MonoBehaviour, Iinteractable
{
    protected character chara = null;

    protected virtual void OnTriggerEnter(Collider other)
    {
        chara = other.gameObject.GetComponent<character>();
    }
    protected virtual void OnTriggerExit(Collider other)
    {
        chara = null;
    }

    public abstract void interact();

    private GameObject inter_message;   // доделать показ сообщения о взаимодействии
    private void Start()
    {
        
    }
    public void show_message()
    {

    }
}