using UnityEngine;

public interface Iinteractable
{
    void interact();
    void hide_msg();
    void show_msg();
}

public abstract class interactChar : MonoBehaviour, Iinteractable
{
    protected character chara = null;
    private bool stay = true;

    private void enter(Collider other)
    {
        chara = other.gameObject.GetComponent<character>();
        if (chara == null)
            return;
        chara.hp.on_dead += hide_no_stay;
        show_msg();
    }
    protected virtual void OnTriggerEnter(Collider other)
    {
        enter(other);
    }
    protected virtual void OnTriggerStay(Collider other)
    {
        if (stay)
            show_msg();
    }
    protected virtual void OnTriggerExit(Collider other)
    {
        exit();
    }
    protected void exit()
    {
        hide_msg();
        if (chara == null)
            return;
        chara.hp.on_dead -= hide_no_stay;
        chara = null;
    }
    private void hide_no_stay()
    {
        stay = false;
        hide_msg();
    }

    public abstract void interact();

    private textInteraction[] inter_messages;
    private void Awake()
    {
        inter_messages = FindObjectsByType<textInteraction>(FindObjectsSortMode.None);
    }
    public void show_msg()
    {
        if ((inter_messages.Length > 0) && inter_messages[0].shown)
            return;
        foreach (textInteraction obj in inter_messages)
            obj.show_message();
    }
    public void hide_msg()
    {
        if ((inter_messages.Length > 0) && !inter_messages[0].shown)
            return;
        foreach (textInteraction obj in inter_messages)
            obj.hide_message();
    }
}