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

	public static float roomWidth = 15f;
	public static float floorHeight = 10f;
	public static float stairWidth = 6f;

	private void Start()
	{
		for(int fl = 0; fl < floor; fl++)
		{
			for(int rif = 0; rif < roomsInFloor; rif++)
			{
				GameObject room = Instantiate(Room, new Vector2 (roomWidth * rif, floorHeight * fl), Quaternion.identity);
				room.GetComponent<RoomInfo>().Unit = new GameObject[maxInRoom];
			}

			GameObject LeftStair = Instantiate(Stair, new Vector2(-(roomWidth + stairWidth)/2, floorHeight * fl), Quaternion.Euler(0, 180, 0));
			GameObject RightStair = Instantiate(Stair, new Vector2(roomWidth * roomsInFloor + (-roomWidth + stairWidth)/2, floorHeight * fl), Quaternion.identity);
		}
	}
}