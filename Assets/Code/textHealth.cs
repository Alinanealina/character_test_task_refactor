using UnityEngine;
using UnityEngine.UI;

public class textHealth : MonoBehaviour
{
    [SerializeField] private character chara;
    private Text text;
    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = "Health: " + chara.hp.Hp.ToString();
    }
}
