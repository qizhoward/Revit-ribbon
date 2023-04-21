using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HelloWorld
{
    public class AppCommand : IExternalApplication
    {
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
            var pushButtonData1 = new PushButtonData("12", "家", Assembly.GetExecutingAssembly().Location,"Helloworld.cs");
            var pushButtonData2 = new PushButtonData("34", "电", Assembly.GetExecutingAssembly().Location, "Helloworld.cs");
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
            panel2.AddSeparator();
            var button9 = panel2.AddItem(pushButtonData9) as PushButton;
            var button10 = panel2.AddItem(pushButtonData10) as PushButton;
            var button11 = panel2.AddItem(pushButtonData11) as PushButton;
            var button12 = panel2.AddItem(pushButtonData12) as PushButton;
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
            return Result.Succeeded;
        }
    }
}
