namespace CSVtoJson
{
    internal class Data
    {
        public List<Record> Records { get; set; } = new List<Record>();

        public void AddRecord(Record rec)
        {
            Records.Add(rec);
        }
    }
}
