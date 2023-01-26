MyList train = new MyList(8);
train.Append(12);

Console.WriteLine("head value: " + train.Head.Data);
Console.WriteLine("head value: " + train.Head.Next.Data);

// for(int i = 0; i < 10; i++){
//     train.Append(i);
// }

// train.Print();

Console.WriteLine("DONE");
