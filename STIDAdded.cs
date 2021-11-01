﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//建立STID添加类
class STIDAdded
{
    //添加STID.json
    public void STIDAdd(string Fpath)
    {
        try
        {
            //从路径提取文件夹名
            string[] foldername = Fpath.Split('\\');
            //获取文件夹名称提供的bnk文件夹名称
            string name = foldername[foldername.Length - 1];
            //删除文件夹名称后缀的.bnk.dir
            name=name.Substring(0, name.Length - 8);
            //建立json数组
            JArray rss = new JArray();
            //添加bnk名称
            rss.Add(name);
            //JSON数据字符串化
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(rss, Newtonsoft.Json.Formatting.Indented);
            //输出文本
            File.WriteAllText(Fpath+"/STID.json", output);
            //提示添加完成
            Console.WriteLine("STIDAdd Done");
        }
        catch
        {
            Console.WriteLine("STIDAdd ERROR");
            //提示按任意键继续
            Console.WriteLine("Press any key to continue...");
            //输入任意键退出
            Console.ReadLine();
        }
    }
}

