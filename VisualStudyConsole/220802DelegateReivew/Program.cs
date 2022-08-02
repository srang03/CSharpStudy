namespace _220802DelegateReivew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessCode bc = new BusinessCode();
            bc.SendFiles(NormalReporting);
        }

        static IReportingLogic NormalReporting(string file_path)
        {
            IReportingLogic r = new ReportingLogic2();
            return r;
        }
    }

    public class ReportingLogic1 : IReportingLogic
    {
        public void CreateXML()
        {
            System.Console.WriteLine("Createing XML ...");
        }
    }

    public class ReportingLogic2 : IReportingLogic
    {
        public void CreateXML()
        {
            System.Console.WriteLine("Createing XML2 ...");
        }
    }

    public class BusinessCode
    {
        public delegate IReportingLogic MyDelegate(string file_path);
        
        public bool SendFiles(MyDelegate GetReporting)
        {
            string file_path = ".../text.xml";
            var reporting = GetReporting;
            reporting(file_path).CreateXML();

            return SendXMLFilesInFolder();
        }

        private bool SendXMLFilesInFolder()
        {
            return false;
        }
    }

    public interface IReportingLogic
    {
        void CreateXML();
    }

   
}
