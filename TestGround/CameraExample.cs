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


            //Camera capture thread
            //create thread
            CameraCaptureThread capthread = new CameraCaptureThread();
            //change target fps
            capthread.CaptureFPS = 10;
            //set cameras
            capthread.SetCameras(cams);
            //or alternatively
            //capthread.SetCameras(cam0, cam1,cam2, ...);



            //setup handler
            capthread.ImageReceived += Capthread_ImageReceived;


            //start capturing
            capthread.Start();

            //pause
            capthread.Pause();
            //resume and restart timing engine, i.e. t=0
            capthread.Resume();
            capthread.RestartTimingEngine();

            //stop capturing
            capthread.Stop();



        }

        //Images captured by camera thread are synchronized (software or hardware trigger)
        private static void Capthread_ImageReceived(
            List<LotusAPI.MV.Image> imgs, //list of captured images
            int frame_id,                 //frame id since beginning
            double time) {                //time since beginning
            //process image here...
            //...
        }
    }
}
