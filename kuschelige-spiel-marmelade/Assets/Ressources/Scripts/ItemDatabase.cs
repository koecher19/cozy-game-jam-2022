using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>(10);

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDatabase()
    {
        items = new List<Item>()
        {
           new Item(0, "Empty Bowl", "An empty bowl"),
           new Item(1, "Bowl filled", "A bowl, filled with the inner of the pumpkin"),
           new Item(2, "catears", "fluffy, cute and just adorable"),
           new Item(3, "catears", "fluffy, cute and just.. wait?"),
           new Item(4, "Bow", "A bow, so your pumpkin always looks like they got important tasks to do")       
        };
    }
}
