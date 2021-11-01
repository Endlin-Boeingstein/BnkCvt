using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//建立判断类
class JudgeJoF
{
	//判断完成后路径定义
	public string Fpath = null;
	//创建bc实例
	public BnkConvertor bc = new BnkConvertor();
	//判断是file还是dir路径
	public void Judge(string filepath)
	{

		try
		{
			if (File.Exists(filepath))
			{
				Console.WriteLine("已检测到为文件，请重新执行程序，拖入bnk的分解文件夹，而不是单独文件");
			}
			else if (Directory.Exists(filepath))
			{
				Console.WriteLine("已检测到为dir文件夹，进行转换处理");
				this.Fpath = filepath;
				bc.BnkCvt(this.Fpath);
			}
			else
			{
				Console.WriteLine("未检测到文件或文件夹！请检查！");
			}
		}
		catch
		{
			Console.WriteLine("ERROR");
		}

	}
}