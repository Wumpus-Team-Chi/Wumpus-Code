using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WumpusTest
{
    class Trivia
    {
        private Trivia _Trivia;

        public int BottomlessPit()
        {
            Random gen = new Random(); // I still do not know the C++ version of this
            int wins;
            for(int i = 0; i < 3; i++){
                int question = AskQuestion();
                if(question == 1){
                    wins++;
                }else{
                    losses++;
                }
            }
            if(wins < losses){
                return -1;
            }else if(wins > losses){
                int roomNumber = gen.nextInt();
                return roomNumber
            }
        }

        public int WumpusRoom(){
            Random gen = new Random(); // I still do not know the C++ version of this
            int wins;
            for(int i = 0; i < 5; i++){
                int question = AskQuestion();
                if(question == 1){
                    wins++;
                }else{
                    losses++;
                }
            }
            if(wins > losses){
                return -1;
            }else if(wins < losses){
                int roomNumber = gen.nextInt();
                return roomNumber
            }
        }
        
        public int AskQuestion(){
            answer = 0;
            return answer;
        }
    }
}
