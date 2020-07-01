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
using System.Diagnostics;
using Abeo.Controls.Roundable;
using LotusAPI.Math;

namespace TestGround {

    public partial class Form1 : Form {

        //
        Registry.BoolValue bval = new Registry.BoolValue("MySetting", "bval", false);
        Registry.IntValue ival = new Registry.IntValue("MySetting", "ival", 5);


        //return error code
        int DoSomething(int k = 3) {
            if(k == 1) return 2;
            else if(k == 43) return 5;
            return 0;
        }


        class RobotOfflineException: Exception {
            public override string Message => "Robot is not online"; 
        }
        class PLCOfflineException: Exception {
            public override string Message => "PLC is not online"; 
        }
        

        public Form1() {
            InitializeComponent();
            logView1.ShowDateTime = true;
            Logger.Add(new LogViewLogger(logView1));
            Library.Initialize();
            Global.Init();

            Library.NumberFormat = "0.000";

            Matrix44d A = new Matrix44d(1.23456389, 2, 3, 4,
                                        5, 6, 7, 8,
                                        9, 10, 11, 12,
                                        13, 14, 15, 16);

            //call some function
            //int err_code = DoSomething(43);
            //if(err_code != 0) {
            //    Logger.Error($"Some error message with code [{err_code}]");
            //}

            Logger.Debug("A=\n" + A);
            Logger.Debug("A*3-A=\n" + (A*3-A));
            Logger.Debug("I=\n" + Matrix44d.Eye());

            Vector4d v = new Vector4d(1, 23, 4, 5);

            Logger.Debug("v=\n" + v);
            Logger.Debug("A*v=\n" + (A*v));
            Logger.Debug("A*A=\n" + (A*A));

            Matrix44d B = new Matrix44d(1.23456389, 2, 3, 4,
                                        5, 6, 7, 8,
                                        9, 10, 11, 12,
                                        13, 14, 15, 16.2342345);
            Logger.Debug("Bi=\n" + (B.Inv()));
            Logger.Debug("Bi*B=\n" + (B.Inv()*B));

            
            //Error level
            // Normal, Debug, Trace, Warn, Info, Fatal


            //REGISTRY

            //Set value
            //bval.Value = true;
            ////read value
            //var ok = bval;
            //Logger.Debug("bval=" + ok);

            //

            //(new FormObjectProperty(Global.Setting,"MySettingDialog")).ShowDialog();


#if false
            Database db = null;
            //SQLite database init
            db = new SqliteDatabase("D:/dbfile.db");

            //SQLite database init
            //db = new SqlExpressDatabase(
            //    "localhost\\SQLEXPRESS", //host name
            //    "DbName",                //db name
            //    ""                    //(optional) extra string ...
            //    );

            db.Connect();

            //read table
            var dt = db.ExecuteQuery("select * from MyTable");
            dataGridView1.DataSource = dt;

            //usage
            //Define a table with given name
            Table tbl = new Table("MyTable");
            Table tbl1 = new Table("MyTable1");

            tbl1.AddColumns(new Column[] { 
                new IntColumn("ID"),
                new BoolColumn("BVal"),
                new TextColumn("Path"),
            });
            //add to database
            db.AddTable(tbl1);

            //Define columns names
            const string COL_ID = "ID";
            const string COL_DATE = "DATE";
            const string COL_X = "X";
            const string COL_Y = "Y";
            const string COL_Z = "Z";
            const string COL_OK = "OK";
            const string COL_PATH = "PATH";

            //add columns to table
            tbl.AddColumns(new Column[] {
                new IntColumn(COL_ID),
                new DatetimeColumn(COL_DATE),
                new FloatColumn(COL_X),
                new FloatColumn(COL_Y),
                new FloatColumn(COL_Z),
                new BoolColumn(COL_OK),
                new TextColumn(COL_PATH),
            });

            //add table to database;
            db.AddTable(tbl);

            //Create a new row 
            dynamic row = tbl.NewRow();
            //row.ID = 0;
            //row.DATE= DateTime.Now;

            row[COL_ID] = 0;
            row[COL_DATE] = DateTime.Now;
            row[COL_X] = (float)0.324345;
            row[COL_Y] = 0.456f;
            row[COL_Z] = 0.789f;
            row[COL_OK] = true;
            row[COL_PATH] = "somewhere i belong";
            //and insert to the database
            tbl.InsertRow(row);
            //
#endif

        }


        private void button1_Click(object sender, EventArgs e) {
            (new LotusAPI.HW.Dialogs.FormMultiCamera()).ShowDialog();
            //reaload camera setting
            Json camsetting = Json.ReadFromFile("D:/camers.json");
            //load camera form files
            var cams = LotusAPI.HW.Utils.ConnectCameraArray(camsetting);
            //opmize network
            Registry.IntValue _mtu = new Registry.IntValue("Network", "MTU", 1500);
            Registry.IntValue _reserve = new Registry.IntValue("Network", "ReservePercent", 20);

            //network bandwidth optimization
            LotusAPI.HW.Utils.OptimizeBandwidth(cams, _mtu, _reserve);

            //captures
            Captureshow(cams[0], roundImageView1);
            Captureshow(cams[1], roundImageView2);
            Captureshow(cams[2], roundImageView3);
            Captureshow(cams[3], roundImageView4);

        }
        void Captureshow(CameraDevice cam, RoundImageView iv) {
            try {
                cam.StartAcquisition();
                cam.Trigger();
                var img = cam.Capture();
                cam.StopAcquisition();
                iv.SetImage(img);
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        //private void Settings_PropertyChangedEvent(object sender, SettingObject.Property e) {
        //    Logger.Debug(e.Name + "= " + e.ToString());
        //}

    }
}
