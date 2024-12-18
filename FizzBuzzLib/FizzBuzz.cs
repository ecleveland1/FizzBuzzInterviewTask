namespace FizzBuzzLib
{
    //Extended Task
    public class FizzBuzz : IFizzBuzz, IFizzBuzzRange, IFlexiFizzBuzz
    {        
        public string DemoMethod()
        {
            // Feel free to delete this method

            return "Hello World";
        }
        
        Dictionary<int,string> pairs = new Dictionary<int,string>()
        {
             {3, "Fizz"},
             {5, "Buzz"}
        };

        Dictionary<int,string> ReplacementPairs { get; }
        
        public string FizzBuzzifyAnInt(int input) {

            string result; //Result string

            if(input % 3 == 0){ //Fizz
                result = pairs[3];
            }
            else if(input % 5 == 0){ //Buzz
                result = pairs[5];
            }
            else if(input % 3 == 0 && input % 5 == 0){ //FizzBuzz
                result = pairs[3] + pairs[5];
            }
            else{ //Input
                if(pair.ContainsKey(input)){
                    result = pairs[input];
                }
                else{
                    result = input;
                }                
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
}
