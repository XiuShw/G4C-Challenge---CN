using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class UnlockableGrid : MonoBehaviour
{
    [SerializeField] GridScript GridScript;
    [SerializeField] GameObject HelpMenu;
    [SerializeField] TextMeshProUGUI hint;
    [SerializeField] int row = 0;
    [SerializeField] int column = 0;
    int[][] temp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && gameObject.GetComponent<SpriteRenderer>().enabled == false)
        {
            GameManager.outcomeValue += 1;

            GameManager.blockGridArray[row][column] = -2;
            GridScript.initGrid(GameManager.blockGridArray, GameManager.blockXOffset, GameManager.blockYOffset, GameManager.blockSolutionArray, GameManager.day);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if (HelpMenu.activeSelf == false && gameObject.GetComponent<SpriteRenderer>().enabled == true)
        {
            GameManager.outcomeValue -= 1;

            GameManager.blockGridArray[row][column] = 0;
            GridScript.initGrid(GameManager.blockGridArray, GameManager.blockXOffset, GameManager.blockYOffset, GameManager.blockSolutionArray, GameManager.day);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            hint.text = "按Z撤回此操作";
        }
    }
}
