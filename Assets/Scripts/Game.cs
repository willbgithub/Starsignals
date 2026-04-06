using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private BrailleCell cell;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cell.SetCell(58);
    }
}
