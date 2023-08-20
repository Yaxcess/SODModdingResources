using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020006AC RID: 1708
public class FlightData : MonoBehaviour
{
	// Token: 0x06002CC7 RID: 11463 RVA: 0x0017F9FC File Offset: 0x0017DBFC
	public static AvAvatarFlyingData GetFlightData(GameObject flyingObject, FlightDataType flightDataType)
	{
		FlightData component = flyingObject.GetComponent<FlightData>();
		if (component == null)
		{
			Debug.LogError("Attempting to get flight data from object " + ((flyingObject != null) ? flyingObject.ToString() : null) + " , but no flight data component is attached!!!");
			return null;
		}
		for (int i = 0; i < component._FlightInformation.Count; i++)
		{
			if (component._FlightInformation[i]._FlightType == flightDataType)
			{
				return component._FlightInformation[i]._FlightData.Clone();
			}
		}
		Debug.LogError("No flight type of " + flightDataType.ToString() + " was found for: " + ((flyingObject != null) ? flyingObject.ToString() : null));
		return null;
	}

	// Token: 0x04002BED RID: 11245
	public List<FlightInformation> _FlightInformation = new List<FlightInformation>();
}
