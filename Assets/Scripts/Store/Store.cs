using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
	public List<StoreEntity> storeEntity = new List<StoreEntity>();
	public delegate void OnStoreChanged();
	public OnStoreChanged onStoreChangedCallback;

	#region Singleton
	public static Store instance;

	void Awake()
	{
		if (instance != null)
		{
			Debug.LogWarning("Магазин не найден!");
			return;
		}
		instance = this;
	}
	#endregion
}
