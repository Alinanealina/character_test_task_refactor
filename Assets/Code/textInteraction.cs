public class textInteraction : messenger
{
    public bool shown = false;
    private void OnEnable()
    {
        shown = true;
    }
    private void OnDisable()
    {
        shown = false;
    }
}
