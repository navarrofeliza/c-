namespace Puzzles
{
    public class Programs
    {
        // Random Array
        static void RandomArray(){
            static void RandomArray(){
            List<int> randomList =  new List<int>();
            Random rand = new Random();
            for(int x = 0; x < 10; x++){
                randomList.Add(rand.Next(5, 25));
            }
            int[] numArray = randomList.ToArray();
            foreach(int val in randomList){
                Console.WriteLine(val);
            }

            int max = numArray[0];
            int min = numArray[0];
            int sum = numArray[0];
            for(int i = 0; i < numArray.Length; i++){
                if(numArray[i] < min){
                    min = numArray[i];
                }
                if(numArray[i] < max){
                    max = numArray[i];
                }
                sum += numArray[i];
            } 
            Console.WriteLine("Min = "+min+ " Max = "+max+".");
            Console.WriteLine("Sum of array values = "+sum+".");

        }
    }
     // Coin Flip
        static void CoinFlip(){
            List<int> randomList = new List<int>();

            Random rand = new Random();

            for(int x = 0; x < 100; x++){
                randomList.Add(rand.Next(5, 1000));
            }
            int[] numArray = randomList.ToArray();
            int sum = numArray[0];

            for(int i = 0; i < numArray.Length; i++){
                sum += numArray[0];
            }

            int randcoin = sum*101;
            randcoin = randcoin/51;
            Console.WriteLine(randcoin);

            string coin;
            if(randcoin % 2 != 0){
                coin = "Heads";
            } else{
                coin = "Tails";
            }
            Console.WriteLine("You flipped: "+coin+"!");
        }
        
        // Coin Flip Ratio
        static double TossMultipleCoins(int num){
            Console.WriteLine("You tossed the coin: "+num+" times");
            double headcount = 0; 
            double tailcount = 0;
            double ratioheadstotails = 0;

            Random rand = new Random();
            
            for(int x = 0; x < num; x++){
                int currrand = rand.Next(5,1000);
                if(currrand % 2 == 0){
                    headcount++;
                } else {
                    tailcount++;
                }
            }
            Console.WriteLine("Calculating Heads/Tails Ratio...");
            ratioheadstotails = (headcount/tailcount)*100;
            ratioheadstotails = Math.Round(ratioheadstotails, 2);
            Console.WriteLine("You asked to flip "+num+" coins. Done! Ratio of heads to tails was "+ratioheadstotails+"% heads to tails. I counted "+headcount+" heads and "+tailcount+" tails.");
            
            return ratioheadstotails;
        }
        // Names
        static void Names(string[] arr){
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++){
                int ran = rand.Next(0,arr.Length);
                string temp = arr[i];
                arr[i] = arr[ran];
                arr[ran] = temp;
                Console.Write(arr[ran] + " ");
            }
            Console.WriteLine(" ");
            List<string> newArray = new List<string>();
            for(int i = 0; i < arr.Length; i++){
                if( arr[i].Length > 5){
                    newArray.Add(arr[i]);
                }
            }
            for(int i = 0; i < newArray.Count; i++){
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine(" ");
        }
        static void Main(string[] args)
        {
            RandomArray();
            CoinFlip();
            TossMultipleCoins(100);
            string[] names = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Syndey"};
            Names(names);
        }
}
}