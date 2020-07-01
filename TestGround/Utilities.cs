using LotusAPI;
using LotusAPI.HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGround {


    public class LotusAPI_Utilities {

        [JsonSerializable]
        public class MyDataClass {
            //Default constructor is required
            public MyDataClass() { }

            //properties
            public int MyIntValue { get; set; } = 10;
            public double MyDoubleValue { get; set; } = 20;
            public string MyStringValue { get; set; } = "Hello";

            //skip json read/write
            [JsonSkip]
            public double SomeOtherStuff => MyIntValue + MyDoubleValue;
        }

        public static void DialogUtilitiesExample() {
            //ask for confirmation
            if(DialogUtils.AskForConfirmation("Are you sure?")) {
                //do something
            }

            //ask for permission (with password)
            if(DialogUtils.AskForPermission()) {
                //do something
            }

            //show error message box
            DialogUtils.ShowErrMsg("error message");
            //show info message box
            DialogUtils.ShowInfoMsg("info message");

            //show folder browser, 
            //the latest user accessed path will be stored
            DialogUtils.ShowFolderBrowserDialog("Title");

            // Show object editor dialog
            MyDataClass some_obj = new MyDataClass(); //....
            DialogUtils.ShowObjectPropertyDialog(
                some_obj,         //object to be edited
                "My data",        //title
                null);            //(optional) help image


            //show open file dialog
            var path = DialogUtils.ShowOpenFileDialog("dialog title", "filter");
            //show save file dialog
            path = DialogUtils.ShowSaveFileDialog("dialog title", "filter");

            //show open image file dialog
            path = DialogUtils.ShowOpenImageFileDialog("dialog title");
            //show save image file dialog
            path = DialogUtils.ShowSaveImageFileDialog("dialog title");

            //JSON
            path = DialogUtils.ShowOpenJsonFileDialog("dialog title");
            path = DialogUtils.ShowSaveJsonFileDialog("dialog title");
            //PLY
            path = DialogUtils.ShowOpenPlyFileDialog("dialog title");
            path = DialogUtils.ShowSavePlyFileDialog("dialog title");

            //Directory
            IOUtils.DirectoryCopy(
                "D:/dir1",      //source directory
                "D:/dir2",      //target directory
                true,           //copy recursively
                true);          //overwrite

            //JSON
            MyDataClass myobj = new MyDataClass();
            //convert object to j son
            var jdata = JsonUtils.ToJson(myobj);

            //read json data file
            Json jdata1 = Json.ReadFromFile("D:/data.json");
            //Target Object must be:
            // - Default constructible
            // - Defined with JsonSerializable attribute
            var myobj1 = JsonUtils.Read<MyDataClass>(jdata1);


            //NETWORK UTILITIES
            //<awaitable>
            var host_alive = NetUtils.PingHost("192.168.1.1");


            //THREAD SAFE FLAG
            //create a thread-safe flag with initial state
            //this flag can be bool or int
            ThreadSafeFlag flag = new ThreadSafeFlag(false);
            //set new value (bool or int)
            flag.Set(true);
            // flag.Set(10);

            //get bool flag
            bool ok = flag.Get();
            //get int value
            int state = flag.GetInt();


        }



    }
}
