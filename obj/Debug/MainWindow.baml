   M S B A M L   `   `   `  ����D  @AppDeneme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:AppDeneme	AppDeneme  5   	       AppDeneme.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:AppDeneme     5   	     � Title$  
Tuna Borsa��5   	   $	��450��6   $	��850��6)   .��5	      � ���	#FF858585.+�5
   
   �� -   5         ��Name$ GBInputs��5
      $
��Left=�6%   $	��184��6@   $��108,227,0,0q�6M   $	��Top=�6b   $	��488��6z   $��Degerler��6�   $��Tahoma)�6�   .��5      �  � ColumnDefinitions 5      �� 5      $
��109* �6'   �� 5      $	��30* �6'   �� 5      $	��99* �6'   .+�5      �� -   5         ��Name$ TextBoxKagitAdi��5      $
��Left=�64   $��22��6O   $��
117,10,0,0q�6[    �� TextWrapping$
 Wrap=�6o    �� TextAlignment$ Center=�6�   $	��Top=�6�   $��85��6�   6�   �� 5      -   5         ��Name$ lblKagitAdi��5      $��Kagit Adi: ��6-   $
��Left=�6C   $��33��6_   $��	10,10,0,0q�6k   $	��Top=�6~   $	��102��6�   �� 5      -   5        $ TextBoxAlisBirimFiyati��5      $
��Left=�6:   $��22��6U   $��
117,53,0,0q�6a   $
 Wrap=�6u   $ Center=�6�   $	��Top=�6�   $��85��6�   6�   �� 5      -   5        $ lblAlisBirimFiyati��5      $��Alis Birim Fiyati:��64   $
��Left=�6Q   $��33��6m   $��	10,53,0,0q�6y   $	��Top=�6�   $	��102��6�   �� 5      -   5        $ TextBoxIstenilenYuzde��5      $
��Left=�69   $��22��6T   $��
117,98,0,0q�6`   $
 Wrap=�6t   $ Center=�6�   $	��Top=�6�   $��85��6�   6�   �� 5      -   5        $ TextBoxSatisBirimFiyati��5      $
��Left=�6;   $��22��6V   $��	87,21,0,0q�6b   $
 Wrap=�6u   $ Center=�6�   $	��Top=�6�   $��85��6�   $��2��6�   �� 5      -   5        $ TextBoxLotSayisi��5      $
��Left=�64   $��22��6O   $��	87,98,0,0q�6[   $
 Wrap=�6n   $ Center=�6�   $	��Top=�6�   $��85��6�   $��2��6�   �� 5      -	   5         ��Name$ SubmitButton��5      $��Giris��6/   $
��Left=�6?   $��206,129,0,3.6q�6Z   $��85��6q    J� RenderTransformOrigin$ 0.529,-0.517&�6�   $��3��6�   �� 5      -
   5        $ lblSatisBirimFiyati��5      $��Satis Birim Fiyati:��65   $
��Left=�6S   $��36��6n   $��	40,21,0,0q�6z   $	��Top=�6�   $	��102��6�   $��2��6�   $��1��6�   �� 5      -   5        $ lblIstenilenYuzde��5      $��Istenilen Yuzde:��63   $
��Left=�6N   $��22��6i   $��	10,98,0,0q�6u   $	��Top=�6�   $	��102��6�   �� 5      -   5        $ lblLotSayisi��5      $��Lot Sayisi:��6.   $
��Left=�6D   $��31��6_   $��1,98,0,0q�6k   $	��Top=�6}   $	��102��6�   $��2��6�   5      5      �� 5    
   -   5        $ 	GBOutputs��5       $��Kumulatif Analiz��6&   $
