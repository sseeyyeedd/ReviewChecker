namespace ReviewChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the review:");
                string review = Console.ReadLine();
                var sampleData = new SentimentModel.ModelInput()
                {
                    Col0 = review
                };
                var result = SentimentModel.Predict(sampleData);
                var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
                Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");
            }
            
        }
    }
}
