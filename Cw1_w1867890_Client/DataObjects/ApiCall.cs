using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using Newtonsoft.JSON;

namespace Cw1_w1867890.DataObjects
{
    public class ApiCall
    {
        //
        // API Call URL Formatting (SUBJECT TO MODIFY)
        //
        private static String gatewayHost = "https://localhost:44352/api/";
        private static String gatewayServiceCategory = "CategoryService/";
        private static String gatewayServiceTransaction = "TransactionService/";

        public static String readAllCategory = gatewayHost + gatewayServiceCategory + "category/search/all";
        public static String createCategory = gatewayHost + gatewayServiceCategory + "category/create";
        



        //
        // API Call POST, GET Common Method Calls (DO NOT MODIFY)
        //
        public String ApiPOST(String postUrl, String postData)
        {
            var url = postUrl;
            var data = postData;

            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
                if (httpResponse.StatusCode == HttpStatusCode.Accepted)
                {
                    return "Success!";
                }
                else
                {
                    return "Failed!";
                }
            }catch (Exception ex)
            {
                String error = "API Request Rejected! Error: " + ex;
                return error;
            }

        }

        public String ApiGET(String postUrl)
        {
            var url = postUrl;

            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);

                httpRequest.Accept = "application/json";

                var result = "";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                //Console.WriteLine(httpResponse.StatusCode);
                //Console.WriteLine(result);
                return result;
            }
            catch (Exception ex)
            {
                String error = "API Request Rejected! Error: " + ex;
                return error;
            }
        }
    }
}
