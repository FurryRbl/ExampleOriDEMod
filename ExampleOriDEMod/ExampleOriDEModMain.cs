using BepInEx;

namespace ExampleOriDEMod
{
    [BepInPlugin("Mod GUID，例如com.example.mod", "Mod名称", "Mod版本")]//设置Mod信息，只能添加一行
    //示例[BepInPlugin("com.sharpice.orimods", "OriMods", "1.0.0")]
    [BepInDependency("要依赖的Mod GUID")]//设置要依赖的Mod，可添加多行
    //示例[BepInDependency("com.sharpice.orimods")]
    [BepInProcess("要过滤的程序")]//设置要过滤的程序（只能在设置的这个程序运行），可添加多行
    //示例[BepInProcess("Ori_DE.exe")]
    [BepInIncompatibility("不兼容的插件GUID")]//设置不兼容的插件，可添加多行
    //示例[BepInIncompatibility("com.sharpice.orimod")]
    public class ExampleOriDEModMain : BaseUnityPlugin
    {
        private void Awake() //可以是private也可以是public
        {
            Logger.LogInfo("这是一条普通信息!");
            Logger.LogWarning("这是一条消息！");
            Logger.LogWarning("这是一条警告信息！");
            Logger.LogError("这是一条错误信息！");
            Logger.LogFatal("这是一条致命错误信息！");
            //关于使用配置文件请查阅:https://docs.bepinex.dev/articles/dev_guide/plugin_tutorial/4_configuration.html
        }
    }
}
