using UnityEngine;

public class charMain : character
{
    private void Awake()
    {
        hp = new charHealth(0, 10, 5);
        hp.on_dead += make_dead;
    }
    public void make_dead()
    {
        GetComponent<charControl>().enabled = false;
    }
}
