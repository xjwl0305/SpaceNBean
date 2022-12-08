using System;
using System.Collections;
using System.Linq;

namespace SpaceAndBean.RandomCreate
{
    public class MakeCellCard
    {
        public static ArrayList Make(ArrayList materialCardArray, ArrayList surfaceCardArray)
        {
            int startIndex = 0;

            for (int i = 0; i < surfaceCardArray.Count; i++)
            {
                if ( ((String[])surfaceCardArray[i])[0] == "100")
                {
                    startIndex = i;
                    break;
                }
            }
            
            
            //material이랑 surface랑 매칭시켜야함
            var cellCardArray = new ArrayList();
            int surfaceCardCount = surfaceCardArray.Count - startIndex;
            int materialCardCount = materialCardArray.Count;
            

            int[] checkSurface = Enumerable.Range(startIndex, surfaceCardCount).ToArray();
            ArrayList checkSurfaceArrayList = new ArrayList();
            checkSurfaceArrayList.AddRange(checkSurface); 
            
            //int[] checkMaterial = Enumerable.Range(0, materialCardCount - 1).ToArray();
            //ArrayList checkMaterialArrayList = new ArrayList();
            //checkMaterialArrayList.AddRange(checkMaterial);
            
            Random random = new Random();
            Random random1 = new Random();

            for (int i = 0; i < surfaceCardCount; i++)
            {
                int randomIndex = 0;
                if(checkSurfaceArrayList.Count <= 1)
                    randomIndex = 0;
                else
                    randomIndex = random.Next(0, checkSurfaceArrayList.Count - 1);
                int indexSurface = (int)checkSurfaceArrayList[randomIndex];
                checkSurfaceArrayList.RemoveAt(randomIndex);
                
                
                int randomIndex1 = random1.Next(0, materialCardCount - 1);
                //int indexMaterial = (int)materialCardArray[randomIndex1];
                
                String material = ((String[])materialCardArray[randomIndex1])[0].Replace("m", "");
                String px1 = ((String[])surfaceCardArray[indexSurface])[0];
                String px2 = "-" + ((String[])surfaceCardArray[indexSurface])[2];
                String py1 = ((String[])surfaceCardArray[indexSurface])[4];
                String py2 = "-" + ((String[])surfaceCardArray[indexSurface])[6];
                String pz1 = ((String[])surfaceCardArray[indexSurface])[8];
                String pz2 = "-" + ((String[])surfaceCardArray[indexSurface])[10];
                
                //int indexMaterial = checkMaterial[randomIndex1] 
                
                String[] data =
                {
                    (i+100).ToString(), material, "", 
                    px1 + " " + px2 + " " + py1 + " " + py2 + " " + pz1 + " " + pz2, "imp:p=1", "imp:n=1"
                };
                cellCardArray.Add(data);


            }

            return cellCardArray;

        }
    }
}