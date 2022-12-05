using System;
using System.Collections;

namespace SpaceAndBean.RandomCreate
{
    public class MakeSurfaceCard
    {

        //px1 px2 py1 py2 pz1 pz2
        public static bool checkOverlap(double[] arr1, double[] arr2)
        {
            return (arr1[0] < arr2[1] || arr1[0] > arr2[1] || arr1[2] > arr2[3] || arr1[2] < arr2[3] || arr1[4] > arr2[5] || arr1[4] < arr2[5]);
        }
        public static ArrayList Make(int cellCardCount, double pxStart, double pxEnd, double pyStart, double pyEnd, double pzStart, double pzEnd )
        {
            Random random = new Random();

            double width = pxEnd - pxStart;
            double height = pyEnd - pyStart;
            double depth = pzEnd - pzStart;
            
            int i = 0;      // 셀카드 index
            var cellCardArray = new ArrayList();
            while (i < cellCardCount)
            {
                double px1 = random.NextDouble() * width;
                double px2 = random.NextDouble() * width;

                double py1 = random.NextDouble() * height;
                double py2 = random.NextDouble() * height;
            
                double pz1 = random.NextDouble() * height;
                double pz2 = random.NextDouble() * height;

                if (px1 > px2)
                {
                    var temp = px1;
                    px1 = px2;
                    px2 = px1;
                }
            
                if (py1 > py2)
                {
                    var temp = py1;
                    py1 = py2;
                    py2 = py1;
                }
            
                if (pz1 > pz2)
                {
                    var temp = pz1;
                    pz1 = pz2;
                    pz2 = pz1;
                }

                px1 = px1 + pxStart;
                px2 = px2 + pxStart;

                py1 += pyStart;
                py2 += pyStart;

                pz1 += pzStart;
                pz2 += pzStart;

                double[] box1 = new[] { px1, px2, py1, py2, pz1, pz2 };
                bool flag = false;
                for (int j = 0; j < cellCardArray.Count; j++)
                {
                    double[] box2 = (double[])cellCardArray[j];
                    flag = checkOverlap(box1, box2);

                    if (flag)
                    {
                        break;
                    }
                    
                }

                if (flag)
                {
                    continue;
                }

                cellCardArray.Add(box1);
                i++;
            }

            return cellCardArray;
            
        }
    }
}