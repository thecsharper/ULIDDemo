// https://medium.com/codenx/uuid-and-ulid-in-net-maximizing-efficiency-in-unique-identifiers-a94c41177128

var newUlid = Ulid.NewUlid();
Console.WriteLine(newUlid.ToString());