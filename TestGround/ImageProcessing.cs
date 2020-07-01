using LotusAPI.MV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MU = LotusAPI.Math.Utils;
using MV = LotusAPI.MV;
using Limage = LotusAPI.MV.Image;
using System.Drawing;

namespace TestGround {
    public class ImageProcessing {
        public static void ImageProcExample() {
            Limage i0 = new Limage(new Size(100, 100), PixelType.Gray);
            Limage i1 = new Limage(new Size(100, 100), PixelType.Gray);

            //Smooth
            var i2 = i0.Smooth(SmoothMethod.Gaussian,  //smooth method
                            4);                        //radius

            //threshold
            var i3 = i1.Threshold(ThresholdType.Binary, //threshold method
                                   100,                  //threshold value
                                   255);                 //max value

            //adaptive threshold
            var i4 = i2.AdaptiveThreshold(AdaptiveMethod.Mean,  //adaptive type
                                          ThresholdType.Binary, //threshold type
                                          255,                  //max value
                                          5,                    //radius
                                          0);                   //constant relative threshold

            //image arithmetic
            var i5 = (3.1 * i2 + i1) / 2.4;

            //convert to rgb
            var rgb = i5.ToBGR();


            //split channel
            var chs = rgb.Split();

            //merge channels
            var i6 = Limage.Merge(chs);

            //pixel access
            Limage.BGR_PixelAccessor accessor = new Limage.BGR_PixelAccessor(rgb);
            uint row = 10;
            uint col = 20;
            //set pixel at (row, col) or (y,x)
            accessor[row, col] = Color.Lime;
            var pixel = accessor[row, col];
            //raw pointer unsafe access
            //get row pointer
            unsafe {
                byte* ptr = accessor.Ptr(row);
                //do unsafe operations...
                //high performance processing --> as fast as C++
            }


            //scale image
            var i7 = i6.Scale(0.5);

            //resize image
            var i8 = i7.Resize(new Size(50, 70), Interpolation.Nearest);

            //Many more...
            //rgb.DrawText(...);
            //rgb.Draw...



        }
    }
}
