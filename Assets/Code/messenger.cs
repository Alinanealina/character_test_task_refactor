using UnityEngine;
public interface Imessenger
{
    void show_message();
    void hide_message();
}
public abstract class messenger : MonoBehaviour, Imessenger
{
    protected void Start()
    {
        gameObject.SetActive(false);
    }
    public void show_message()
    {
        gameObject.SetActive(true);
    }
    public void hide_message()
    {
        gameObject.SetActive(false);
    }
}
