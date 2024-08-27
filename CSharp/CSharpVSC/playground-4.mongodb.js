// // /* global use, db */
// // // MongoDB Playground
// // // Use Ctrl+Space inside a snippet or a string literal to trigger completions.

// // const database = 'new';
// // const collection = 'newconnect';

// // // Create a new database.
// // use(database);

// // // Create a new collection.
// // db.createCollection(collection);

// // Chuyển đến cơ sở dữ liệu 'new'
// use('new')

// // Chèn tài liệu vào collection 'newconnect'
// db.newconnect.insertMany([
//     // { _id: "ID001", name: "Alice", age: 25 },
//     // { _id: "ID002", name: "Bob", age: 30 },
//     { _id: "ID003", name: "Charlie", age: 35 }
// ]);

db.newconnect.find({ name: "Dog" });

// The prototype form to create a collection:
/* db.createCollection( <name>,
  {
    capped: <boolean>,
    autoIndexId: <boolean>,
    size: <number>,
    max: <number>,
    storageEngine: <document>,
    validator: <document>,
    validationLevel: <string>,
    validationAction: <string>,
    indexOptionDefaults: <document>,
    viewOn: <string>,
    pipeline: <pipeline>,
    collation: <document>,
    writeConcern: <document>,
    timeseries: { // Added in MongoDB 5.0
      timeField: <string>, // required for time series collections
      metaField: <string>,
      granularity: <string>,
      bucketMaxSpanSeconds: <number>, // Added in MongoDB 6.3
      bucketRoundingSeconds: <number>, // Added in MongoDB 6.3
    },
    expireAfterSeconds: <number>,
    clusteredIndex: <document>, // Added in MongoDB 5.3
  }
)*/

// More information on the `createCollection` command can be found at:
// https://www.mongodb.com/docs/manual/reference/method/db.createCollection/
