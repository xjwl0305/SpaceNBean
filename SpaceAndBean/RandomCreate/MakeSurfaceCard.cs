using System;
using System.Collections;

namespace SpaceAndBean.RandomCreate
{
    public class MakeSurfaceCard
    {

        // Material Index를 뽑아온다
        public static ArrayList GetMaterialList(ArrayList MaterialCardArrayList)
        {
            ArrayList MaterialList = new ArrayList();
            for (int i = 0; i < MaterialCardArrayList.Count; i++)
            {
                String[] line = (String[])MaterialCardArrayList[i];
                if (line[0].Equals(""))
                {
                    continue;
                }

                MaterialList.Add(i);
            }

            return MaterialList;
        }
        
        public static ArrayList Make(ArrayList MaterialCardArrayList, double pxStart, double pxEnd, double pyStart, double pyEnd, double pzStart, double pzEnd )
        {
            Random random = new Random();
            ArrayList MaterialList = GetMaterialList(MaterialCardArrayList);
            double currentPz = pzStart;
            var cellCardArray = new ArrayList();
            
            double px1 = pxStart;
            double px2 = pxEnd;
            double py1 = pyStart;
            double py2 = pyEnd;
            

            while (currentPz < pzEnd)
            {
                // randomIndex : MaterialCardArrayList 의 인덱스 ( CEll Card 만들 때, 매칭하기 위해 필요함)
                int randomIndex = (int)MaterialList[random.Next(0, MaterialList.Count)];
                String[] line = (String[])MaterialCardArrayList[randomIndex];
                double pz1 = currentPz;
                double pz2 = currentPz + Double.Parse(line[4]);

                cellCardArray.Add(new double[] {px1, px2, py1, py2, pz1, pz2, randomIndex });
                currentPz +=  Double.Parse(line[4]);
            }
            
            int index = 4;
            var resultArray = new ArrayList();
            for (int i = 0; i < cellCardArray.Count; i++)
            {
                String[] data1 = {(100).ToString(), ((double[])cellCardArray[i])[0].ToString(),
                    (101).ToString(), ((double[])cellCardArray[i])[1].ToString(), (102).ToString(), ((double[])cellCardArray[i])[2].ToString(),
                    (103).ToString(), ((double[])cellCardArray[i])[3].ToString(), (index++ + 100).ToString(), ((double[])cellCardArray[i])[4].ToString(),
                    (index++ + 100).ToString(), ((double[])cellCardArray[i])[5].ToString(), ((double[])cellCardArray[i])[6].ToString()
                };
                resultArray.Add(data1);
            }

            return resultArray;
            
        }
        
        
        
        
        
    }
}