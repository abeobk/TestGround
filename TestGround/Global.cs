using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Controls.Editors;
using LotusAPI.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGround {
    //Global setting variable class
    public class MySetting : SettingObject {
        //! Use const string Key name to prevent string typo
        public const string KEY_INT_VALUE = "IntValue";
        public const string KEY_DOUBLE_VALUE = "DoubleValue";
        public const string KEY_STRING_VALUE = "StringValue";
        public const string KEY_JSONFILE_PATH = "JsonFilePath";

        // Constructor
        // Initialize setting variables here
        public MySetting()
            : base("Settings") {                  //Registry parent key
            //Int property
            //AddProperty_<string>(
            //    KEY_STRING_VALUE,
            //    //Default value (optionnal)
            //    "some string",
            //    //Editor type (optional)
            //    typeof(JsonFileLocationEditor),
            //    //Display name (optional), use parameter key if not specified
            //    "A string value",
            //    //Description (optional), default =""
            //    "This is a string value",
            //    //Browsabe  (optional), default = true
            //    true,
            //    //Read only (optional), default = false
            //    true);

            // Currently supported types: bool, int, double, string

            //*** NOTE: KEYs must be unique

            AddProperty_<int>(KEY_INT_VALUE, 1);
            AddProperty_<double>(KEY_DOUBLE_VALUE, 1);
            AddProperty_<string>(KEY_STRING_VALUE, "some string");
            AddProperty_<bool>("MyBool", false);
            AddProperty_<string>(KEY_JSONFILE_PATH, "some string",
                typeof(JsonFileLocationEditor));
        }
    }

    public class Global {

        //Setting
        public static MySetting Setting { get; set; } = new MySetting();

        public static void Init() { }

        public static void APIExample() {
            //set value
            // will throw if given value is not (int)
            Setting[MySetting.KEY_INT_VALUE].Value = 5;

            //get value
            // will throw if value type is not (int)
            int i = Setting[MySetting.KEY_INT_VALUE];

            //Setting.ToJson():

            //Logger usage

            Logger.Log("normal log message");
            Logger.Debug("debug message");
            Logger.Trace("trace message");
            Logger.Warn("warn message");
            Logger.Info("info message");
            Logger.Error("error message");
            Logger.Fatal("fatal error message");


            //Measure time
            TicToc tt = new TicToc();
            tt.Tic();
            //Do something that takes time
            // ....
            var elapsed_ms = tt.Toc();
            Logger.Debug($"Working time: {elapsed_ms}ms");


            //DATABASE

            Database db = null;
            //SQLite database init
            db = new SqliteDatabase("D:/dbfile.db");

            //SQLite database init
            db = new SqlExpressDatabase(
                "localhost\\SQLEXPRESS", //host name
                "DbName",                //db name
                "..."                    //(optional) extra string ...
                );

            //usage
            //Define a table with given name
            Table tbl = new Table("MyTable");

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

            //Create a new row 
            var row = tbl.NewRow();
            row[COL_ID] = 0;
            row[COL_DATE] = DateTime.Now;
            row[COL_X] = 0.123;
            row[COL_Y] = 0.456;
            row[COL_Z] = 0.789;
            row[COL_OK] = true;
            row[COL_PATH] = "somewhere i belong";
            //and insert to the database
            tbl.InsertRow(row);
            //
        }

    }
}
