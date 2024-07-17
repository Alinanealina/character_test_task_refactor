using System;
using UnityEngine;

public class charHealth
{
    private int hp_min, hp_max, hp;
    public event Action on_dead;
    public charHealth()
    {
        init(0, 100, 100);
    }
    public charHealth(int hp_min, int hp_max, int hp)
    {
        init(hp_min, hp_max, hp);
    }
    private void init(int hp_min, int hp_max, int hp)
    {
        this.hp_min = hp_min;
        this.hp_max = hp_max;
        this.hp = hp;
        dead_messages = GameObject.FindObjectsByType<textDead>(FindObjectsSortMode.None);
    }

    public void add_hp(int hp)
    {
        this.hp = Math.Clamp(this.hp + hp, hp_min, hp_max);
        check_dead();
    }
    public int Hp
    {
        get { return hp; }
    }
    
    private textDead[] dead_messages;
    public void check_dead()
    {
        if (hp == hp_min)
        {
            on_dead?.Invoke();
            foreach (textDead obj in dead_messages)
                obj.show_message();
        }
    }
}