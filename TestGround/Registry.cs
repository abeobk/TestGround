﻿using LotusAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGround {
    public class RegistryVariable {
        public static void Example() {
            //reload value from registry on read
            //only set this thing to true if you want the variable to be
            //reloaded when your app is running
            Registry.ReloadOnRead = true;

            //Define an integer value
            Registry.IntValue int_value = new Registry.IntValue(
                "MySetting",    //setting parent key
                "IntValue",     //key
                0);             //default value


            //Supported registry value type
            //Registry.BoolValue, Registry.DoubleValue,
            //Registry.IntValue, Registry.StringValue

            //usage
            //set value
            int_value.Value = 5;

            //get value
            int i = int_value;
        }
    }

}
