public class interactEnemy : interactChar
{
    public override void interact()
    {
        chara.hp.add_hp(-1);
    }
}
