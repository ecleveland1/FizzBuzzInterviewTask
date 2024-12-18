namespace FizzBuzzLib
{
    //Main Task
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange
    {        
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }
        
        public string FizzBuzzifyAnInt(int input) {

            string result; //Result string

            if(input % 3 == 0){ //Fizz
                result = "Fizz";
            }
            else if(input % 5 == 0){ //Buzz
                result = "Buzz";
            }
            else if(input % 3 == 0 && input % 5 == 0){ //FizzBuzz
                result = "FizzBuzz";
            }
            else{ //Input
                result = input;
            }

            return result;
        }

        public IEnumerable<string> FizzBuzzValuesForRange(int start, int end){
            for(int i = start; i < end; i++){
                yield return FizzBuzzifyAnInt(i);                 
            }        
        }        
    }    
}
