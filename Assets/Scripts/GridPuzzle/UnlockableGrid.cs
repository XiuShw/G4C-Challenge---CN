using UnityEngine;
using UnityEngine.InputSystem;

public class UnlockableGrid : MonoBehaviour
{
    [SerializeField] GridScript GridScript;
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

    }

    private void OnMouseDown()
    {
        Debug.Log(GameManager.outcomeValue);
        GameManager.outcomeValue -= 1;
        Debug.Log(GameManager.outcomeValue);

        GameManager.blockGridArray[row][column] = 0;
        GridScript.initGrid(GameManager.blockGridArray, GameManager.blockXOffset, GameManager.blockYOffset, GameManager.blockSolutionArray, GameManager.day);
        Destroy(gameObject);
    }
}
