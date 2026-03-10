using System.Collections.Generic;
using UnityEngine;

public class BrailleCell : MonoBehaviour
{
    // A cell is a 2x3 arrangement of dots.
    [SerializeField] GameObject cellContainer;
    bool capitalized; // whether the character is capitalized or not
    bool number; // whether the character is a number or not
    char character;
    Dictionary<char, int> alphabet = new Dictionary<char, int>()
    {
        {'A', 1},
        {'B', 3},
        {'C', 9},
        {'D', 25},
        {'E', 17},
        {'F', 11},
        {'G', 27},
        {'H', 19},
        {'I', 10},
        {'J', 26},
        {'K', 5},
        {'L', 7},
        {'M', 13},
        {'N', 29},
        {'O', 21},
        {'P', 15},
        {'Q', 31},
        {'R', 23},
        {'S', 14},
        {'T', 30},
        {'U', 37},
        {'V', 39},
        {'W', 58},
        {'X', 45},
        {'Y', 61},
        {'Z', 53},

        {'0', 26},
        {'1', 1},
        {'2', 3},
        {'3', 9},
        {'4', 25},
        {'5', 17},
        {'6', 11},
        {'7', 27},
        {'8', 19},
        {'9', 10},

        {',', 2},
        {'.', 50},
        {'?', 38},

        {'\a', 32},
        {'\n', 60},
    };

    public void Start()
    {
        Init();
    }
    public void Init()
    {
        for (int i = 0; i < 6; i++)
        {
            BrailleDot dot = cellContainer.transform.GetChild(i).GetComponent<BrailleDot>();
            dot.Init(this, i);
        }
    }
    public void ToggleDot(int dotIndex)
    {
        BrailleDot dot = cellContainer.transform.GetChild(dotIndex + 1).GetComponent<BrailleDot>();
        dot.Toggle();
    }
    public void OnDotClick(BrailleDot dot)
    {
        dot.Toggle();
    }
}
