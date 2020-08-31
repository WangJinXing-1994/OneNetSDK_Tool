using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OneNETSDK
{
    /// <summary>
    /// 设备位置描述信息
    /// @author Philo
    /// </summary>
    public class LocationInfo
    {
        /// <summary>
        /// 高度
        /// </summary>
        public double ele;
        /// <summary>
        /// 经度
        /// </summary>
        public double lat;
        /// <summary>
        /// 纬度
        /// </summary>
        public double lon;

        /// <summary>
        /// 设备位置描述信息
        /// </summary>
        public LocationInfo()
        {
            ele = 0F;
            lat = 0F;
            lon = 0F;
        }

        /// <summary>
        /// 设备位置描述信息
        /// </summary>
        /// <param name="ele">高度</param>
        /// <param name="lat">经度</param>
        /// <param name="lon">纬度</param>
        public LocationInfo(double ele, double lat, double lon)
        {
            this.ele = ele;
            this.lat = lat;
            this.lon = lon;
        }

        public String ToOneNETString()
        {
            return "Location [ele=" + ele + ", lat=" + lat + ", lon=" + lon + "]";
        }
    }
    /// <summary>
    /// 设备基本信息描述
    /// @author Philo
    /// </summary>
    public class DeviceBasicInfo
    {
        public string area;
        public DateTime create_time;
        public bool obsv;
        public Dictionary<string, string> auth_info;
        public string title;
        public bool obsv_st;
        public string protocol;
        public string rg_id;
        public bool online;
        public LocationInfo location;
        public string id;
        public string desc;
        public string[] tags;
    }
    /// <summary>
    /// Api返回结果
    /// </summary>
    public class ApiResult
    {
        public class Error<T>
        {
            public int errno { get; set; }
            public string error { get; set; }
            public T data { get; set; }
        }

        public int statusCode;
        public string result;
        public string errcode;
        public string memo;

        public Error<T> GetErr<T>()
        {
            return JsonConvert.DeserializeObject<Error<T>>(result);
        }
    }

    /// <summary>
    /// 处理结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        public int statusCode;
        public int errno { get; set; }
        public string error { get; set; }
        public T data { get; set; }
        public Result(ApiResult re)
        {
            var res = re.GetErr<T>();
            statusCode = re.statusCode;
            errno = res.errno;
            error = res.error;
            data = res.data;
            return;
        }
    }
    /// <summary>
    /// 查询设备信息
    /// </summary>
    public class SearchDeviceInfoRes
    {
        public int per_page;
        public List<DeviceBasicInfo> devices;
        public int total_count;
        public int page;
    }

    /// <summary>
    /// 注册设备结果
    /// </summary>
    public class RegisteredDeviceRes
    {
        public string device_id;
        public string psk;
    }

    public class ResourcesRes
    {
        public class Instances
        {
            public int[] resources;
            public int inst_id;
        }
        public class Item
        {
            public int obj_id;
            public Instances[] instances;
        }
        public Item[] item;
    }

    /// <summary>
    /// 资源
    /// </summary>
    public class Resources
    {
        public int obj_id;
        public int obj_inst_id;
        public int res_id;
    }

    public class OneNET
    {
        public string apikey = "v9NQMb3Ahh3jK1Y1yLNO=1=lwAQ=";
        public string apiurl = "api.heclouds.com";

        /// <summary>
        /// 查询设备
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="pageno"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public Result<SearchDeviceInfoRes> SearchDeviceInfo(string keys, int pageno = 1, int pagesize = 30)
        {
            string api = $"/devices?key_words={keys}&page={pageno}&per_page={pagesize}";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);

            ApiResult re = PostUrl(api, null, head, "GET", "application/json", null);
            return new Result<SearchDeviceInfoRes>(re);
        }

        public class RegisteredDeviceReq
        {
            public string title = "";
            /// <summary>
            /// 设备描述
            /// </summary>
            public string desc = "";
            /// <summary>
            /// 设备标签
            /// </summary>
            public string[] tags;

            public string protocol = "LWM2M";

            public LocationInfo location = new LocationInfo();
            public bool Private = false;
            public Dictionary<string, string> auth_info = new Dictionary<string, string>();
        }

        /// <summary>
        /// 注册设备
        /// </summary>
        /// <param name="imei"></param>
        /// <param name="imsi"></param>
        /// <param name="desc"></param>
        /// <param name="tags"></param>
        /// <returns></returns>
        public Result<RegisteredDeviceRes> RegisteredDevice(string imei, string imsi, string desc = "", string[] tags = null)
        {
            if (tags == null)
                tags = new string[0];
            string api = "/devices";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);
            RegisteredDeviceReq req = new RegisteredDeviceReq();
            req.tags = tags;
            req.title = imei;
            req.auth_info.Add(imei, imsi);
            req.desc = desc;
            string body = JsonConvert.SerializeObject(req);
            body = body.Replace("Private", "private");

            ApiResult re = PostUrl(api, body, head, "POST", "application/json", null);
            return new Result<RegisteredDeviceRes>(re);
        }
        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Result<object> DeleteDevice(string id)
        {
            string api = $"/devices/{id}";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);
            ApiResult re = PostUrl(api, null, head, "DELETE", "application/json", null);
            return new Result<object>(re);
        }
        /// <summary>
        /// 获取资源
        /// </summary>
        /// <param name="imei"></param>
        /// <returns></returns>
        public Result<ResourcesRes> GetResources(string imei)
        {
            string api = $"/nbiot/resources?imei={imei}";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);
            ApiResult re = PostUrl(api, null, head, "GET", "application/json", null);
            return new Result<ResourcesRes>(re);
        }
        /// <summary>
        /// 写入数据，发送到设备
        /// </summary>
        /// <param name="imei"></param>
        /// <param name="data"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public Result<object> Write(string imei, string data, Resources res)
        {
            string api = $"/nbiot?imei={imei}&obj_id={res.obj_id}&obj_inst_id={res.obj_inst_id}&mode=2";
            string body = "{\"data\":[{\"res_id\":" + res.res_id + ",\"val\":\"" + data + "\"}]}";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);
            ApiResult re = PostUrl(api, body, head, "POST", "application/json", null);
            return new Result<object>(re);
        }
        /// <summary>
        /// 离线写入
        /// </summary>
        /// <param name="imei"></param>
        /// <param name="data"></param>
        /// <param name="res"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public Result<object> Write_o(string imei, string data, Resources res, int timeout)
        {
            string api = $"/nbiot/offline?imei={imei}&obj_id={res.obj_id}&obj_inst_id={res.obj_inst_id}&mode=2&valid_time={DateTime.Now.AddSeconds(10).ToString("s")}&expired_time={DateTime.Now.AddSeconds(5 + timeout).ToString("s")}&retry=0";
            string body = "{\"data\":[{\"res_id\":" + res.res_id + ",\"val\":\"" + data + "\"}]}";
            WebHeaderCollection head = new WebHeaderCollection();
            head.Add("api-key", apikey);
            ApiResult re = PostUrl(api, body, head, "POST", "application/json", null);
            return new Result<object>(re);
        }

        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {

            if (sslPolicyErrors == SslPolicyErrors.None)

                return true;

            return true;
        }
        private ApiResult PostUrl(string apiPath, string postData, WebHeaderCollection headers, string method, string contenttype, CookieCollection cookies)
        {

            string url = string.Format("https://{0}{1}", this.apiurl, apiPath);
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest httpRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            httpRequest.Method = method;
            httpRequest.ContentType = contenttype;

            httpRequest.AllowAutoRedirect = true;
            httpRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            httpRequest.Accept = "*/*";
            httpRequest.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");


            if (cookies != null)
            {
                httpRequest.CookieContainer = new CookieContainer();
                httpRequest.CookieContainer.Add(new Uri(url), cookies);
                httpRequest.Headers.Add(HttpRequestHeader.Cookie, cookies[0].ToString());
            }

            for (int i = 0; i < headers.Count; i++)
            {
                for (int j = 0; j < headers.GetValues(i).Length; j++)
                {
                    httpRequest.Headers.Add(headers.Keys[i], headers.GetValues(i)[j]);
                }

            }

            httpRequest.ServicePoint.Expect100Continue = false;
            //

            if (method != "GET" && postData != null)
            {
                Stream requestStem = httpRequest.GetRequestStream();
                StreamWriter sw = new StreamWriter(requestStem);
                sw.Write(postData);
                sw.Close();
            }

            try
            {
                HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                Stream receiveStream = httpResponse.GetResponseStream();

                string result = string.Empty;
                using (StreamReader sr = new StreamReader(receiveStream))
                {
                    result = sr.ReadToEnd();
                }
                ApiResult r = new ApiResult();
                r.result = result;
                r.statusCode = (int)httpResponse.StatusCode;

                return r;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ApiResult er = new ApiResult();
                er.result = ex.Data.ToString();
                er.statusCode = 400;
                return er;
            }
        }
    }
    public class Class1
    {
    }
}
