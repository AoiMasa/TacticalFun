using UnityEngine;

public class TileGrassASquare : Square {

    public override Vector3 GetCellDimensions()
    {
        return GetComponent<SpriteRenderer>().bounds.size;
    }

    public override void MarkAsHighlighted()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    public override void MarkAsPath()
    {
        GetComponent<SpriteRenderer>().color = Color.blue;
    }

    public override void MarkAsReachable()
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    public override void UnMark()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