��Left=�6@   $	��155��6[   $��	10,10,0,0q�6h   $	��Top=�6{   $	��642��6�   $��Tahoma)�6�   .��5!      � .+�5"      �� -   5        $ TextBoxToplamKarZarar��5"      $
��Left=�69   $��21��6T   $��
542,20,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $��77��6�   	 �� 
IsReadOnly	 . 6�   �� 5#      -   5        $ TextBoxYuzdeselKarZarar��5#      $
��Left=�6;   $��21��6V   $��
543,93,0,0q�6b   $
 Wrap=�6v   $	��Top=�6�   $��77��6�   	 . 6�   �� 5$      -   5        $ TextBoxMinSatisZiraat��5$      $
��Left=�69   $��21��6T   $��
129,20,0,0q�6`   $
 Wrap=�6t   $	��Top=�6�   $��77��6�   	 . 6�   �� 5%      -   5        $ TextBoxMinSatisGaranti��5%      $
��Left=�6:   $��21��6U   $��
129,93,0,0q�6a   $
 Wrap=�6u   $	��Top=�6�   $��77��6�   $ 0.494,1.857&�6�   	 . 6�   �� 5&      -   5        $. (TextBoxIstenenYuzdeIcinSatisFiyatiZiraat��5&      $
��Left=�6L   $��21��6g   $��
358,20,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $��77��6�   $ 0.377,0.524&�6�   	 . 6�   �� 5'      -   5        $/ )TextBoxIstenenYuzdeIcinSatisFiyatiGaranti��5'      $
��Left=�6M   $��21��6h   $��
358,93,0,0q�6t   $
 Wrap=�6�   $	��Top=�6�   $��77��6�   	 . 6�   �� 5(      $
��Left=�6   $��6��6:   $��0,61,-0.2,0q�6E   $	��Top=�6Z   $	��629��6r   �� 5)      -   5        $! lblMinSatisBirimFiyatZiraat��5)      $*��$Minimum Birim 
Satis Fiyati(Ziraat)��6=   $
��Left=�6t   $��39��6�   $��10,7,0,0q�6�   $	��Top=�6�   $	��114��6�   �� 5*      -   5        $&  lblMinSatisBirimFiyatZiraat_Copy��5*      $*��$Minimum Birim 
Satis Fiyati(Garanti)��6B   $
��Left=�6u   $��39��6�   $��	10,81,0,0q�6�   $	��Top=�6�   $	��114��6�   �� 5+      -   5        $$ lblIstenenYuzdeIcinSatisZiraat��5+      $6��0Istenen Yuzde Icin 
Birim Satis Fiyati (Ziraat)��6@   $
��Left=�6�   $��40��6�   $��
211,10,0,0q�6�   $	��Top=�6�   $	��142��6�   �� 5,      -   5        $% lblIstenenYuzdeIcinSatisGaranti��5,      $7��1Istenen Yuzde Icin 
Birim Satis Fiyati (Garanti)��6A   $
��Left=�6�   $��42��6�   $��
211,81,0,0q�6�   $	��Top=�6�   $	��165��6�   �� 5-      -   5        $) #lblIstenenYuzdeIcinSatisZiraat_Copy��5-      $��Toplam Kar/Zarar��6E   $
��Left=�6`   $��40��6{   $��
435,16,0,0q�6�   $	��Top=�6�   $	��142��6�   �� 5.      -   5        $* $lblIstenenYuzdeIcinSatisZiraat_Copy1��5.      $��Yuzdesel Kar/Zarar��6F   $
��Left=�6c   $��40��6~   $��435,93,0,-0.2q�6�   $	��Top=�6�   $	��142��6�   50      51      �� 52   
   -   5        $ GBKagitLiveData��52      $��
Canli Data��6,   $
��Left=�6@   $��57��6[   $��257,170,0,0q�6g   $	��Top=�6|   $	��166��6�   $��Tahoma)�6�   &   System.Windows.Controls.DataGrid  53   
   -   5        
  Name$
 DGWYuzdeSatisBirim��53      $
��Left=�6/      HeadersVisibility$ Column=�6J   $	��216��6e   $��
672,17,0,0q�6r   $	��Top=�6�   $	��161��6�      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ Yuzde��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 80.5 64      CenterGridHeaderStyle   HeaderStyle# �   6A   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6x   �� *Yuzde+   	CellStyle 56      �� 57       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�58      ��  �� Property � �� �� Value$ 0,0,-1,0q�67   6J   59      5;        5<      $ Birim Fiyat��6%   $ * 6:    6D   �� *SatisBirimFiyat+ 5=      �� 5>      "  6    .�5?      ��  � ��$ 0,0,-1,0q�67   6J   5@      5B      5D      5F       � 	Resources 5H      =  7System.Windows.Controls.Primitives.DataGridColumnHeader��%V   &	        �� 5I   
   "  6.   .�5J      ��  � ��$ Center=�6;   5K      5L      5M      