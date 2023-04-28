using Autodesk.Revit.UI;
using System;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace HelloWorld
{
    public class AppCommand : IExternalApplication
    {
        #region external application pbulic methods

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            
            application.CreateRibbonTab("七只蜗牛");
            //2.创建panel
            var panel1 = application.CreateRibbonPanel("七只蜗牛", "功能");
            //3.按钮执行的类
            var pushButtonData1 = new PushButtonData("12", "家", Assembly.GetExecutingAssembly().Location, "Helloworld.Helloworld");
            var pushButtonData2 = new PushButtonData("34", "电", Assembly.GetExecutingAssembly().Location, "Helloworld.Helloworld");
            var pushButtonData3 = new PushButtonData("56", "实际", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData4 = new PushButtonData("78", "东西", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData5 = new PushButtonData("01", "南北", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData6 = new PushButtonData("02", "东西", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData7 = new PushButtonData("03", "便宜", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData8 = new PushButtonData("04", "实例", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData9 = new PushButtonData("05", "例子", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData10 = new PushButtonData("06", "例如", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData11 = new PushButtonData("07", "栗子", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData12 = new PushButtonData("08", "test", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData13 = new PushButtonData("09", "局部三维", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData14 = new PushButtonData("10", "框选三维", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData15 = new PushButtonData("11", "本层三维", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData16 = new PushButtonData("13", "深化属性配置", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var pushButtonData17 = new PushButtonData("14", "导出图纸", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var button18 = new PushButtonData("15", "便宜西瓜", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            var button19 = new PushButtonData("16", "实际", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
            //4.添加按钮到panel
            var button1 = panel1.AddItem(pushButtonData1) as PushButton;
            var button2 = panel1.AddItem(pushButtonData2) as PushButton;
            panel1.AddSeparator();
            var button3 = panel1.AddItem(pushButtonData3) as PushButton;
            var button4 = panel1.AddItem(pushButtonData4) as PushButton;
            var panel2 = application.CreateRibbonPanel("七只蜗牛", "实例");
            var button5 = panel2.AddItem(pushButtonData5) as PushButton;
            var button6 = panel2.AddItem(pushButtonData6) as PushButton;
            var button7 = panel2.AddItem(pushButtonData7) as PushButton;
            var button8 = panel2.AddItem(pushButtonData8) as PushButton;
            button8.ToolTip = "这是一个描述";
            button8.LongDescription = "这个描述非常长";
            button18.ToolTip = "这是tooltip";
            button18.LongDescription = "这是一个很长的描述";
            button19.ToolTip = "this is a tooltip";
            button19.LongDescription = "this is a long description";
            panel2.AddStackedItems(button18, button19);
            panel2.AddSeparator();
            var button9 = panel2.AddItem(pushButtonData9) as PushButton;
            var button10 = panel2.AddItem(pushButtonData10) as PushButton;
            var button11 = panel2.AddItem(pushButtonData11) as PushButton;
            var button12 = panel2.AddItem(pushButtonData12) as PushButton;
            var panel3 = application.CreateRibbonPanel("七只蜗牛", "视图");
            var button13 = panel3.AddItem(pushButtonData13) as PushButton;
            var button14 = panel3.AddItem(pushButtonData14) as PushButton;
            var button15 = panel3.AddItem(pushButtonData15) as PushButton;
            var panel4 = application.CreateRibbonPanel("七只蜗牛", "辅助");
            var button16 = panel4.AddItem(pushButtonData16) as PushButton;
            var panel5 = application.CreateRibbonPanel("七只蜗牛", "标注出图");
            var button17 = panel5.AddItem(pushButtonData17) as PushButton;


            //5.添加图片 
            button1.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/家.png"));
            button2.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/礼物.png"));
            button3.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/学校.png"));
            button4.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/1.png"));
            button5.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/2.png"));
            button6.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/3.png"));
            button7.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/4.png"));
            button8.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/5.png"));
            button9.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/6.png"));
            button10.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/7.png"));
            button11.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/8.png"));
            button12.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/9.png"));
            button13.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/10.png"));
            button14.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/Select3DView.png"));
            button15.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/3DView.png"));
            button16.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/深化属性配置.png"));
            button17.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/导出图纸.png"));
            button18.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/12.png"));
            button19.LargeImage = new BitmapImage(new Uri("pack://application:,,,/HelloWorld;component/Pic/13.png"));
            return Result.Succeeded;
        }
        #endregion
    }
}