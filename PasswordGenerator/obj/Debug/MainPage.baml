   M S B A M L   `   `   `  ????L  HPasswordGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PasswordGeneratorPasswordGenerator  5           PasswordGenerator.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PasswordGenerator     5        N? Title$  MainPage??5	       N? 
Background ?	#FF3C3939 N? 
Foreground
 ?????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??5 ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??5 ?6    ? RowDefinitions 5   
   ?? 5      $??5 ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??5 ?6   .+?5    
   ?? -   5         ??Name$ 	textBlock??5       $
??Wrap=?5!      $??Password Manager??5"      $??1??5#      $??1??5$      $??3??5%      $??30(?5&      $
??Bold"?5'      ???	#FF0DFF23 ?? TextAlignment$ Center=?5)      ?? 5+   
   -   5         ??Name$ 
PGenerator??5+      $??1??5,      $??2??5-      $??3??5.      $??Generate Password??5/      $	??200??50      $??50??51      $??Center=?52      53      ?? 55   
   -   5        $ LManager??55      $??1??56      $??3??57      $??3??58      $??Login Manager??59      $	??200??5:      $??50??5;      5<       ? 5?   
   -   5          ?Name$ MainCon??5?      $??5??5@      $??6??5A      5D      5E      