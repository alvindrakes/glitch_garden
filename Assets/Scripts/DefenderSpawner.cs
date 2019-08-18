using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown() {
        SpawnDefender(getClickPosition());
    }

    private Vector2 getClickPosition() 
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 roundedPos = snapToGrid(worldPos);
        return roundedPos;
    }

    private Vector2 snapToGrid(Vector2 rawWorldPos)
    {
        int newX = Mathf.RoundToInt(rawWorldPos.x);
        int  newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    void SpawnDefender(Vector2 roundedPos)
    {
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity) as GameObject; 
    }
}
