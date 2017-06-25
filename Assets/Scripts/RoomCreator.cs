using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCreator : MonoBehaviour
{
	public GameObject Room;
	public int stair;
	public int roomsInStair;
	public int maxInRoom;

	private float roomWidth = 15f;
	private float roomHeight = 10f;

	private void Start()
	{
		for(int st = 0; st < stair; st++)
		{
			for(int ris = 0; ris < roomsInStair; ris++)
			{
				Instantiate(Room, new Vector2 (roomWidth * ris, roomHeight * st), Quaternion.identity);
			}
		}
	}
}