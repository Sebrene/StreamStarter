   M S B A M L   `   `   `  ����H  DStreamStarter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   -   5          � Title$  OBS Settings��5   	   $	��750��6   $
��1250��6+   .��5	      � ���	#FF1C1C1C � ColumnDefinitions 5
   
   �� 5      $	��22* �6   �� 5      $
��745* �6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $��2��6)   $��10q�6=   
���   �
���   �.@�5      �� $��Stream Settings��6   ���	#FFE5E5E5$��	Open Sans)�6F   .��5      � ��5      �� 5       �� ImageSource$ ssbg.jpg��6%    j� Stretch$ UniformToFill=�6<    j� TileMode$ FlipX=�6T    5      �� 5      $	��13* �6+   �� 5      $	��31* �6+   �� 5      $	��83* �6+   �� 5      $	��10* �6+   �� 5      $��1079* �6+   .+�5      �� -   5         ��Name$ CPULabel��5      $
��CPU:��6.   $��-2.94,210,-4.706,0q�6=   $	��Top=�6Y   $��26��6q   $��1��6}   
�������$
��Bold"�6�   $��	Open Sans)�6�   $��2��6�   �� 5      -   5        $ GrabCPU��5      $�� ��6-   $��185.992,208.931,0,0q�68   $	��Top=�6U   $��26��6m   $��4��6y   $
��Left=�6�   $	��308��6�   
����������	#FF2020206�   �� 5      -   5        $ GPULabel��5      $
��GPU:��6.   $��-3.94,253,-4.706,0q�6=   $	��Top=�6Y   $��26��6q   $��1��6}   
�������$
��Bold"�6�   $��	Open Sans)�6�   $��2��6�   �� 5      -   5        $ GrabGPU��5      $�� ��6-   $��185.992,253,492.008,0q�68   $	��Top=�6W   $��26��6o   $��4��6{   
����������	#FF2020206�   �� 5       -   5        $ GameType��5       $��
Game Type:��6.   $��-3.94,296,0,0q�6C   $	��Top=�6Z   $��26��6r   $��1��6~   $
��Left=�6�   $��7.932��6�   �� 5!      -   5        $ UploadLabel��5!      $��Upload Speed:��61   $��-3.94,0,3.008,306.04q�6I   $��Bottom=�6g   $��26��6�   $��1��6�   
�������$
��Bold"�6�   $��	Open Sans)�6  $��3��6  �� 5"      -	   5         ��Name$ UploadButton��5"      $��Get Upload Speed��63   $��48.992,0,0,306.04q�6N   $��Bottom=�6i   $��12(�6�   $��26��6�   $
��Left=�6�   $	��120��6�   $��4��6�   ���	#FF7063B5
�������6L  �� 5#      -
   5         ��Name$ GrabGameType��5#      $��48.992,296,0,0q�65   $	��Top=�6M   $��26��6e   $
��Left=�6�   $	��120��6�   $��4��6�   ���	#FF2D2D2D��5$      �� 5%      	 �� EndPoint$		 0,1&�62   
 �� 
StartPoint$	
 0,0&�6A   .��5&   "   �  � Color$ 	#FFF0F0F0��6/    � Offset$ 0Q�6A   � 5'   "   $ 	#FF2D2D2D��6/   $ 1Q�6A   � 5(   "   $ 	#FF5D5D5D��6/   $ 0.464Q�6A   5)      5+      �� 5,      -   5         ��Name$ GameTypeDescription��5,      $��26��6;   $��185.992,296,318.008,0q�6G    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $��4��6�   ���	#FF202020
����������	#FF202020 �� SelectionBrush �	#FF006CBF6S  �� 5-      -   5        $ uploadHelpMessage��5-      $g��aThis will navigate you to speedtest.net where you will "Begin Test" and find your "Upload Speed."��67   $��185.992,0,205.008,306.04q�6�   $��Bottom=�6�   $��26��6�   $��12(�6   $��4��6  $��	Open Sans)�6c  
�������6z  �� 5.      -   5        $ getStreamSettings��5.      $��GET STREAM SETTINGS��68   $��363.992,0,492.008,16.04q�6V   $��Bottom=�6w   $
��13.5(�6�   $
��Bold"�6�   $��44��6�   $��4��6�   ���	#FF3EB870
�������$��3q�6`  $��
Lato Black)�6t  �� 5/      -   5        $ enterUploadSpeed��5/      $
��Left=�68   $��Upload Speed (Mbps)��6S   $��26��6o   $��48.992,0,0,263.04q�6{   $
 Wrap=�6�   $��Bottom=�6�   $	��120��6�   $��11(�6�   $��4��6L  $��	Open Sans)�6�  ���	#FF2D2D2D
������� �	#FF006CBF6�  �� 50      -   5        $ helpMessage��50      $�� ��61   $��185.992,0,205.008,263.04q�6<   $��Bottom=�6^   $��26��6y   $��12(�6�   $��4��6�   
�������6�   �� 51      -   5        $ grabCompType��51      $
��Left=�65   $��48.992,210,0,0q�6P   $	��Top=�6h   $	��120��6�   $��26��6�   $��4��6�   $��	Open Sans)�6�   �� 52      -   5        $ enterInfoLabel��52      $��Section 1: Information��64   $��2.06,168,-45.422,0q�6U   $	��Top=�6q   $
��Bold"�6�   $��14(�6�   $��4��6�   $��28.62��6  ���	#FF006CBF6  �� 53      -   5        $ nearestLocationLabel��53      $��Nearest Location:��6:   $��-2.94,0,3.028,220.08q�6V   $��Bottom=�6t   $��1��6�   $��25.96��6�   
�������$
��Bold"�6  $��	Open Sans)�6  $��3��6/  �� 54      -   5        $ geolocationBox��54      $
��Left=�67   $��48.992,0,0,220.04q�6R   $��Bottom=�6m   $	��120��6�   $��26��6�   $��4��6�   ���	#FF2D2D2D$��	Open Sans)�6  �� 55      -   5        $ streamKeyLabel��55      $��Stream Key:��64   $��-2.94,0,0,134.08q�6J   $��Bottom=�6d   $��1��6�   $
��Left=�6�   $��25.96��6�   $��7.652��6�   �� 56      -   5        $ twitchUsernameLabel��56      $��Twitch Username:��69   $��-2.94,0,2.218,177.08q�6T   $��Bottom=�6r   $��1��6�   $��25.96��6�   
�������$
��Bold"�6  $��	Open Sans)�6  $��3��6-  �� 57      -   5        $ enterTwitchUsername��57      $
��Left=�6;   $��27��6V   $��48.992,0,0,177.04q�6b   $
 Wrap=�6}   $��Username Here��6�   $��Bottom=�6�   $	��120��6�   $��4��6   �� TextAlignment$ Center=�6n  ���	#FF2D2D2D$��	Open Sans)�6�  
