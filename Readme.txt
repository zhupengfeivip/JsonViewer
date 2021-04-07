将项目升级为vs2017
FiddlerJsonViewer项目编译报错，暂移除。重点是使用JsonView



JsonView
由.net2.0升级为.net4.6.1
build目录为文件生成目录，下载后可以直接使用，不需要再编译。
改进功能说明：
1、简化操作，界面进行调整，所有操作放在一个界面上。
2、在格式化树右键菜单增加 copy key功能，可以复制json字段名（原版本不支持）。
3、【重要】增加了历史json记忆功能。



The JSON View package is a set of 3 viewers available in the following flavors:
1) A standalone viewer - JsonView.exe
2) A plugin for Fiddler 2 (http://www.fiddler2.com/) - FiddlerJsonViewer.dll
3) A visualizer for Viusal Studio 2005  - JsonVisualizer.dll

The viewer supports plugins to allow you to customize the way JSON objects are displayed. Sample plugins 
are provided within the source.

Installation
============

The archive contains the following directories:
\JsonView
\Fiddler
\Visualizer

- To use the standalone viewer, run JsonView.exe from \JsonView
- To use the Fiddler2 plugin, copy the files from the \Fiddler directory to fiddler's \Inspectors 
  directory and add the following to the <runtime> section of the fiddler.exe.config:
      <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <probing privatePath="Inspectors" />
    </assemblyBinding>
- To use the Visual Studio Visualizer, copy the JsonVisualizer.dll to the Visual Studio Visualizers 
  directory (usually under \My Documents\Visual Studio 2005\Visualizers) and copy the following files
  to the IDE directory of Visual Studio (Where devenv.exe is located - <Visual Studio>\Common7\IDE):
  - JsonViewer.dll
  - JsonViewer.dll.config
  - Newtonsoft.Json.dll
