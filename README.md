# Refactor_FirstGame

> # [ 名称 ]
> ### 简介
>   [基于unity的2d平台跑酷游戏, 通过键位的切换实现混乱的主题]<br>
> ### 环境
>   基于 unity2022.3.62f2c1

>  # 项目结构
>Scrips
> ┣ BaseSetting.cs         // 全局设置              
> ┣ ButtonFunc.cs          // 按钮相关函数             
> ┣ CameraMove.cs          // 摄像机跟随             
> ┣ ChangeMenu.cs          // 菜单的切换             
> ┣ GameOver.cs            // 游戏结束           
> ┣ isJump.cs              // 检测是否可跳跃         
> ┣ Key.cs                 // 键位的显示与更改      
> ┣ MovePlane.cs           // 移动平台            
> ┣ MoveTraps.cs           // 移动的陷阱            
> ┣ PauseContorl.cs        // 暂停控制
> ┣ Platform.cs            // 平台           
> ┣ PlayerClimbRope.cs     // 梯子   
> ┣ PlayerDead.cs          // 角色死亡             
> ┣ PlayerMove.cs          // 角色移动            
> ┣ PlayerMoveJustJump.cs  // 跳跃      
> ┣ SavePoint.cs           // 存档点           
> ┣ VoiceChange.cs         // 调整音量滑条/显示和全局设置一致              
> ┗ VoiceFunc.cs           // 音效相关设置的函数            