using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BrailleDot : MonoBehaviour
{
    BrailleCell cell;
    int index;
    [SerializeField] GameObject dot;
    bool on;

    public void Init(BrailleCell c, int n)
    {
        cell = c;
        index = n;
        on = true;
    }
    public void OnPointerClick(BaseEventData data)
    {
        cell.OnDotClick(this);
    }

    // Mutators
    public void Toggle()
    {
        on = !on;
        dot.SetActive(on);
    }
    public void SetOn(bool value)
    {
        on = value;
        dot.SetActive(value);
    }
    public void SetCell(BrailleCell c)
    {
        cell = c;
    }

    // Accessors
    public bool GetOn()
    {
        return on;
    }
    public BrailleCell GetCell()
    {
        return cell;
    }
}
