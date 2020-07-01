using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.MV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.Drawing.Design;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using LotusAPI.Controls.Editors;
using LotusAPI.Controls.Dialogs;
using LotusAPI.HW;
using TestGround.Properties;
using LotusAPI.Data;

namespace TestGround {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            logView1.ShowDateTime = true;
            Logger.Add(new LogViewLogger(logView1));
            Library.Initialize();
            Global.Init();


            TicToc tt = new TicToc();
            //creating table
            Database db = new SqliteDatabase("D:/sqlite.db");
            //Database db = new SqlExpressDatabase("localhost\\SQLEXPRESS", "Result10");
            if(!db.Connect()) {
                Logger.Error("Failed to connect to database");
            }
            else {

                Table tb = new Table("MyResult");

                tb.AddColumns(
                    new IntColumn("ID", 0),
                    new DatetimeColumn("Date"),
                    new CharColumn("Result", "NG", 2),
                    new FloatColumn("Float"),
                    new DoubleColumn("DoubleVar"),
                    new TextColumn("Text")
                );

                db.AddTable(tb);


                //using(var transaction = db.BeginTransaction()) {
                tt.Tic();
                for(int i = 0; i < 10000; i++) {
                    dynamic row = tb.NewRow();
                    row.ID = int.Parse(db.ExecuteQuery("SELECT COUNT(*) FROM MyResult").Rows[0][0].ToString());
                    row.Date = DateTime.Now;
                    row.Result = i % 2 == 0 ? "OK" : "NG";
                    row.Float = (float)(1.2345678f + i);
                    row.DoubleVar = 0.5678923453453120 * i;
                    row.Text = $"hello {i}";
                    tb.InsertRow(row);
                }
                //transaction.Commit();
                //}
                Logger.Debug("Db row insert Elapsed: " + tt.Elapsed);
            }

            return;
            dynamic settings = new SettingObject();

            //object a = DateTime.Now.ToString("").ToString("");
            object b = 3.14345346.ToString("0.000");
            b = DateTime.Now;
            //settings.Add(
            //    new SettingObject.Property("ShortName", 1),
            //    new SettingObject.Property("BoolValue", false),
            //    new SettingObject.Property("IntValue", 3),
            //    new SettingObject.Property("DoubleValue", 3.1415),
            //    new SettingObject.Property("StringValue", "Hello world", typeof(JsonFileLocationEditor)));

            settings.AddProperty("BoolValue", false);
            settings.AddProperty("ShortName", 1);
            settings.AddProperty("IntValue", 3);
            settings.AddProperty("DoubleValue", 5);
            settings.AddProperty("StringValue", "hello", typeof(JsonFileLocationEditor));

            int sum = 0;
            tt.Tic();
            for(int i = 0; i < 1000000; i++) {
                sum += settings.ShortName;
            }
            Logger.Debug("Setting Elapsed=" + tt.Elapsed);
            tt.Tic();
            sum = 0;
            for(int i = 0; i < 1000; i++) {
                sum += Registry.GetIntValue("ShortName", 1);
            }
            Logger.Debug("Reg Elapsed=" + tt.Elapsed);
            Logger.Debug("sum=" + sum);

            //settings.BoolValue = false;
            //settings.IntValue = 5;
            //settings.DoubleValue = 7;
            //settings.StringValue = "beo";
            //var vint = settings.IntValue;
            //settings["BoolValue"].Value = true; 
            //var vv = settings["BoolValue"].Value;

            //Logger.Debug(settings["BoolValue"].ToString());

            flatPropertyGrid1.SelectedObject = settings;
            //propertyGrid1.SelectedObject = settings;
            //flatPropertyGrid1.PropertyValueChanged += FlatPropertyGrid1_PropertyValueChanged; ;

            //settings.PropertyChangedEvent += Settings_PropertyChangedEvent;

            Logger.Debug(settings.ToJson().ToString());

            //(new LotusAPI.HW.Dialogs.FormMultiCamera()).Show();

            //var cams = LotusAPI.HW.Utils.ConnectCameraArray(Json.ReadFromFile("D:/cam.json"));
            //LotusAPI.HW.Utils.OptimizeBandwidth(cams, 9000, 10);
            //LotusAPI.HW.Utils.SaveCameraArraySetting(cams, "D:/optimized_cams.json");

            //var cam = cams[0];

            //cam?.StartAcquisition();
            //cam?.Trigger();
            //var img = cam?.Capture();
            //Logger.Debug(img?.ToString());
            //cam?.StopAcquisition();
            //cam?.Disconnect();
            //(new FormConnectCameraArray()).Show();
        }

        //private void Settings_PropertyChangedEvent(object sender, SettingObject.Property e) {
        //    Logger.Debug(e.Name + "= " + e.ToString());
        //}
    }
}
