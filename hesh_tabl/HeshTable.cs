public class HashTable
{
    private Dictionary<byte, string> table;

    public HashTable()
    {
        table = new Dictionary<byte, string>();
    }

    public byte Add(string word)
    {
        byte hash = CalculateHash(word);
        table[hash] = word;
        return hash;
    }

    public string Get(byte hash)
    {
        if (table.ContainsKey(hash))
            return table[hash];
        else
            return null;
    }

    private byte CalculateHash(string word)
    {
        byte hash = 0;
        foreach (char c in word)
        {
            hash += (byte)c;
        }
        return hash;
    }
}