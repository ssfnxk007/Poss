using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Web;

/// <summary>
/// 基础配置类
/// </summary>
namespace POSS
{
    public class ZFBConfig
    {
        //public static string alipay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAhX69JnxfpHq8DS7KU0hA+T76G2KhR1vrqmhxT9FxtTQT2JabWNcvh1bZ9Amoo37XKbthCxJNaM7vg21X7FFZcWf7ifSCee/0sGsEQAMZd5sOyNM6TLceftDGQPAtNBQimcDpHowPShs4M3JZ/W+wV+SiIqhX72AA6UH1A4vty0GJdY2MC5pzZjt3Jt+T8E87W6Ck9+BQjrmZfJKILaz68qgmlY7CVy9HxFRmn5EOlWktwcch/5wJwtyHS077YHKDkILATKZBbf3qTQt3Y9m42C0vLcMOyKEJPDijB9kVncqs5xYnwXvNI6d/bESAk6Xc5kXJG1zv8AYz5/CESErUqwIDAQAB";
        
        
        ////这里要配置没有经过的原始私钥

        ////开发者私钥
        //public static string merchant_private_key = @"MIIEpAIBAAKCAQEArT7BskKHTQjOVYV+gsc6XkzOazKDDs7o2QkbCJMi8h6pdZDoWmkFQGgYhltKZZyEzG4FP97DDjU+wrBh0CyF1enGvKOQwKyRC4lVEq3E91MvnpSyRycEFwcn4AIuMYZ37X64peUsZlpuHHjWVEH5hI6dRYsv9pMcpP0b9Z+btr90niYQUDfwdhup2l3cbJZuKCSlZJTdukhN8e0CYaJEDwuW29J5l2PqK9ZORzwRbAUE//u7AkfLQxflRQtZe/CJUyVgWrS6U3bTHJbtX3QPZxP8oiZBHsqB+30V4CkVBgmrS138dsEv9uBKnHjmLlgAkqdcmEeoKL+v/U2lAiY4yQIDAQABAoIBAHHaBTcd64bfm6GuWiadwSkJtrnR9zj7FyDSkBaBg3y0U880TM5lqBLclglt4yWFx+wE/aQsw+kJatZNTeqd59JdkMKVh2JnxeZb+TGOSxvyaiAAPmzuIgz0Ietf43Welh/YoIY9ZoFZOnWxn8C9nrnTc12pi/qyUSfIQuCXZKCieg5c6QhFbIC4tV3dbNFfwzKmE73AVv3vhMwtodKoyp4c+mPo96omDmBAEdRP6m6SFN+q+bCONDhIgbaMmYlzkwq6oGdFGFZ0azG5ZlgsDYiftK9LyiUe62ckM5iwFryUi/WzYxqQEIapiCmdVnbKCbltyZB1Fd3vBHEpt9tTkgECgYEA4ad4PIymMluApYiP98+aSqjK0ZvTE4dF+D6PWcQY6MNAiMo7MGYqm/tM/cZTaYyvDCPCz0etvtl6L3Xhsy44brs+2oe9EGTz+sAnJTeW+MwucUrLEmkcJWmGL3jfrFoiNZPynRC5vW9h6MpUUqkZHP2JjAe0nKbmNGX4cWM3E0ECgYEAxIsENVIn8Q36tT/tFTNEr+csF5sPNhkgSbUidPd3AYl7XguUWiTL9RgJ6U7whWgPvFoxga+I5UTNBKM3mwKA9XvFDTRBSzk0STrbEdt4OKFSFb8BBBwkfRJC0tq+cVb5rMGIsgB+V/w29eznz49Alf5Kp+mg9TMQK7usVXoxK4kCgYEAvNN/+OMVXARX5a0eFBekHB+dAMPtYGUNNwtat5ox4e0pfo4D8586vqYOqjmgqS1xea4fIYbwrEieR0LUqDTgQkDr+sAlhKeFxmmvGCSpb+6kWmdlATX1uJTSFb2HJlmSUNVJ6wcI9q1S+BL/duBLxIeg5w23pHLBJk3CFVgZyUECgYEAkCFSCLgiykdyHxCuD+n06Poh/32afhWW8/Z9OkFvaBUl/yWGuURavXXPbuSQxYQ2Ze3OeEf9oAQARPJciLQhVeRZ8QDtEPj2Ou2KUWIcm4rR41iaqiTpLT8C+hWnqv4ZQnL6h26NOICg3V/J7xAiUNyWauSNQMMdjLSoAFcHT+ECgYBczZ3oNOuMRXWmkYkCrJiiLrW4nt9SSl04OtMyUb5M9PXgCqvFt17m6Wv8k0xNTgk/kHUpBceYkZrKUKqgcxoL6TUYRj3IMIWkTHXkOITeN/boueYnViPdU22QM6MCPhZzpU3VcSbQknZk+RLFbIwGk6N4o6Lh2gSV0yKVS7DHsw==";
        
        ////开发者公钥
        //public static string merchant_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEArT7BskKHTQjOVYV+gsc6XkzOazKDDs7o2QkbCJMi8h6pdZDoWmkFQGgYhltKZZyEzG4FP97DDjU+wrBh0CyF1enGvKOQwKyRC4lVEq3E91MvnpSyRycEFwcn4AIuMYZ37X64peUsZlpuHHjWVEH5hI6dRYsv9pMcpP0b9Z+btr90niYQUDfwdhup2l3cbJZuKCSlZJTdukhN8e0CYaJEDwuW29J5l2PqK9ZORzwRbAUE//u7AkfLQxflRQtZe/CJUyVgWrS6U3bTHJbtX3QPZxP8oiZBHsqB+30V4CkVBgmrS138dsEv9uBKnHjmLlgAkqdcmEeoKL+v/U2lAiY4yQIDAQAB";

        ////应用ID
        //public static string appId = "";//2017040106514555

        ////合作伙伴ID：partnerID
        //public static string pid = "2088621725650576";
        

        //支付宝网关
        public static string serverUrl = "https://openapi.alipay.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipay.com/gateway.do";
        public static string monitorUrl = "http://mcloudmonitor.com/gateway.do";

        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA2（推荐！）、RSA
        public static string sign_type = "RSA2";
        //public static string sign_type = "RSA";
        //版本号，无需修改
        public static string version = "1.0";
         

        ///// <summary>
        ///// 公钥文件类型转换成纯文本类型
        ///// </summary>
        ///// <returns>过滤后的字符串类型公钥</returns>
        //public static string getMerchantPublicKeyStr()
        //{
        //    StreamReader sr = new StreamReader(merchant_public_key);
        //    string pubkey = sr.ReadToEnd();
        //    sr.Close();
        //    if (pubkey != null)
        //    {
        //      pubkey=  pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
        //      pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
        //      pubkey = pubkey.Replace("\r", "");
        //      pubkey = pubkey.Replace("\n", "");
        //    }
        //    return pubkey;
        //}

        /// <summary>
        /// 私钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型私钥</returns>
        //public static string getMerchantPriveteKeyStr()
        //{
        //    StreamReader sr = new StreamReader(merchant_private_key);
        //    string pubkey = sr.ReadToEnd();
        //    sr.Close();
        //    if (pubkey != null)
        //    {
        //        pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
        //        pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
        //        pubkey = pubkey.Replace("\r", "");
        //        pubkey = pubkey.Replace("\n", "");
        //    }
        //    return pubkey;
        //}

    }
}