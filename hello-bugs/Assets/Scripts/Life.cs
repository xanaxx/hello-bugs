using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    public TextMeshProUGUI LifesLeft;
    public GameController gameController;

    static public int Lifes { get; private set; }

    private void Start()
    {
        Lifes = 3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Lifes > 0)
        {
            Lifes -= 1;
            LifesLeft.text = "Lifes Left:\n" + Lifes.ToString();
        }
        else
        {
            gameController.MakeDead(true);
        }
    }

}
