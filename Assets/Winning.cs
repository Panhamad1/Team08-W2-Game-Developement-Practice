
using UnityEngine;

public class WinGame : MonoBehaviour
{
    private bool hasWon = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasWon)
        {
            hasWon = true;
            Debug.Log("YOU WIN!");
            Time.timeScale = 0f;
        }
    }

    void OnGUI()
    {
        if (hasWon)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = 60;
            style.fontStyle = FontStyle.Bold;
            style.alignment = TextAnchor.MiddleCenter;
            style.normal.textColor = Color.green;

            GUI.Label(
                new Rect(
                    Screen.width / 2 - 250,
                    Screen.height / 2 - 60,
                    500,
                    120
                ),
                "YOU WIN!",
                style
            );
        }
    }
}
