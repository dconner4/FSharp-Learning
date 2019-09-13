module BinarySearchTree

    type Node<'a> =
        {mutable Left: Node<'a> option
         Curr:'a
         mutable Right: Node<'a> option}

    let left (node:Node<int>):Node<int> option = node.Left

    let right (node:Node<int>):Node<int> option = node.Right

    let data (node:Node<int>) = node.Curr
    
    let rec insert (key:int) (node:Node<int> option byref): Node<int> option =
        let mutable test:Node<int> option = None
        let test2:Node<int> option = 
            if (node = None) then
                let newNode = 
                    {Left = None 
                     Curr = key
                     Right = None}
                node <- Some newNode
                Some newNode
            elif (key < node.Value.Curr) then
                insert key &node.Value.Left
            elif (key > node.Value.Curr) then
                insert key &node.Value.Right
            else
                None
        test2

    let create (items:seq<int>): Node<int> = 
        let mutable root:Node<int> option = None
        for item in items do
            root <- insert item &root
        root.Value
    

    let sortedData node = failwith "You need to implement this function."