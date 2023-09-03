using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro; // Reference to the TextMeshProUGUI component

    private void Start()
    {
        GameObject textObject = new GameObject("CollisionText");
        textMeshPro = textObject.AddComponent<TextMeshProUGUI>();

        textMeshPro.transform.position = new Vector3(0f, 0f, 0f);
        textMeshPro.fontSize = 36;
        textMeshPro.text = "GG, u reached the end!";
        
        textObject.transform.SetParent(GameObject.Find("Canvas").transform, false);

        textMeshPro.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("GG, u reached the end!");

            
            textMeshPro.enabled = true;
             Time.timeScale = 0f;
        }
    }
}
