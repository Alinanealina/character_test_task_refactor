using UnityEngine;

public class interactInstr : interactChar
{
    private bool shown = false;
    [SerializeField] private GameObject instr_panel;
    public override void interact()
    {
        shown = !shown;
        instr_panel.SetActive(shown);
    }

    public void too_far()
    {
        if (shown)
            interact();
    }
    protected override void OnTriggerExit(Collider other)
    {
        too_far();
        chara = null;
    }
}
