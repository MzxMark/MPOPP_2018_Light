using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class ItemDatabase : MonoBehaviour {
	private JsonData itemdata;
	private List<Item> database = new List<Item> ();
	// Use this for initialization
	void Start () {
		itemdata = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/ItemAssets/Items.json"));
		ConstructItemDatabase ();
		Debug.Log (database[0].Name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void ConstructItemDatabase()
	{
		for (int i = 0; i < itemdata.Count; i++) {
			database.Add (new Item ((int)itemdata [i] ["id"], itemdata [i] ["name"].ToString (), (int)itemdata [i] ["value"]));
		}
	}
}
public class Item{
	public int Id { get; set;}
	public string Name {get;set;}
	public int Value{ get; set;}
	public Item(int _id, string _name, int _value)
	{
		this.Id = _id;
		this.Name = _name;
		this.Value = _value;
	}
}