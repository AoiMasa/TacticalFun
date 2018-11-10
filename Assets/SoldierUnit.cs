using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierUnit : Unit {

    public override void MarkAsAttacking(Unit other)
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    public override void MarkAsDefending(Unit other)
    {
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }

    public override void MarkAsDestroyed()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
    }

    public override void MarkAsFinished()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    public override void MarkAsFriendly()
    {
       // GetComponent<SpriteRenderer>().color = Color.green;
    }

    public override void MarkAsReachableEnemy()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }

    public override void MarkAsSelected()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
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
