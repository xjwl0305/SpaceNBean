using System;
using System.IO;

namespace SpaceAndBean.IO
{
    public class Access
    {
        public static bool IsAccessAble(String path)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }

            catch (IOException)
            {
                //에러가 발생한 이유는 이미 다른 프로세서에서 점유중이거나.

                //혹은 파일이 존재하지 않기 때문이다.

                return false;
            }

            finally
            {
                if (fs != null)
                {
                    //만약에 파일이 정상적으로 열렸다면 점유중이 아니다.
                    //다시 파일을 닫아줘야 한다.

                    fs.Close();
                }
            }
            return true;

        }
    }
}