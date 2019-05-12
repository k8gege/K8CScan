#coding=utf-8
#pythonnet 
#Test Win7 x86
import clr #py2.7.9 单纯引用这句 打包成exe就报错 Python.Runtime.Runtime
#python 3.4.4 执行PY脚本就已报错 Github上看到作者还未解决 未经处理的异常:  System.InvalidProgramException: 公共语言运行时检测到无效的程序
#在 clrModule.PyInit_clr()
import sys

print('python call K8Cscan c# dll')

#添加.net运行库路径也没用
#sys.path.append("c:\\Program Files\\Reference Assemblies\\Microsoft\\Framework\\v3.5\\")
#sys.path.append("C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\")
#sys.path.append("C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\")

#DLL所在路径(当前路径不需要)
#sys.path.append("C:\\Users\\K8team\\Desktop\\pynet")
clr.FindAssembly('netscan.dll')
#程序集(网上都说是命名空间),乱写报错: System.IO.FileNotFoundException
clr.AddReference('netscan')
#命名空间
from CscanDLL import * 
print(scan.run('192.168.1.1'))
