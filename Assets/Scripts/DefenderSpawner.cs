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
        return worldPos;
    }

    void SpawnDefender(Vector2 worldPos)
    {
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity) as GameObject; 
    }
}
