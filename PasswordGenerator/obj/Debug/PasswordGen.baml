   M S B A M L   `   `   `  ????L  HPasswordGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:PasswordGeneratorPasswordGenerator  5      #    PasswordGenerator.PasswordGen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:PasswordGenerator     5        N? Title$  PasswordGen??5
       N? 
Background ?	#FF3C3939 N? 
Foreground
 ?????.??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??5 ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??5 ?6    ? RowDefinitions 5   
   ?? 5      $??5 ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??1* ?6   ?? 5      $??5 ?6   .+?5    
   ?? -   5         ??Name$ PasswordLabel??5       $??1??5!      $??1??5"      $??3??5#      $??Label??5$      $??
Leelawadee)?5%      $??40(?5&      $
??Bold"?5'      
???????$??Center=?5)      $??Center=?5*      ???	#FF0089F55+      ?? 5.   
   -   5         ??Name$ PasswordLengthLabel??5.      $??3??5/      $??1??50      $??3??51      $??Password Length: 5??52      $??Center=?53      $
??Bold"?54      ???	#FF00DCFF$??Center=?56      $??Bottom=?57      $??25(?58      ?? 5:   
   -   5         ??Name$ slider??5:      $??4??5;      $??2??5<      $	??214??5=      $??18??5>       ?? IsSnapToTickEnabled . $	??Top=?5A      $??20(?5B      $??Center=?5C      $??
25,46,25,0q?5D      ?? 5F   
   -   5        	 ??Name$	 BtnCopy??5F      $??2??5G      $??3??5H      $
??Copy??5I      $	??100??5J      $??50??5K      $??Center=?5L      $
??Bold"?5N      
??????????	#FF575757$??30(?5Q      ?? 5S   
   -   5        $	 BtnBack??5S      $??1??5T      $??4??5U      $??60??5V      $??30??5W      $??10, 50, 190, 10q?5X      $
??Back??5Y      $??20(?5Z      $
??Bold"?5[      5\      ?? 5^   
   -   5        
 ??Name$
 NumbersCheck??5^      $??2??5_      $??2??5`      $??Numbers (123)??5a      ???	#FFF9F9F9$??15(?5c      $??18??5d      $	??Top=?5e      $??
61,47,61,0q?5f      $	??142??5g      ?? 5i   
   -   5        $
 CapitalCheck??5i      $??2??5j      $??2??5k      $??Capital (ABC)??5l      ???	#FFF9F9F9$??15(?5n      $??18??5o      $	??Top=?5p      $??	61,3,61,0q?5q      $	??142??5r      ?? 5t   
   -   5        $
 
SmallCheck??5t      $??2??5u      $??2??5v      $??Small Letters (abc)??5w      ???	#FFF9F9F9$??15(?5y      $??18??5z      $??61,24,50,56q?5{      ?? 5}   
   -	   5        $
 SymbolsCheck??5}      $??2??5~      $??2??5      $??Symbols (!£$%)??5?      ???	#FFF9F9F9$??15(?5?      $??18??5?      $??Bottom=?5?      $??
61,0,61,10q?5?      $	??142??5?       ? 5?   
   -
   5          ?Name$ PasswordPage??5?      $??5??5?      $??6??5?      5?      5?      