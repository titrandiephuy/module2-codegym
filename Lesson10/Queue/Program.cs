﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace linked_list_queue
{
  public class Node
  {
      public int key;
      public Node next;

      public Node(int key)
      {
          this.key = key;
          this.next = null;
      }
  }
}