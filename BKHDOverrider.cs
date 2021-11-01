using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//建立BKHD重写类
class BKHDOverrider
{
    //重写BKHD.json
    public void BKHDOverride(string Jpath)
    {
        try
        {
            //读取BKHD.json
            string json = File.ReadAllText(Jpath);
            //将读取文本转换为json对象
            JObject rss = JObject.Parse(json);
            //重写ver数值为112
            rss["ver"] = 112;
            //JSON数据字符串化
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(rss, Newtonsoft.Json.Formatting.Indented);
            //输出文本
            File.WriteAllText(Jpath, output);
            //提示重写完成
            Console.WriteLine("BKHDOverride Done");
        }
        catch
        {
            Console.WriteLine("BKHDOverride ERROR");
            //提示按任意键继续
            Console.WriteLine("Press any key to continue...");
            //输入任意键退出
            Console.ReadLine();
        }
    }
}

