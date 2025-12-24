# Refactor_FirstGame

> # [ 名称 ]
> ### 简介
>   [基于unity的2d平台跑酷游戏, 通过键位的切换实现混乱的主题]<br>
> ### 环境
>   基于 unity2022.3.62f2c1

>  # 项目结构
>Scrips
> ┣ BaseSetting.cs         // 全局设置(其中包含音量大小(0~1)，是否启用背景音乐，是否启用音效，是否有任何ui动画正在播放)
> ┣ ButtonFunc.cs          // 按钮相关函数(只是包含了一个进入游戏何退出游戏的按钮函数)
> ┣ CameraMove.cs          // 摄像机跟随(通过transfrom实现摄像机跟随)             
> ┣ ChangeMenu.cs          // 菜单的切换(通过插值何坐标更改实现菜单的平滑切换)
> ┣ GameOver.cs            // 游戏结束           
> ┣ isJump.cs              // 检测是否可跳跃         
> ┣ Key.cs                 // 键位的显示与更改(通过获取当前键位的keycode进行键位切换)      
> ┣ MovePlane.cs           // 移动平台(八轴向的平台，可通过更改moveaxis进行轴向切换，movespeed移动速度，changetime为平台的移动宽度)            
> ┣ MoveTraps.cs           // 移动的陷阱(同上 不过增加了一个陷阱的tag)
> ┣ PauseContorl.cs        // 暂停控制(暂停的实现 但是没有保留物体的物理状态)
> ┣ Platform.cs            // 平台           
> ┣ PlayerClimbRope.cs     // 梯子   
> ┣ PlayerDead.cs          // 角色死亡             
> ┣ PlayerMove.cs          // 角色移动(通过字典实现键位再不同区域的切换)            
> ┣ PlayerMoveJustJump.cs  // 跳跃      
> ┣ SavePoint.cs           // 存档点           
> ┣ VoiceChange.cs         // 调整音量滑条/显示和全局设置一致              
> ┗ VoiceFunc.cs           // 音量相关设置的函数            
>

