using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Controls.Dialogs;
using LotusAPI.HW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGround {

    public class RegistryVariable {
        public static void Example() {
            //reload value from registry on read
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
            CameraDevice some_obj = null; //....
            DialogUtils.ShowObjectPropertyDialog(
                some_obj,         //object to be edited
                "Camera setting", //title
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
        }


    }

    public class CameraExample {
        //Array of cameras
        static CameraDevice[] cams = null;
        public static void CameraConnectExample() {
            //Create a new multi camera form
            var f = new FormMultiCamera();

            //user clicked ok?
            if(f.ShowDialog() == DialogResult.OK) {
                //read the camera array setting file
                var json_data = Json.ReadFromFile("camera_setting_file_path");
                //connect from json
                cams = LotusAPI.HW.Utils.ConnectCameraArray(json_data);

                //optimize bandwidth
                LotusAPI.HW.Utils.OptimizeBandwidth(
                    //Camera array
                    cams,
                    //Prefered packet size
                    9000,
                    //Percentage of reserved bandwidth
                    10);
            }


            //use camera
            var cam0 = cams[0];
            //capture 1 frame
            //start the acquisition
            cam0.StartAcquisition();
            //trigger 1 frame
            cam0.Trigger();
            //capture
            var img = cam0.Capture();
            //stop the acquisition
            cam0.StopAcquisition();

        }



    }
}
