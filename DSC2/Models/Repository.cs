using System.Collections.Generic;
namespace DSC2.Models
{
    public static class Repository
    {
        private static List<Box1> responses = new List<Box1>();
        public static IEnumerable<Box1> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(Box1 response)
        {
            responses.Add(response);
        }
    }
}