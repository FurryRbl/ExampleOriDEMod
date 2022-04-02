# ExampleOriDEMod

## .gitignore文件

内置Vim，Visual Studio和Visual Studio Code

## 游戏兼容

对奥日与黑暗森林终极版兼容，暂不确定对奥日与黑暗森林原版是否兼容

## CSharp兼容

只支持CSharp3.5的语法和函数，需要使用额外函数。请将dll添加到libs并引用，请将复制到本地设置为True，否则Mod无法运行

## 使用

将存储库克隆到本地

``` bash
git clone https://github.com/FurryRbl/ExampleOriDEMod.git
```

删除LICENSE和README.md，这些文件可能不适合你的项目

使用Visual Studio打开此项目

添加 <https://nuget.bepinex.dev/v3/index.json> 到NuGet源

重命名解决方案，项目和类名称

## $\color{red}{警告}$

$\color{red}{请勿更新Mono.Cecil的NuGet包！！！}$

$\color{red}{请保持解决方案平台默认为Any CPU！！！}$
