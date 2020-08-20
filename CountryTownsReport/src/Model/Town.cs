﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CountryTownsReport.Model
{
    public class Town
    {
        //Attributes
        public string name;
        public string id;

        //Constructor
        public Town(string name, string id) {
            this.name = name;
            this.id = id;
        }

        //Methods
        public override string ToString(){
            return name+", "+id;
        }
    }
}