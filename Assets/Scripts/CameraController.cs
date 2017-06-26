using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private float floorHeight;
	private float roomWidth;
	private int floor;
	private int roomsInFloor;

	private void Start()
	{
		floorHeight = AptCreator.floorHeight;
		roomWidth = AptCreator.roomWidth;
		floor = GameObject.Find("GameManager").GetComponent<AptCreator>().floor;
		roomsInFloor = GameObject.Find("GameManager").GetComponent<AptCreator>().roomsInFloor;

		transform.position = new Vector3((roomsInFloor - 1) * roomWidth / 2, (floor - 1) * floorHeight / 2, -10f);
	}
}