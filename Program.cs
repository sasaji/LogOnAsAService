namespace LogOnAsAService
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string accountName in args) {
                LsaUtility.SetRight(accountName, "SeServiceLogonRight");
            }
        }
    }
}
