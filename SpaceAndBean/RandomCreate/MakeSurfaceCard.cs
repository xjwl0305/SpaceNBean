using System;
using System.Collections;

namespace SpaceAndBean.RandomCreate
{
    public class MakeSurfaceCard
    {

        //px1 px2 py1 py2 pz1 pz2
        public static bool checkOverlap(double[] arr1, double[] arr2)
        {
            return !(arr1[4] < arr2[5] || arr1[4] > arr2[5]);
        }
        public static ArrayList Make(int cellCardCount, double pxStart, double pxEnd, double pyStart, double pyEnd, double pzStart, double pzEnd )
        {
            Random random = new Random();
            
            double depth = pzEnd - pzStart;
            
            int i = 0;      // 셀카드 index
            var cellCardArray = new ArrayList();
            while (i < cellCardCount)
            {
                double px1 = pxStart;
                double px2 = pxEnd;

                double py1 = pyStart;
                double py2 = pyEnd;
            
                double pz1 = random.NextDouble() * depth;
                double pz2 = random.NextDouble() * depth;

                if (pz1 > pz2)
                {
                    var temp = pz1;
                    pz1 = pz2;
                    pz2 = temp;
                }
                

                pz1 += pzStart;
                pz2 += pzStart;

                px1 = Math.Round(px1, 2);
                px2 = Math.Round(px2, 2);
                
                py1 = Math.Round(py1, 2);
                py2 = Math.Round(py2, 2);
                
                pz1 = Math.Round(pz1, 2);
                pz2 = Math.Round(pz2, 2);

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
            
            
            int index = 0;
            var resultArray = new ArrayList();
            for (i = 0; i < cellCardArray.Count; i++)
            {
                String[] data1 = {(index++ + 100).ToString(), ((double[])cellCardArray[i])[0].ToString(),
                    (index++ + 100).ToString(), ((double[])cellCardArray[i])[1].ToString(), (index++ + 100).ToString(), ((double[])cellCardArray[i])[2].ToString(),
                    (index++ + 100).ToString(), ((double[])cellCardArray[i])[3].ToString(), (index++ + 100).ToString(), ((double[])cellCardArray[i])[4].ToString(),
                    (index++ + 100).ToString(), ((double[])cellCardArray[i])[5].ToString()
                };
                resultArray.Add(data1);
                
                
            }

            return resultArray;
            
        }
        
        
        
        
        
    }
}