using CSVtoJson;
using FileHelpers;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var fileHelperEngine = new FileHelperEngine<Record>();
        var records = fileHelperEngine.ReadFile(@"csv/assigned.csv");
        Data data = new();
      
        for (int i = 1; i < records.Length; i++)
        {
            data.AddRecord(records[i]);
            Console.Write(records[i].DispatchAdvice + " ");
            Console.Write(records[i].Order + " ");
            Console.Write(records[i].Ref + " ");
            Console.Write(records[i].OrderType + " ");
            Console.Write(records[i].Received + " ");
            Console.Write(records[i].Required + " ");
            Console.Write(records[i].Consignee + " ");
            Console.Write(records[i].Ctry + " ");
            Console.Write(records[i].Lines + " ");
            Console.Write(records[i].Items + " ");
            Console.WriteLine(records[i].NoCat);
        }
        string output = JsonConvert.SerializeObject(data);
        using StreamWriter sw = new("this.json");
        sw.WriteLine(output);
       
      

    }
}