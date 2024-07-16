using System;

public class charHealth
{
    private int hp_min, hp_max, hp;
    public charHealth()
    {
        hp_min = 0;
        hp_max = 100;
        hp = hp_max;
    }
    public charHealth(int hp_min, int hp_max, int hp)
    {
        this.hp_min = hp_min;
        this.hp_max = hp_max;
        this.hp = hp;
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
    public void check_dead()
    {
        if (hp == hp_min)
        {
            
        }
    }
}