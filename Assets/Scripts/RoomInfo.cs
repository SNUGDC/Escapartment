using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomInfo : MonoBehaviour
{
	public int myFloor;
	public int myNumber;
	public GameObject[] Unit;

	private float floorHeight;
	private float roomWidth;

	private void Start()
	{
		floorHeight = AptCreator.floorHeight;
		roomWidth = AptCreator.roomWidth;
		
		myFloor = (int)(transform.position.y / floorHeight) + 1;
		myNumber = (int)(transform.position.x / roomWidth) + 1;
	}
}