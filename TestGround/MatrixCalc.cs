using LotusAPI.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MU = LotusAPI.Math.Utils;

namespace TestGround {
    public class MatrixCalc {
        public static void MatrixVectorCalcExample() {
            //Create some 4x4 matrix
            Matrix44d H = new Matrix44d(1, 2, 3, 4,
                                        5, 6, 7, 8,
                                        9, 10, 11, 12,
                                        13, 14, 15, 16);

            //H = [  [R3]  T3]
            //    [ 0 0 0  1 ]
            //get 3x3 sub matrix (rotation matrix in homogeneous 4x4)
            var R = H.R3;
            //get 3x1 sub matrix (translation vector in homogeneous 4x4)
            var t = H.T3;


            //
            Matrix44d K = new Matrix44d();


            //matrix operation
            //inversion
            var Hi = H.Inv();
            //transpose
            var Ht = H.Transpose();
            //calc norm
            var norm = H.Norm();
            //set identity
            H.SetIdentity();

            //Linear algebra
            H = (3 * H + K / 3) * 3.25;

            //Create 3d vector
            var v1 = new Vector3d(1, 2, 3);

            //rotate vector using [R,t]
            var v2 = R * v1 + t;

            //or using directly H
            // v1 is 3x1 vector
            var v3 = H * MU.ToHomogeneous(v1);
            //convert back to 3x1
            var v4 = MU.FromHomogeneous(v3);

            //Vector arithmetic
            var v5 = (4 * v2 + 2 * v1) / 0.5;


            
        }
    }
}
