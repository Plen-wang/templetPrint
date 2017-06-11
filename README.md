# templetPrint 套打组件（完全免费）
## 1.背景

纯手工打造精简开源免费套打组件，目前具不完整统计已经有近1000用户量。
2010年编写完成，之前都在各个下载渠道上免费下载（包括源码），CSDN、51CTO、博客园等。现在正式放到github上进行开源维护。

期间有很多用户想要付费，我都直接拒绝了，因为我觉得这个组件能被人用起来我就很有成就感了。有时候挺奇怪，不经意间就创造了一个不错的产品。
此组件是我在工作中的项目里提炼出来的，经过了一定的通用性抽象。

## 2.特点
* 精简、用起来非常简单
* 灵活的设计器功能、拖动、保存位置坐标、自动载入
* 丰富的数据控件、文本、日期、图片
* 控件的位置完全基于XMLDOM思想，扩展性极强
* 无损的打印、预览、批量打印
* 无缝集成到任何一个C/S项目中，只需要一个.dll

## 3.使用
下面介绍下这个组件大概怎么使用：
首先这个套打组件完全是基于Microsoft.net 平台的，C#编写，组件是用.dll动态链接库进行打包的。组件本身可以很好的进行C/S winform模式的程序集成，对于WEB形式的打印是基于ActiveX模式的。WEB形式的打印用起来会比较重。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/1.png)
蓝色部分主要是控件、数量的移动坐标。左边是模板列表、主窗口是设计区域。可以通过移动控件来调整数据打印的位置。当你移动控件的时候下面的坐标可以看到窗口的打印相对位置，最后点击应用保存当前模板。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/2.png)
当你添加好控件之后就可以调整控件的数据类型，不同的数据类型的控件具有不同的正则验证能力。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/3.png)
这是一个非常人性化的透明的悬浮窗口，帮助你查看当前这个模板的一些基本信息。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/4.png)
当鼠标悬停在某个控件上的时候就会得到focus的影响，此时你可以拖动也可以删除控件。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/5.png)
可以很方便的删除控件。
![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/6.png)
内嵌了系统打印功能，可以调整打印参数。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/7.png)
批量套打预览。
控件背后的位置信息和模板的底图都在成对保存在目录里的。

![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/8.png)
![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/9.png)
![精简套打组件](https://raw.githubusercontent.com/Plen-wang/blogsImage/master/githubimages/templeprint/10.png)
数据源也是很方便绑定的。