������� � IsSharedSizeScope .  �	#FF006CBF6�  �� 58      -   5        $ streamKeyFinder��58      $��Get Stream Key��66   $
��Left=�6O   $��48.992,0,0,133.04q�6j   $��Bottom=�6�   $	��120��6�   $��27��6�   $��4��6�   ���	#FF7063B5
�������6B  �� 59      -   5        $ userNameDes��59      $r��lPlease make sure you enter the correct username and are logged into Twitch before pressing "Get Stream Key."��61   $��185.992,0,207.008,177.08q�6�   $��Bottom=�6�   $��4��6�   $��25.96��6�   $��	Open Sans)�6I  
�������6`  G� 5:      -   5         G�Name$ streamKeyPasswordBox��5:   "   $��48.992,0,0,91.04q�6@   $��Bottom=�6Z   $��26��6u   $
��Left=�6�   $	��329��6�   $��4��6�   ���	#FF202020���	#FF202020
������� G� SelectionBrush �	#FF006CBF6?  �� 5;      -   5        $ enterKeyHereLabel��5;      $��Enter Key Here:��67   $��-2.94,0,-7.992,91.08q�6Q   $��Bottom=�6o   $��1��6�   $��25.96��6�   
�������$
��Bold"�6  $��	Open Sans)�6  $��3��6*  �� 5<      -   5        $ streamKeyHelpMessage��5<      $o��iThis will navigate you to twitch.tv where you will press "Show Key." Copy and paste the Stream Key below.��6:   $��183.992,0,207.008,134.04q�6�   $��Bottom=�6�   $��26��6�   $��12(�6  $��4��6  $��	Open Sans)�6d  
�������6{  �� 5=      $��22��6    $��-2.94,134,10,0q�6,   $	��Top=�6D   $��4��6\   $��1��6p   ���	#FF006CBF6�   �� 5>      -   5         ��Name$ 	textBlock��5>       $��-3.94,10,10.94,0q�63   $��Italic$�6M   $
��Wrap=�6b   $	��Top=�6v   $	��119��6�   $��4��6�   $��1��6�   
�������$��	Open Sans)�6  �� 6/  $>�8Here's how to get the best settings using our algorithm.��63  �� 6u  �� 6�  �� 6�  �� 6�  $D�>	1. Fill in all of the information in Section 1: Information. ��6�  �� 6�  �� 6�  $���	2. Press "Get Stream Settings." Our algorithm will produce the best settings for your current setup. Note that if you did not fill in certain parts in the first section, it will give you an error in Section 2: Results.��6�  �� 6�  �� 6�  $���	3. You will be redirected to the "Results" tab where you can see the settings determined by the algorithm and either send them to OBS or play around with the values yourself.��6�  �� 6�  �� 6�  �� 6�  �� 6�  $���NOTE: This section is purely to provide settings that will allow you to stream. Stream additions called plug-ins (this includes Twitch Alerts, Twitch Chat functionality, etc.) are located under the "Plugins" tab above.��6�  6�  �� 5?      -   5        $ 
GPUTypeBox��5?      $
��Left=�63   $��48.992,253,0,0q�6N   $	��Top=�6f   $	��120��6~   $��26��6�   $��4��6�   �� 5@      -   5        $ getStreamSettingsHelp��5@      $�� ��6;   $��Right=�6F   $��0,0,192.008,32.08q�6b   $��Bottom=�6}   $	��300��6�   $��4��6�   $��25.96��6�   
�������6  �� 5A      -   5        $ enterKeyHelp��5A      $�� ��62   $��382.992,0,318.008,91.08q�6=   $��Bottom=�6^   $��4��6y   $��25.96��6�   
�������6�   5B      5C      �� 5D      $��Results��6   $��	Open Sans)�6'   .��5E      � ��5F      �� 5G      $ ssbg.jpg��6%   $ UniformToFill=�6<    5I      �� 5J      $	��10* �6+   �� 5K      $	��39* �6+   �� 5L      $
��119* �6+   �� 5M      $	��26* �6+   �� 5N      $��1022* �6+   .+�5P      �� -    5        $ 
textBlock1��5P       $
��Left=�64   $��5.346,8.931,0,0q�6O   $��Italic$�6h   $
��Wrap=�6}   $	��Top=�6�   $	��136��6�   $
��1196��6�   $��1��6�   $��4��6�   
�������$��	Open Sans)�6�   �� 6  $S�MHere are the settings created by the algorithm and what you can do with them.��6  �� 6m  �� 6y  �� 6  �� 6�  $���	1. The "Recommended Bitrate Based on Motion" is NOT what your bitrate will be set to in OBS. It is the recommended value for the games that you are playing. If your Maximum Bitrate (3) is LOWER than the 	Recommended Bitrate (2), then you might not be able to stream the types of games you specified.��6�  �� 6�  �� 6�  $���	2. You can choose to send your settings to OBS by pressing "Send To OBS." The only reason you would not do this is if you wanted to manually enter/play around with the OBS values yourself.��6�  �� 6�  �� 6�  $���		- You MUST enter all required information in Section 1: Information on the "Stream Settings" tab before you can send your settings to OBS.��6�  �� 6t  �� 6�  �� 6�  �� 6�  $���NOTE: This section is purely to provide settings that will allow you to stream. Stream additions called plug-ins (this includes Twitch Alerts, Twitch Chat functionality, etc.) are located under the "Plugins" tab above.��6�  6�  �� 5Q      $��22��6    $��
0,151,12,0q�6,   $	��Top=�6@   $��1��6X   $��4��6h   ���	#FF006CBF6|   �� 5R      -!   5        $ enterInfoLabel_Copy��5R      $��Section 2: Results��69   $��16(�6V   $��0,178,-19.363,0q�6d   $	��Top=�6}   $
��Bold"�6�   $��1��6�   $��26��6�   $��3��6�   ���	#FF006CBF$
��Lato)�6�   �� 5S      -"   5        $ recFPS��5S      $$��Recommended Frames Per Second:��6,   $��-1,232,-19.363,0q�6U   $	��Top=�6o   $��26��6�   $��3��6�   
�������$��1��6�   $��	Open Sans)�6�   �� 5T      -#   5        $ maxBitrateValue��5T      $�� ��65   $��-1,402,-51.363,0q�6@   $	��Top=�6Z   $
��Bold"�6r   $��15(�6�   $��37��6�   $��3��6�   $��1��6�   
�������6�   �� 5U      -$   5        $ maxBitrateDes��5U      $��58.363,371.862,0,0q�65   $	��Top=�6Q   $
 Wrap=�6i   $��64��6}   $��12(�6�   $
��Left=�6�   $	��952��6�   $��4��6�   ���	#FF202020���	#FF202020$��	Open Sans)�6�    �	#FF006CBF
�������6/  �� 5V      -%   5        $ recResValue��5V      $�� ��61   $��0,465,-52.363,0q�6<   $	��Top=�6U   $
��Bold"�6m   $��15(�6   $��37��6�   $��1��6�   $��3��6�   
�������6�   �� 5W      -&   5        $ 	recResDes��5W      $��58.363,441.931,0,0q�61   $	��Top=�6M   $
 Wrap=�6e   $��64��6y   $��12(�6�   $
��Left=�6�   $	��952��6�   $��4��6�   ���	#FF202020���	#FF202020$��	Open Sans)�6�    �	#FF006CBF
�������6+  �� 5X      -'   5        $ 	sendToOBS��5X      $��SEND TO OBS��60   $��221.363,544,645.749,0q�6F   $	��Top=�6e   $
��13.5(�6}   $
��Bold"�6�   $��43��6�   $��Stretch=�6�   $��4��6�   
����������	#FF3EB870$��2q�6  
�������$��	Open Sans)�6C  �� 5Y      -(   5        $ sendtoOBSLabel��5Y      $��Center=�64   $y��sPressing "Send To OBS" will instantly send all of the above settings to OBS under the profile name "StreamStarter."��6X   $
��Left=�6�   $��76.552,593.069,0,0q�6  $	��Top=�6!  $��695.712��69  $��4��6I  $��26��6Y  
�������$��	Open Sans)�6x  �� 5Z      -)   5        $ 	recFPSDes��5Z      $��58.363,233.862,0,0q�61   $	��Top=�6M   $
 Wrap=�6e   $��64��6y   $��12(�6�   $
��Left=�6�   $	��952��6�   $��4��6�   ���	#FF202020���	#FF202020$��	Open Sans)�6�    �	#FF006CBF
�������6+  �� 5[      -*   5        $ recFPSValue��5[      $�� ��61   $��-1,263,-51.363,0q�6<   $	��Top=�6V   $
��Bold"�6n   $��15(�6�   $��37��6�   $��3��6�   $��1��6�   
�������6�   �� 5\      -+   5        $ bitrateMotion��5\      $*��$Recommended Bitrate Based On Motion:��63   $��-1,301,-56.363,0q�6b   $	��Top=�6|   $��26��6�   $��3��6�   
�������$��1��6�   $��	Open Sans)�6�   �� 5]      -,   5        $ maxBitrateBuffer��5]      $&�� Maximum Bitrate and Buffer Size:��66   $��-1,370,-19.363,0q�6a   $	��Top=�6{   $��26��6�   $��3��6�   
�������$��1��6�   $��	Open Sans)�6�   �� 5^      --   5        $ recResolution��5^      $��Recommended Resolution:��63   $��-1,439,-19.363,0q�6U   $	��Top=�6o   $��26��6�   $��3��6�   
�������$��1��6�   $��	Open Sans)�6�   �� 5_      -.   5        $ bitrateMotionValue��5_      $�� ��68   $��-1,332,-51.363,0q�6C   $	��Top=�6]   $
��Bold"�6u   $��15(�6�   $��37��6�   $��3��6�   $��1��6�   
�������6�   �� 5`      -/   5        $ bitrateMotionDes��5`      $��58.363,302.862,0,0q�68   $	��Top=�6T   $
 Wrap=�6l   $��64��6�   $��12(�6�   $��4��6�   $
��Left=�6�   $	��952��6�   ���	#FF202020���	#FF202020$��	Open Sans)�6    �	#FF006CBF
�������62  �� 5a      -0   5        $ openOBSButton��5a      $��OPEN OBS��64   $��467.363,544,387.987,0q�6G   $	��Top=�6f   $
��13.5(�6~   $
��Bold"�6�   $��43��6�   $��Stretch=�6�   $	��167��6�   $��4��6�   {�.  $��	Open Sans)�6<  5b      5c      �� 5d      $��Plugins��6   $��	Open Sans)�6'   .��5e      �  5f      �� 5g      $
��357* �6+   �� 5h      $
��251* �6+   ��5j      �� 5k      $ ssbg.jpg��6%   $ UniformToFill=�6<   .+�5m      �� -1   5        $ 
textBlock2��5m       $
��Left=�64   $��	10,10,0,0q�6O   $��Italic$�6b   $
��Wrap=�6w   $	��Top=�6�   $��82��6�   $
��1196��6�   $��	Open Sans)�6�   
�������$��2��6�   �� 6�   $���Plugins are "add-ons" to OBS that increase functionality. We recommend you download the plugins below for the best streaming experience.��6�   �� 6�  �� 6�  �� 6�  �� 6�  $���	1. Our program automatically detects your operating system (currently only for Windows). Since plugin requirements vary based on operating systems, we automatically download the required versions of the required ��6�  �� 6�  �� 6�  $�	applications for you.��6�  �� 6�  �� 6�  $Z�T	2. Below, you'll find quick step-by-step instructions on how to setup your plugins.��6�  6G  �� 5n      $��22��6    $��
10,92,10,0q�6,   $	��Top=�6@   $��2��6X   �� 5o      -2   5        $ 
getOSValue��5o      $�� ��60   $��121,114,259.394,0q�6;   $	��Top=�6V   
�������6n   �� 5p      -3   5        $ OSLabel��5p      $��Operating System:��6-   $
��Left=�6I   $��	9,114,0,0q�6d   $	��Top=�6w    J� RenderTransformOrigin$ -6.868,-1.038&�6�   $��	Open Sans)�6�   
�������6�   �� 5q      -4   5        $ CLRBrowserLabel��5q      $��CLR BROWSER��65   $
��Bold"�6K   $��13(�6]   $
��Left=�6k   $��	9,145,0,0q�6�   $	��Top=�6�   $��	Open Sans)�6�   
�������6�   �� 5r      -5   5        $ visualStudioDownload��5r      $��C++ 2013 DL/Install��6;   $
��Left=�6Y   $��
60,285,0,0q�6t   $	��Top=�6�   $	��175��6�   $��26��6�   ���	#FF7063B5
�������6�   �� 5s      -6   5        $ downloadStatusVS��5s      $�� ��66   $
��Left=�6A   $��240,285,0,0q�6\   $	��Top=�6q   $	��419��6�   �� 5t      -7   5        $ netDownload��5t      $��.NET 4.5 DL/Install��62   $
��Left=�6P   $��
60,383,0,0q�6k   $	��Top=�6   $	��175��6�   $��26��6�   
����������	#FF7063B56�   �� 5u      -8   5        $ downloadStatusNET��5u      $�� ��67   $
��Left=�6B   $��240,383,0,0q�6]   $	��Top=�6r   $	��419��6�   �� 5v      -9   5        $ getCLR��5v      {�.  $��CLR Browser DL/Install��6?   $
��Left=�6`   $��
60,483,0,0q�6{   $	��Top=�6�   $	��175��6�   $��26��6�   ���	#FF006CBF
�������6�   �� 5w      -:   5        $ downloadStatusCLR��5w      $�� ��67   $
��Left=�6B   $��-145.394,483,0,0q�6]   $	��Top=�6w   $	��419��6�   $��1��6�   � 5x      -;   5         �Name$ progressBarCLR��5x   "   
�������$��1q�6M   $��26��6a   $��240,483,150.394,0q�6m   $	��Top=�6�   �� 5y      -<   5        $ MSVStep1��5y      $'��!Step 1: Microsoft Visual C++ 2013��6.   $
��Bold"�6Z   $��60,215,150.394,0q�6l   $	��Top=�6�   $��	Open Sans)�6�   
�������6�   �� 5z      -=   5        $ MSVStep1Des��5z      $����You need to have MS Visual C++ 2013 or above to run CLR. The button below will download AND prompt installation. If you do not have C++ 2013, follow the steps in the installation wizard.
NOTE: When you press the button below, if you already have it, it will ask you to uninstall. In this case, cancel the installation wizard.��61   $
��Left=�6�  $��
60,237,0,0q�6�  $	��Top=�6�  $
��1073��6�  $��43��6�  $��	Open Sans)�6�  
�������$��2��6  �� 5{      ->   5        $ CLRDes��5{       $��Italic$�60   $
��Left=�6C   $��
10,176,0,0q�6^   $
��Wrap=�6r   $����The CLR browser allows you to add web-based content onto your stream. With CLR Browser you can add Twitch chat to your stream, set up your Twitch Alerts, and it's how we will deploy the layouts. Below, you will find the necessary steps to ensure that the CLR Browser plugin works.��6�   $	��Top=�6�  $��34��6�  $
��1196��6�  $��	Open Sans)�6�  
�������$��2��6  �� 5|      -?   5        $ 
NET45Step2��5|      $ ��Step 2: .NET Framework 4.5��60   $
��Bold"�6U   $��60,315,150.394,0q�6g   $	��Top=�6�   $��	Open Sans)�6�   
�������6�   �� 5}      -@   5        $ NET45Step2Des��5}      $����You need to have .NET 4.5.x to run CLR. The button below will download AND prompt installation. If you do not have .NET 4.5, follow the steps in the installation wizard.
NOTE: When you press the button below, if you already have it, it will ask you to uninstall. In this case, cancel the installation wizard.��63   $
��Left=�6v  $��
60,337,0,0q�6�  $	��Top=�6�  $	��985��6�  $��46��6�  $��	Open Sans)�6�  
�������$��2��6�  �� 5~      -A   5        $ CLRStep3��5~      $ ��Step 3: CLR Browser Plugin��6.   $
��Bold"�6S   $��60,416,150.394,0q�6e   $	��Top=�6   $��	Open Sans)�6�   
�������6�   �� 5      -B   5        $ CLRStep3Des��5      $����This will download the .zip from the site to My Documents, and unzip it to C:\Program Files\OBS\plugins for 64-bit OBS and C:\Program Files (x86)\OBS\plugins for 32-bit OBS.
NOTE: If your OBS plugins are not located in the specific directories above, contact us for assistance. You MUST be running this program as an "Administrator" to press the button below.��61   $
��Left=�6�  $��
59,438,0,0q�6�  $	��Top=�6�  $
��1056��6�  $��45��6  $��	Open Sans)�6  
�������$��2��6;  �� 5�      -C   5        $ CLRHelp��5�      $�� ��6-   $
��Left=�68   $��
60,571,0,0q�6S   $	��Top=�6g   $	��928��6   $��2��6�   �� 5�      -D   5        $ CLRHelp2��5�      $�� ��6.   $
��Left=�69   $��
59,602,0,0q�6T   $	��Top=�6h   $	��929��6�   $��2��6�   � 5�      -E   5        $ progressBarCLR64��5�   "   
�������$��1q�6O   $��26��6c   $��240,514,150.394,0q�6o   $	��Top=�6�   �� 5�      -F   5        $ downloadStatusCLR64��5�      $�� ��69   $
��Left=�6D   $��-145.394,514,0,0q�6_   $	��Top=�6y   $	��419��6�   $��1��6�   �� 5�      -G   5        $ label��5�      $��64-Bit��6+   $��Right=�6<   $��0,514,302.764,0q�6X   $	��Top=�6q   �� 5�      -H   5        $ label23��5�      $��32-Bit��6-   $��Right=�6>   $��0,483,302.764,0q�6Z   $	��Top=�6s   5�      5�      5�      5�      5�      