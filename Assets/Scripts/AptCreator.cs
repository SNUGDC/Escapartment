using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AptCreator : MonoBehaviour
{
	public GameObject Room;
	public GameObject Stair;
	public int floor;
	public int roomsInFloor;
	public int maxInRoom;

	public const float roomWidth = 15f;
	public const float floorHeight = 10f;
	public const float stairWidth = 6f;

	private void Awake()
	{
		GetComponent<AptController>().Rooms = new GameObject[roomsInFloor, floor];

		for(int fl = 0; fl < floor; fl++)
		{
			for(int rif = 0; rif < roomsInFloor; rif++)
			{
				GetComponent<AptController>().Rooms[rif, fl] = Instantiate(Room, new Vector2 (roomWidth * rif, floorHeight * fl), Quaternion.identity);
				GetComponent<AptController>().Rooms[rif, fl].GetComponent<RoomInfo>().Unit = new GameObject[maxInRoom];
			}

			//Left Stair
			Instantiate(Stair, new Vector2(-(roomWidth + stairWidth)/2, floorHeight * fl), Quaternion.Euler(0, 180, 0));
			//Right Stair
			Instantiate(Stair, new Vector2(roomWidth * roomsInFloor + (-roomWidth + stairWidth)/2, floorHeight * fl), Quaternion.identity);
		}
	}
}