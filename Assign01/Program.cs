MyList train = new MyList(8);
train.Append(8);
train.Append(12);
train.Append(24);

Node node = train.RemoveFromBack();
if(node == null){
Console.WriteLine("null");
}else{
    Console.WriteLine("Remove node: " + node.Data)
}

train.Print();

// Console.WriteLine("head value: " + train.Head.Data);
// Console.WriteLine("head value: " + train.Head.Next.Data);

// for(int i = 0; i < 10; i++){
//     train.Append(i);
// }

// train.Print();

Console.WriteLine("DONE");
