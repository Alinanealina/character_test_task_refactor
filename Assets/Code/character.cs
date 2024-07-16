using UnityEngine;

public abstract class character : MonoBehaviour // добавить смерть персонажа в charHealth
{
    public charHealth hp;
    public charControl control;
    public charOnTrigger trigger;
    public Iinteractable interactable = null;
}
