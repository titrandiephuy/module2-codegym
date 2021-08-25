using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Animal_Management_System
{
    interface IAnimal
    {
        int ID { get; set;}
        string? Name { get; set;}
        int Age { get; set;}

    }
}