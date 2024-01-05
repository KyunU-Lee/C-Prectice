using Lotto_M_S.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_M_S
{
    internal class RandomCreator
    {
        /// <summary>
        /// 랜덤숫자발생기
        /// </summary>
        /// <returns>랜덤 숫자가 발생함</returns>
        public List<int> getRandomNumber(List<int> list) 
        {
            Random random = new Random();
            int randomNumber = 0;
            for(int index = 0; index < 6; index++) 
            { 
                randomNumber = random.Next(1, 45);

                while(list.Contains(randomNumber))
                {
                    randomNumber = random.Next(1, 45);
                }
                if (list[index] == -1)
                    list[index] = randomNumber;
            }

            bool isSameNumber = false;
            for(int index = 0; index < 6; index ++)
            {
                for(int innerindex = index+1; innerindex < 6; innerindex ++)
                {
                    if (list[index] == list[innerindex])
                        isSameNumber = true;
                }
            }

            if (isSameNumber) 
            {
                SameNumberNotice notice = new SameNumberNotice();
                notice.ShowDialog(); 
                list.Clear();
            }            
            

            return list;
        }
    }
}
