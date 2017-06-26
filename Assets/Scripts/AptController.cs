using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AptController : MonoBehaviour
{
	public GameObject[,] Rooms;
	public GameObject[] UnitType;

	private void Start()
	{
		for(int x = 0; x < Rooms.GetLength(0); x++)
		{
			for(int y = 0; y < Rooms.GetLength(1); y++)
			{
				int unitNum = Random.Range(0, 4);

				for(int num = 0; num < unitNum; num++)
				{
					int unitType = Random.Range(0, UnitType.Length);
					Rooms[x, y].GetComponent<RoomInfo>().Unit[num] = UnitType[unitType];
				}
			}
		}
	}
}