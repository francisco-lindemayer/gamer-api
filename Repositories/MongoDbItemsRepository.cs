using System;
using System.Collections.Generic;
using GamerApi.Entities;
using GamerApi.Repositories;
using MongoDB.Driver;

namespace GamerApi.Properties
{
  public class MongoDbItemsRepository : IItemsRepository
  {

    private const string databaseName = "game";
    private const string collectionName = "items";
    private readonly IMongoCollection<Item> itemsCollection;
    public MongoDbItemsRepository(IMongoClient mongoClient)
    {
      IMongoDatabase database = mongoClient.GetDatabase(databaseName);
      itemsCollection = database.GetCollection<Item>(collectionName);
    }
    public void CreateItem(Item item)
    {
      itemsCollection.InsertOne(item);
    }

    public void DeleteItem(Guid id)
    {
      throw new NotImplementedException();
    }

    public Item GetItem(Guid id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Item> GetItems()
    {
      throw new NotImplementedException();
    }

    public void UpdateItem(Item item)
    {
      throw new NotImplementedException();
    }
  }
}