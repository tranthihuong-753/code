using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClass23IT4
{
    internal class quanLyPhongTro
    {
        // ket noi mongoDB va visual studio 
        void connect(string connection)
        {
            // Kieu du lieu var dung cho moi kieu du lieu nhung ma phai gan gia tri ngay luc khoi tao bien 
            // URL kết nối tới MongoDB
            var connectionString = "mongodb://localhost:27017/";
            // Tai mongodb.driver <Chuot phai trong Solution Explorer . Chon Managr Nuget Package> 
            var client = new MongoClient(connectionString);

            // Tên cơ sở dữ liệu và collection
            var databaseName = "quanLiPhongTro";
            var collectionName1 = "Building";
            var collectionName2 = "Room";
            var collectionName3 = "Contact";
            var collectionName4 = "Bill";
            var collectionName5 = "Client";
            var collectionName6 = "Host";

            //// Kết nối tới cơ sở dữ liệu và collection
            var database = client.GetDatabase(databaseName);
            var buildingCollection = database.GetCollection<BsonDocument>(collectionName1);
            var roomCollection = database.GetCollection<BsonDocument>(collectionName2);
            var contactCollection = database.GetCollection<BsonDocument>(collectionName3);
            var billCollection = database.GetCollection<BsonDocument>(collectionName4);
            var clientCollection = database.GetCollection<BsonDocument>(collectionName5);
            var hostCollection = database.GetCollection<BsonDocument>(collectionName6);

            // Tạo một vài tài liệu mẫu để chèn vào collection
            // Building 
            var documents = new[]
            {
                new BsonDocument { { "_id", "ID001" }, { "name", "cho" }, { "age", 18 } },
                new BsonDocument { { "_id", "ID002" }, { "name", "meo" }, { "age", 18 } },
                new BsonDocument { { "_id", "ID003" }, { "name", "su tu" }, { "age", 18 } }
            };

            //// Chèn các tài liệu vào collection
            //await collection.InsertManyAsync(documents);
            //Console.WriteLine("Documents inserted successfully.");

            //// Tìm và hiển thị tất cả các tài liệu trong collection
            //var allDocuments = await collection.Find(new BsonDocument()).ToListAsync();
            //foreach (var document in allDocuments)
            //{
            //    Console.WriteLine(document.ToString());
            //}
        }
        static void Main(string[] args)
        {

        }
    }
}
