using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//建立BKHD.dat覆盖类
class BKHDdatOverrider
{
    //覆盖BKHD.dat
    public void BKHDdatOverride(string Dpath)
    {
        try
        {
            //得到预置的和exe同文件夹的BKHD.dat的路径
            FileInfo fi = new FileInfo(System.Environment.CurrentDirectory+"\\BKHD.dat");
            //判断文件是否缺失
            if (fi.Exists)
            {
                //删除错误的BKHD.dat
                File.Delete(Dpath);
                //添加预置的BKHD.dat
                fi.CopyTo(Dpath);
                //提示覆盖完成
                Console.WriteLine("BKHDdatOverride Done");
            }
            else Console.WriteLine("软件原有的BKHD.dat缺失！");
        }
        catch
        {
            Console.WriteLine("BKHDdatOverride ERROR");
            //提示按任意键继续
            Console.WriteLine("Press any key to continue...");
            //输入任意键退出
            Console.ReadLine();
        }
    }
}
