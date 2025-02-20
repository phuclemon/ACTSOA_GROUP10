namespace ACTSOA_GROUP10.CommonLayer.Utilities
{
    public class ErrorHandler
    {
        public static string GetErrorMessage(Exception ex)
        {
            return ex.Message;
        }
    }
}