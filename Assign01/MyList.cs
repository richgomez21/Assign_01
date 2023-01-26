public class MyList{

    public Node? Head {get; set;}
    public int Length {get; set;}

    public MyList(){
        this.Head = null;
    }

    public MyList(int data){
        this.Head = new Node(data);
        this.Length++;
    }

    //=================================================
    //TODO: implement all of the below methods.
    //=================================================

    public void Print(){
        //prints all values in the list starting from the head and traversing down to the tail
         Node curNode = this.Head;
         while(curNode != null){
            Console.WriteLine(curNode.Data);
            curNode = curNode.Next;

        } 
    }

    public void Append(int data){
        //creates a node with the data passed and adds the node to the end of the list
        Node newNode = new Node(data);
        if(this.Head == null){
            // The list is empty
            this.Head = newNode;
          
        
        }else if(this.Length == 1){
            this.Head.Next = newNode;
          
        
        }else{
            // There are two or more items in the list
            Node curNode = this.Head;
            while(curNode.Next != null){
                curNode = curNode.Next;
            } 

            curNode.Next = newNode;
        }

        this.Length++;
    }

    public void PrePend(int data){
        //creates a node with the data passed and prepends the node passed to the beginning of the list. This node will now be the new head of the list.
        
    }

    public void Insert(int data, int index){
        //creates a node with the data passed and inserts the node to desired "index" in list with the head being considered index 0 for the count.

        //Hint: if index == 0 or if index == this.Length-1, think of how we can reuse methods we already have written
        //in order to reduce what we write for this method.
    }

    public Node? RemoveFromFront(){
        //removes the head node from the list and returns node.
        //the new head will be the next node in the list.
        
        return null;
    }

    public Node? RemoveFromBack(){
        //removes the last node in the list and returns that node.

        return null;
    }

}