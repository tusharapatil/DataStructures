using System;

namespace LinkedLists
{
    #region linked list info
    /*
     linear data structure (physical) variable size node = value + reference to next node
     head + nodes + tail --> tail is used to reduce time complexity while adding node at end
     Linked list                                         Array
     each element(node) separate object                  Array as whole single object cells can not 
     node can be deleted (+)                             be deleted (-)                            
     variable size (+)                                   fixed size (-)
     Sequential access to node(-)                        random access(+)
     single LL node -> value + next node reference .... no reference to previous node --> can only traverse forward
     add remove nodes at runtime
     circular single LL --> same single LL only last node has reference of first node.
     
     double LL --> node = ref to prev node + value + ref to next node --> can traverse forward and backward
     circular double LL --> last node's next node has ref of first node and first node's prev node had ref of last node

     
         */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
