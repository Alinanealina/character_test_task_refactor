public class interactHealth : interactChar
{
    public override void interact()
    {
        chara.hp.add_hp(3);
        chara = null;
        gameObject.SetActive(false);
    }
}
