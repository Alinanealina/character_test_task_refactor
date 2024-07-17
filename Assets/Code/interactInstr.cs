using UnityEngine;

public class interactInstr : interactChar
{
    private bool shown = false;
    [SerializeField] private GameObject instr_panel;
    public override void interact()
    {
        shown = !shown;
        instr_panel.SetActive(shown);
        opposite_inter_msg();
    }
    private void opposite_inter_msg()
    {
        if (shown)
            hide_msg();
        else
            show_msg();
    }

    public void too_far()
    {
        if (shown)
            interact();
    }
    protected override void OnTriggerStay(Collider other)
    {
        opposite_inter_msg();
    }
    protected override void OnTriggerExit(Collider other)
    {
        too_far();
        exit();
    }
}
