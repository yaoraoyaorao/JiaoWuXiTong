   M S B A M L   `   `   `  ????G  CJiaoWuXiTong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:JiaoWuXiTongJiaoWuXiTong  5   	   "    JiaoWuXiTong.LoadFileWindows   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:JiaoWuXiTong     5   	   -   5          ? Title$  LoadFileWindows??5   	   $	??200??6!   $	??550??6.    ? 
ResizeMode$ NoResize=?6:   .??5	      ? .+?5
   
   &   System.Windows.Controls.DataGrid  -   5        $??LoadGrid??5
         AutoGenerateColumns$ False??6;      CanUserAddRows$ False??6W      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 100 6n      MinColumnWidth$	 100Q?6?      MaxColumnWidth$	 100Q?6?   ??6#   ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 信息??6%   	   
IsReadOnly$
	 True??61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   ?? *Name+6^     5      $ 是否导入??6%   $
	 True??63   
 6E   ?? *State+6a     5      $ 原始路径??6%   $
	 True??63   
 6E   ?? *OriginalPath+6h     5      $ 项目路径??6%   $
	 True??63   
 6E   ?? *ProjectPath+6g   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 导入??6)      CellTemplate 5      ?? 5      .R?5      ?? -   5        ??5   %   ?? *Btn_Content+
 ? Tag 6V   ?? *ID+5      5      5      5      5      