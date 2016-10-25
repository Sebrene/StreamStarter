using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.IO.Compression;
using System.ComponentModel;
using System.Security.Principal;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    

    internal class gameType
    {
        public string gameMotion;
        public string motionDescription;
        public gameType(string dropDownGameMotion, string dropDownMotionDescription)
        {
            gameMotion = dropDownGameMotion;
            motionDescription = dropDownMotionDescription;
        }
    }

    internal class compType
    {
        public string computerType;
        public compType(string dropDownCompType)
        {
            computerType = dropDownCompType;
        }
    }

    internal class geoLocation
    {
        public string userLocate;
        public geoLocation(string userLocation)
        {
            userLocate = userLocation;
        }
    }

    internal class GPUType
    {
        public string gpuLocate;
        public GPUType(string dropDownGPUType)
        {
            gpuLocate = dropDownGPUType;
        }
    }

        public partial class MainWindow : Window
    {

        public string cpuName;
        public static string gpuName;
        public double uploadSpeed;
        public double baseHeight;
        public double baseWidth;
        public double disableAero;
        public double resDownscale;
        public double setFPS;
        public double setMonitor;
        public int screenHeight;
        public int screenWidth;
        public string defaultResolution;
        public string videoPreset;
        public double recBitrateBuffer;
        public string streamKey;
        public string geoLocation;
        public string userName;
        public static string GetOSFriendlyName;
        public static bool Is64BitOperatingSystem;
        public static string appDataFolder;
        public static int gpuRAM;

        List<gameType> gameTypeList = new List<gameType>();
        List<geoLocation> geoLocationList = new List<geoLocation>();

        gameType HighMotion = new gameType("High Motion", "High motion includes FPS games like Call of Duty, Halo, etc.");
        gameType MediumMotion = new gameType("Medium Motion", "Medium motion includes RTS games like League of Legends, Dota2, etc.");
        gameType LowMotion = new gameType("Low Motion", "Low motion includes turn-based games like Civilzation, Monopoly, etc.");

        geoLocation USWestSF = new geoLocation("US West: San Francisco, CA");
        geoLocation AsiaHongKong = new geoLocation("Asia: Hong Kong");
        geoLocation AsiaHongKong2 = new geoLocation("Asia: Hong Kong (2)");
        geoLocation AsiaSeoul = new geoLocation("Asia: Seoul, South Korea");
        geoLocation AsiaSeoul2 = new geoLocation("Asia: Seoul, South Korea (2)");
        geoLocation Singapore = new geoLocation("Asia: Singapore");
        geoLocation Taipei = new geoLocation("Asia: Taipei, Taiwan");
        geoLocation Tokyo = new geoLocation("Asia: Tokyo, Japan");
        geoLocation Tokyo2 = new geoLocation("Asia: Tokyo, Japan (2)");
        geoLocation Sydney = new geoLocation("Australia: Sydney");
        geoLocation Amsterdam = new geoLocation("EU: Amsterdam, NL");
        geoLocation Frankfurt = new geoLocation("EU: Frankfurt, DE");
        geoLocation London = new geoLocation("EU: London, UK");
        geoLocation Paris = new geoLocation("EU: Paris, FR");
        geoLocation Prague = new geoLocation("EU: Prague, CZ");
        geoLocation Stockholm = new geoLocation("EU: Stockholm, SE");
        geoLocation Argentina = new geoLocation("South America: Argentina");
        geoLocation Chile = new geoLocation("South America: Chile");
        geoLocation RiodeJaneiro = new geoLocation("South America: Rio de Janeiro, Brazil");
        geoLocation SaoPaulo = new geoLocation("South America: Sao Paulo, Brazil");
        geoLocation Dallas = new geoLocation("US Central: Dallas, TX");
        geoLocation Ashburn = new geoLocation("US East: Ashburn, VA");
        geoLocation Chicago = new geoLocation("US East: Chicago");
        geoLocation Miami = new geoLocation("US East: Miami, FL");
        geoLocation NewYork = new geoLocation("US East: New York, NY");
        geoLocation LosAngeles = new geoLocation("US West: Los Angeles, CA");
        geoLocation SanJose = new geoLocation("US West: San Jose, CA");
        geoLocation Seattle = new geoLocation("US West: Seattle, WA");


        ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + "Win32_Processor");
        ManagementObjectSearcher mos2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + "Win32_VideoController");

        List<compType> compTypeList = new List<compType>();
        List<GPUType> graphicsCardList = new List<GPUType>();

        compType Laptop = new compType("Laptop");
        compType Desktop = new compType("Desktop");
        GPUType GPU1 = new GPUType("");
        GPUType GPU2 = new GPUType("");
        GPUType GPU3 = new GPUType("");

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                    .IsInRole(WindowsBuiltInRole.Administrator);
        }


        public MainWindow()
        {
            InitializeComponent();

            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            screenWidth = screen.Width;
            screenHeight = screen.Height;
            defaultResolution = screenWidth + "x" + screenHeight;

            if (IsAdministrator() == true)
            {
                getCLR.IsEnabled = true;
            }

            foreach (ManagementObject mj in mos2.Get())
            {
                GrabGPU.Content = "@ Native Resolution: " + defaultResolution;
                var ram = mj.Properties["AdapterRAM"].Value as UInt32?;

                if (ram.HasValue)
                {
                    gpuRAM = ((int)ram / 1073741824) * (-1);
                }
                gpuName = (Convert.ToString(mj["Name"])) + " - " + gpuRAM.ToString() + " GB";

                if (graphicsCardList.Count == 0)
                {
                    graphicsCardList.Add(GPU1);
                    graphicsCardList[0].gpuLocate = gpuName;
                }
                else if (graphicsCardList.Count == 1)
                {
                    graphicsCardList.Add(GPU2);
                    graphicsCardList[1].gpuLocate = gpuName;
                }
                else if (graphicsCardList.Count == 2)
                {
                    graphicsCardList.Add(GPU3);
                    graphicsCardList[2].gpuLocate = gpuName;
                }
            }

            gameTypeList.Add(HighMotion);
            gameTypeList.Add(MediumMotion);
            gameTypeList.Add(LowMotion);

            geoLocationList.Add(AsiaHongKong);
            geoLocationList.Add(AsiaHongKong2);
            geoLocationList.Add(AsiaSeoul);
            geoLocationList.Add(AsiaSeoul2);
            geoLocationList.Add(Singapore);
            geoLocationList.Add(Taipei);
            geoLocationList.Add(Tokyo);
            geoLocationList.Add(Tokyo2);
            geoLocationList.Add(Sydney);
            geoLocationList.Add(Amsterdam);
            geoLocationList.Add(Frankfurt);
            geoLocationList.Add(London);
            geoLocationList.Add(Paris);
            geoLocationList.Add(Prague);
            geoLocationList.Add(Stockholm);
            geoLocationList.Add(Argentina);
            geoLocationList.Add(Chile);
            geoLocationList.Add(RiodeJaneiro);
            geoLocationList.Add(SaoPaulo);
            geoLocationList.Add(Dallas);
            geoLocationList.Add(Ashburn);
            geoLocationList.Add(Chicago);
            geoLocationList.Add(Miami);
            geoLocationList.Add(NewYork);
            geoLocationList.Add(LosAngeles);
            geoLocationList.Add(USWestSF);
            geoLocationList.Add(SanJose);
            geoLocationList.Add(Seattle);


            compTypeList.Add(Laptop);
            compTypeList.Add(Desktop);

            for (int i = 0; i < gameTypeList.Count; i++)
            {
                GrabGameType.Items.Add(gameTypeList[i].gameMotion);
            }

            for (int i = 0; i < geoLocationList.Count; i++)
            {
                geolocationBox.Items.Add(geoLocationList[i].userLocate);
            }

            for (int z = 0; z < compTypeList.Count; z++)
            {
                grabCompType.Items.Add(compTypeList[z].computerType);
            }
            for (int z = 0; z < graphicsCardList.Count; z++)
            {
                GPUTypeBox.Items.Add(graphicsCardList[z].gpuLocate);
            }
            recFPSDes.IsReadOnly = true;
            GameTypeDescription.IsReadOnly = true;
            bitrateMotionDes.IsReadOnly = true;
            maxBitrateDes.IsReadOnly = true;
            recResDes.IsReadOnly = true;

            sendToOBS.IsEnabled = false;


            GameTypeDescription.Text = "Choose the type of game you will be playing.";

            resDownscale = 1;


        }

        // Finding CPU and GPU on application activation

        private void Window_Activated(object sender, EventArgs e)
        {


            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }

            if (Environment.Is64BitOperatingSystem == true)
            {
                getOSValue.Content = result + " (64-Bit)";
            }

            else if (Environment.Is64BitOperatingSystem == false)
            {
                getOSValue.Content = result + " (32-Bit)";
            }
            

            foreach (ManagementObject mj in mos.Get())
            {
                cpuName = (Convert.ToString(mj["Name"]));
                GrabCPU.Content = cpuName;
            }
            

        }

        // Function for splitting and finding strings

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        // Show game description based on index of dropdown menu 

        private void GrabGameType_DropDownClosed(object sender, EventArgs e)
        {
            if (GrabGameType.SelectedIndex != -1)
            {
                GameTypeDescription.Text = gameTypeList[GrabGameType.SelectedIndex].motionDescription;
            }
        }


        // Pick a comp type


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Somehow find the upload speed 
        
        void UploadButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.speedtest.net/");
        }

        private void enterUploadSpeed_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (enterUploadSpeed.Text == "Upload Speed (Mbps)")
            {
                enterUploadSpeed.Text = "";
            }
        }

        // Find FPS, Recommended Bitrate, Max Bitrate, Buffer Size and Recommended Resolution for the settings applied above the separator

        private void getStreamSettings_Click(object sender, RoutedEventArgs e)
        {
            if (streamKeyPasswordBox.Password.Contains("live"))
            {
                streamKey = streamKeyPasswordBox.Password;
                enterKeyHelp.Content = "Successfully recorded Stream Key.";
            }
            else
            {
                enterKeyHelp.Content = "Error: Make sure you entered a Twitch Stream Key.";
            }

            // Get Upload Speed

            double d;
            bool isNumeric = double.TryParse(enterUploadSpeed.Text, out d);
            double n = Math.Round(d, 2);

            if (n == 0 || n < 0)
            {
                helpMessage.Content = "Error: Make sure you entered a positive number.";
            }
            else if (n > 0)
            {
                uploadSpeed = n * 1000;
                helpMessage.Content = "Confirmed: You entered " + n + " Mbps (~" + uploadSpeed + " Kbps).";

            }

            string cpuText = cpuName;


            // --- RECOMMENDED FRAMES PER SECOND --- //
            // Find the FPS based on the CPU string from the System.Management on Window_Activated

            if (cpuText.Contains("i7") || cpuText.Contains("i5") || cpuText.Contains("i3"))
            {

                // Find the Intel generation by counting the numbers after the (i) - 1st Gen has 3 numbers, 2nd Gen has 4 numbers

                string cpuGeneration = getBetween(cpuText, "-", " CPU");
                int cpuCount = cpuGeneration.Count(c => Char.IsNumber(c));

                if (cpuCount == 4)
                {
                    recFPSValue.Content = "30 FPS";
                    recFPSDes.Text = "The CPU is responsible for the encoding part of your stream. This means that higher CPU specs will allow you to increase your FPS without choppiness to your Twitch Stream. Your PC has a 2nd Generation or higher Intel i3/i5/i7 CPU, allowing you to efficiently stream at 30 FPS and possibly 60 FPS depending on the factors below.";
                    setFPS = 30;
                    resDownscale = 1;
                }
                if (cpuCount == 3)
                {
                    recFPSValue.Content = "30 FPS / Downscale";
                    recFPSDes.Text = "The CPU is responsible for the encoding part of your stream. This means that higher CPU specs will allow you to increase your FPS without choppiness to your Twitch Stream. Your PC has a 1st Generation i5/i7 CPU, which means that you might want to consider a resolution downscale to decrease choppiness on your stream.";
                    setFPS = 30;
                    resDownscale = 1;
                }

            }
            else if (cpuText.Contains("Phenom") || (cpuText.Contains("Core Duo") || (cpuText.Contains("Pentium"))))
            {
                recFPSValue.Content = "25 FPS / Downscale";
                recFPSDes.Text = "The CPU is responsible for the encoding part of your stream. This means that higher CPU specs will allow you to increase your FPS without choppiness to your Twitch Stream. Your PC has an AMD Phenom / Intel Core Duo / Intel Pentium CPU, meaning that you will have to stream at 25 FPS rather than the standard 30 FPS. You will also need to consider downscaling to 480p and using a superfast preset.";
                setFPS = 25;
                resDownscale = 1;
                videoPreset = "superfast";
            }
            else if (cpuText.Contains("FX"))
            {
                recFPSValue.Content = "25 FPS / Downscale";
                recFPSDes.Text = "The CPU is responsible for the encoding part of your stream. This means that higher CPU specs will allow you to increase your FPS without choppiness to your Twitch Stream. Your PC has an AMD FX CPU, meaning you will have to set your FPS to 25 rather than the standard 30 FPS. You should also downscale to 1.5x or 2.0x.";
                setFPS = 25;
                resDownscale = 2.00;
            }
            else if (cpuText.Contains("APU"))
            {
                recFPSValue.Content = "25 FPS / Downscale";
                recFPSDes.Text = "The CPU is responsible for the encoding part of your stream. This means that higher CPU specs will allow you to increase your FPS without choppiness to your Twitch Stream. Your PC has an AMD APU CPU, meaning you will have to set your FPS to 25 rather than the standard 30 FPS. You should also downscale to 480p and use the ultra/superfast preset.";
                setFPS = 25;
                resDownscale = 1;
                videoPreset = "ultrafast";

            }
            else
            {
                recFPSValue.Content = "Error";
                recFPSDes.Text = "It seems as though the CPU you currently have does not fit anything within our database. Contact our support team immediately for assistance.";
            }

            // --- RECOMMENDED BITRATE BASED ON MOTION --- //

            if (GrabGameType.SelectedIndex == 0)
            {
                bitrateMotionValue.Content = "3500+ Kbps (~3.5+ Mbps)";
                bitrateMotionDes.Text = "You've specified that you play First-Person Shooter games such as Call of Duty and Halo. Due to constant and extreme camera movements, set your bitrate to 3500 Kbps or above to efficiently stream these types of games. If this recommended bitrate is higher than the Maximum Bitrate below, then you may not be able to stream First-Person Shooter games. NOTE: Your Bitrate will NOT be set to this recommended number.";
            }

            else if (GrabGameType.SelectedIndex == -1)
            {
                bitrateMotionValue.Content = "Error";
                bitrateMotionDes.Text = "Please specify a Game Type above to find your recommended bitrate based on motion.";
            }
            else if (GrabGameType.SelectedIndex == 1)
            {
                bitrateMotionValue.Content = "2000-3000 Kbps (~2-3 Mbps)";
                bitrateMotionDes.Text = "You've specified that you play medium motion games such as League of Legends and Dota2. Due to a moderate amount of camera movement, set your bitrate between 2000-3000 Kbps to efficiently stream these games. If this recommended bitrate is higher than the Maximum Bitrate below, then you may not be able to stream medium motion games. NOTE: Your Bitrate will NOT be set to this recommended number.";
            }
            else if (GrabGameType.SelectedIndex == 2)
            {
                bitrateMotionValue.Content = "2000 Kbps or below";
                bitrateMotionDes.Text = "You've specified that you play low motion games such as Civilization and Monopoly. Due to very low amounts of camera movement, you may set your bitrate to anything below 2000 Kbps. You should set your Bitrate to whatever is specified below in the Maximum Bitrate section. NOTE: Your Bitrate will NOT be set to this recommended number.";
            }

            // --- MAX BITRATE AND BUFFER SIZE --- //

            double rawBitrate = uploadSpeed * 0.8;
            double dividedBitrate = rawBitrate / 1000;
            double roundedBitrate = Math.Round(dividedBitrate, 1);
            double maxBitrate = roundedBitrate * 1000;
            recBitrateBuffer = maxBitrate;

            if (uploadSpeed >= 1000000)
            {
                maxBitrateValue.Content = "Error";
                maxBitrateDes.Text = "Make sure that you entered your speed in Mbps not Kbps. This value should not be over 1000.";
            }

            else if (maxBitrate >= 3500)
            {
                maxBitrateValue.Content = "3500+ Kbps (~3.5+ Mbps)";
                maxBitrateDes.Text = "Your upload speed allows you to stream at 3500 Kbps or above. This will increase the quality of your stream and allow you to stream almost any game if your computer can handle it. Check the recommended resolution below.";
            }
            
            else if (maxBitrate < 3500 && maxBitrate >= 300)
            {
                maxBitrateValue.Content = maxBitrate + " Kbps (~" + roundedBitrate + " Mbps)";
                maxBitrateDes.Text = "Your upload speed allows you to stream at " + maxBitrate + " Kbps. Make sure to check to see if this matches your preferred Game Type. Check the recommended resolution below as well.";
            }

            else if (maxBitrate < 300 && maxBitrate > 0)
            {
                maxBitrateValue.Content = "Too Low";
                maxBitrateDes.Text = "Your upload speed is below 300 Kbps. You will have an extremely tough time streaming. Contact us immediately for help.";
            }

            else if (maxBitrate <= 0)
            {
                maxBitrateValue.Content = "Error";
                maxBitrateDes.Text = "Please make sure you have confirmed the upload speed above and that it is a positive number.";
            }

            // --- RECOMMENDED RESOLUTION --- //

            if (screenWidth > 1080)
            {
                recResValue.Content = "WARNING";
                recResDes.Text = "Your monitor's resolution is higher than 1080p (1920x1080). You're too cool for this current setup - please contact us for assistance.";
                baseHeight = 1080;
                baseWidth = 1920;
            }

            if (grabCompType.SelectedIndex == -1)
            {
                recResValue.Content = "Error";
                recResDes.Text = "Please make sure you have specified whether you are using a Laptop or a Desktop";
            }

            if (maxBitrate >= 3500)
            {

                if (grabCompType.SelectedIndex == 0 && screenHeight < 1080)
                {
                    baseHeight = 720;
                    baseWidth = 1280;
                    setFPS = 30;
                    recResValue.Content = " 720p";
                    recResDes.Text = "Since you're streaming from a laptop, your native resolution, " + defaultResolution + " is not standardard. You will have to downscale your stream settings to at 720p for a smooth stream.";
                }

                else if (grabCompType.SelectedIndex == 1)
                {
                    baseHeight = 1080;
                    baseWidth = 1920;
                    setFPS = 60;
                    recResValue.Content = "1080p / 60 FPS";
                    recResDes.Text = "Since your bitrate is above 3500 Kbps and your native resolution is " + defaultResolution + ", you can stream at 1080p at 60 FPS if you have a 2nd Generation or higher Intel i5/i7.";
                }

            }
            else if (maxBitrate < 3500 && maxBitrate >= 3000)
            {

                if (grabCompType.SelectedIndex == 0 && screenHeight < 1080)
                {
                    baseHeight = 720;
                    baseWidth = 1280;
                    setFPS = 30;
                    recResValue.Content = " 720p";
                    recResDes.Text = "Since you're streaming from a laptop, and native resolution is " + defaultResolution + ", you will have to downscale your stream settings to at 720p for a smooth stream.";
                }

                else
                {
                    baseHeight = 1080;
                    baseWidth = 1920;
                    setFPS = 30;
                    recResValue.Content = "1080p";
                    recResDes.Text = "Since your bitrate is between 3000-3500 Kbps and your native resolution is " + defaultResolution + ", you can stream at 1080p, and might be able to stream at 60 FPS if you have a 2nd Generation or higher Intel i5/i7. Make sure to use a resolution downscale if it was specified in the FPS section.";
                }

            }
            else if (maxBitrate < 3000 && maxBitrate >= 1800)
            {

                recResValue.Content = "720p / 1080p";
                recResDes.Text = "Your bitrate is between 1800-3000 Kbps, meaning you can easily stream at 720p and possibly at 1080p. If you are on a laptop or it was specified in the FPS section above, please use a resolution downscale.";
                baseHeight = 720;
                baseWidth = 1280;

            }
            else if (maxBitrate < 1800 && maxBitrate >= 900)
            {

                recResValue.Content = "480p / 720p";
                recResDes.Text = "Your bitrate is between 900-1800 Kbps, meaning you can easily stream at 480p and possibly 720p. If you are on a laptop or it was specified in the FPS section above, please use a resolution downscale.";
                baseHeight = 480;
                baseWidth = 640;

            }
            else if (maxBitrate < 900 && maxBitrate >= 600)
            {

                recResValue.Content = "360p / 480p";
                recResDes.Text = "Your bitrate is between 600-900 Kbps, meaning you can easily stream at 360p and possibly 480p. If you are on a laptop or it was specified in the FPS section above, please use a resolution downscale.";
                baseHeight = 360;
                baseWidth = 480;

            }
            else if (maxBitrate < 600 && maxBitrate >= 300)
            {

                recResValue.Content = "240p / 360p";
                recResDes.Text = "Your bitrate is between 300-600 Kbps, meaning you can easily stream at 240p and possibly 360p. If you are on a laptop or it was specified in the FPS section above, please use a resolution downscale.";
                baseHeight = 240;
                baseWidth = 426;

            }
            else if (maxBitrate < 300 && maxBitrate > 0)
            {

                recResValue.Content = "Too Low";
                recResDes.Text = "Your bitrate is below 300 Kbps. This is too low to efficiently stream. Please contact us for more assistance.";
                baseHeight = 0;
                baseWidth = 0;

            }

            else if (maxBitrate <= 0)
            {
                recResValue.Content = "Error";
                recResDes.Text = "Please make sure you have confirmed the upload speed above and that it is a positive number.";
            }

            if (geolocationBox.SelectedIndex == -1 || baseHeight == 0 || GrabGameType.SelectedIndex == -1 || enterUploadSpeed.Text == null || streamKeyPasswordBox.Password == null || grabCompType.SelectedIndex == -1)
            {
                sendToOBS.IsEnabled = false;
                getStreamSettingsHelp.Content = "Error: Make sure all fields have been filled.";
            }
            else
            {
                sendToOBS.IsEnabled = true;
                tabControl.SelectedIndex = 1;
            }
        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        // Send the settings above to OBS via the .ini file in appdata\roaming\OBS\profiles\     

        private void sendToOBS_Click(object sender, RoutedEventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFile = System.IO.Path.Combine(folder, "OBS", "profiles", "StreamStarter.ini");
            var runningProcessByName = Process.GetProcessesByName("OBS");
            openOBSButton.IsEnabled = true;
            if (runningProcessByName != null)
            {
                foreach (var process in runningProcessByName)
                {
                    process.Kill();
                }
            }
            if (geolocationBox.SelectedIndex != -1)
            {
                geoLocation = geoLocationList[geolocationBox.SelectedIndex].userLocate;
            }

            if (!File.Exists(specificFile))
            {
                if (geolocationBox.SelectedIndex == -1 || baseHeight == 0 || GrabGameType.SelectedIndex == -1)
                {
                    sendtoOBSLabel.Content = "Error: Settings could not be sent to OBS. Make sure you have entered an upload speed, chosen your location and entered your stream key.";
                }
                else
                {
                    TextWriter tw = new StreamWriter(specificFile);
                    tw.WriteLine("[Video]");
                    tw.WriteLine("FPS=" + 30);
                    tw.WriteLine("BaseHeight=" + baseHeight);
                    tw.WriteLine("BaseWidth=" + baseWidth);
                    tw.WriteLine("DisableAero=0");
                    tw.WriteLine("Downscale=" + resDownscale);
                    tw.WriteLine("Monitor=0");
                    tw.WriteLine("[Video Encoding]");
                    tw.WriteLine("KeyframeInterval=2");
                    tw.WriteLine("NVENCPreset=Automatic");
                    tw.WriteLine("X264Profile=main");
                    tw.WriteLine("Quality=8");
                    tw.WriteLine("Preset=" + videoPreset);
                    if (recBitrateBuffer >= 3500)
                    {
                        tw.WriteLine("MaxBitrate=" + 3500);
                        tw.WriteLine("BufferSize=" + 3500);
                    }
                    else if (recBitrateBuffer < 3500)
                    {
                        tw.WriteLine("MaxBitrate=" + recBitrateBuffer);
                        tw.WriteLine("BufferSize=" + recBitrateBuffer);
                    }
                    tw.WriteLine("[Publish]");
                    tw.WriteLine("PlayPath=" + streamKey);
                    tw.WriteLine("URL=" + geoLocation);
                    sendtoOBSLabel.Content = "You have successfully sent these settings to OBS.";

                    tw.Close();
                }
                

            }
            else if (File.Exists(specificFile))
            {
                if (geolocationBox.SelectedIndex == -1 || baseHeight == 0 || GrabGameType.SelectedIndex == -1)
                {
                    sendtoOBSLabel.Content = "Error: Settings could not be sent to OBS. Make sure you have entered an upload speed, chosen your location and entered your stream key.";
                }
                else
                {
                    TextWriter tw = new StreamWriter(specificFile);
                    tw.WriteLine("[Video]");
                    tw.WriteLine("FPS=" + 30);
                    tw.WriteLine("BaseHeight=" + baseHeight);
                    tw.WriteLine("BaseWidth=" + baseWidth);
                    tw.WriteLine("DisableAero=0");
                    tw.WriteLine("Downscale=" + resDownscale);
                    tw.WriteLine("Monitor=0");
                    tw.WriteLine("[Video Encoding]");
                    tw.WriteLine("KeyframeInterval=2");
                    tw.WriteLine("NVENCPreset=Automatic");
                    tw.WriteLine("X264Profile=main");
                    tw.WriteLine("Quality=8");
                    tw.WriteLine("Preset=" + videoPreset);
                    if (recBitrateBuffer >= 3500)
                    {
                        tw.WriteLine("MaxBitrate=" + 3500);
                        tw.WriteLine("BufferSize=" + 3500);
                    }
                    else if (recBitrateBuffer < 3500)
                    {
                        tw.WriteLine("MaxBitrate=" + recBitrateBuffer);
                        tw.WriteLine("BufferSize=" + recBitrateBuffer);
                    }
                    tw.WriteLine("[Publish]");
                    tw.WriteLine("PlayPath=" + streamKey);
                    tw.WriteLine("URL=" + geoLocation);
                    tw.WriteLine("Service=1");
                    sendtoOBSLabel.Content = "You have successfully sent these settings to OBS.";

                    tw.Close();
                }
            }
        }

        private void streamKeyFinder_Click(object sender, RoutedEventArgs e)
        {
            userName = enterTwitchUsername.Text;

            if (userName == "Username Here" || userName == "")
            {
                userNameDes.Content = "Error: Please make sure you entered your username before trying to find your Stream Key.";
            }

            else if (userName != null)
            {
                System.Diagnostics.Process.Start("http://www.twitch.tv/" + userName + "/dashboard/streamkey");
                userNameDes.Content = "Confirmed. If you got an error, please make sure you spelled your username correctly and that you're logged onto Twitch.";
            }

            
        }

        private void enterTwitchUsername_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (enterTwitchUsername.Text == "Username Here")
            {
                enterTwitchUsername.Text = "";
            }
        }

        private void visualStudioDownload_Click(object sender, RoutedEventArgs e)
        {
            if (Environment.Is64BitOperatingSystem == true)
            {
                WebClient vsStudioClient = new WebClient();
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string specificFile = System.IO.Path.Combine(folder, "vcredist_x64.exe");
                vsStudioClient.DownloadFile("https://download.microsoft.com/download/2/E/6/2E61CFA4-993B-4DD4-91DA-3737CD5CD6E3/vcredist_x64.exe", specificFile);
                Process.Start(specificFile);
                downloadStatusVS.Content = "Completed!";

            }
            else if (Environment.Is64BitOperatingSystem == false)
            {
                WebClient vsStudioClient = new WebClient();
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string specificFile = System.IO.Path.Combine(folder, "vcredist_x86.exe");
                vsStudioClient.DownloadFile("https://download.microsoft.com/download/2/E/6/2E61CFA4-993B-4DD4-91DA-3737CD5CD6E3/vcredist_x86.exe", specificFile);
                Process.Start(specificFile);
                downloadStatusVS.Content = "Completed!";

            }
        }

        private void netDownload_Click(object sender, RoutedEventArgs e)
        {
            WebClient netClient = new WebClient();
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string specificFile = System.IO.Path.Combine(folder, "netFramework.exe");
            netClient.DownloadFile("http://go.microsoft.com/fwlink/?LinkId=328843", specificFile);
            Process.Start(specificFile);
            downloadStatusNET.Content = "Completed!";

        }

        private void getCLR_Click(object sender, RoutedEventArgs e)
        {

            if (Environment.Is64BitOperatingSystem == true)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string specificFile = System.IO.Path.Combine(folder, "CLRBrowserSourcePlugin-20140909x64.zip");
                WebClient CLR64Client = new WebClient();
                FileInfo file = new FileInfo(specificFile);

                if (!Directory.Exists("C:\\Program Files\\OBS\\plugins"))
                {
                    downloadStatusCLR64.Content = "Error: Looks like you don't have a 64-bit C:\\ file path. Contact us for assistance.";
                }

                else if (File.Exists("C:\\Program Files\\OBS\\plugins\\CLRHostPlugin.dll") || File.Exists("C:\\Program Files\\OBS\\plugins\\CLRHostPlugin"))
                {
                    downloadStatusCLR64.Content = "64-Bit CLR Already installed!";
                }
                else
                {
                    CLR64Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(CLR64Client_DownloadProgressChanged);
                    CLR64Client.DownloadFileCompleted += new AsyncCompletedEventHandler(CLR64Client_DownloadFileCompleted);
                    CLR64Client.DownloadFileAsync(new Uri("http://catchexception.org/CBSP/CLRBrowserSourcePlugin-20140909x64.zip"), file.FullName);

                }

                string folder1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string specificFile1 = System.IO.Path.Combine(folder1, "CLRBrowserSourcePlugin-20140909x86.zip");
                FileInfo file1 = new FileInfo(specificFile1);
                WebClient CLR32Client = new WebClient();

                if (!Directory.Exists("C:\\Program Files (x86)\\OBS\\plugins"))
                {
                    downloadStatusCLR.Content = "Error: Looks like you don't have a 32-bit C:\\ file path. Contact us for assistance.";
                }

                else if (File.Exists("C:\\Program Files (x86)\\OBS\\plugins\\CLRHostPlugin.dll") || File.Exists("C:\\Program Files (x86)\\OBS\\plugins\\CLRHostPlugin"))
                {
                    downloadStatusCLR.Content = "32-Bit CLR Already installed!";
                }

                else
                {
                    CLR32Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(CLR32Client_DownloadProgressChanged);
                    CLR32Client.DownloadFileCompleted += new AsyncCompletedEventHandler(CLR32Client_DownloadFileCompleted);
                    CLR32Client.DownloadFileAsync(new Uri ("http://catchexception.org/CBSP/CLRBrowserSourcePlugin-20140909x86.zip"), file1.FullName);

                }
            }
            else if (Environment.Is64BitOperatingSystem == false)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string specificFile = System.IO.Path.Combine(folder, "CLRBrowserSourcePlugin-20140909x86.zip");
                FileInfo file = new FileInfo(specificFile);
                WebClient CLR32Client = new WebClient();


                if (!Directory.Exists("C:\\Program Files (x86)\\OBS\\plugins"))
                {
                    downloadStatusCLR.Content = "Error: Looks like you don't have a 32-bit C:\\ file path. Contact us for assistance.";
                }
                
                else if (File.Exists("C:\\Program Files (x86)\\OBS\\plugins\\CLRHostPlugin.dll") || File.Exists("C:\\Program Files (x86)\\OBS\\plugins\\CLRHostPlugin"))
                {
                    downloadStatusCLR.Content = "32-Bit CLR Already installed!";
                }
                else
                {
                    CLR32Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(CLR32Client_DownloadProgressChanged);
                    CLR32Client.DownloadFileCompleted += new AsyncCompletedEventHandler(CLR32Client_DownloadFileCompleted);
                    CLR32Client.DownloadFileAsync(new Uri("http://catchexception.org/CBSP/CLRBrowserSourcePlugin-20140909x86.zip"), file.FullName);


                }
            }
        }
        private void CLR64Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadStatusCLR64.Content = "Downloading and installing (64-bit)...";
            progressBarCLR64.Value = e.ProgressPercentage;
        }
        void CLR64Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string specificFile = System.IO.Path.Combine(folder, "CLRBrowserSourcePlugin-20140909x64.zip");
            ZipFile.ExtractToDirectory(specificFile, "C:\\Program Files\\OBS\\plugins");
            downloadStatusCLR64.Content = "Completed!";
        }
        private void CLR32Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadStatusCLR.Content = "Downloading and installing (32-bit)...";
            progressBarCLR.Value = e.ProgressPercentage;
        }
        void CLR32Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string specificFile = System.IO.Path.Combine(folder, "CLRBrowserSourcePlugin-20140909x86.zip");
            ZipFile.ExtractToDirectory(specificFile, "C:\\Program Files (x86)\\OBS\\plugins");
            downloadStatusCLR.Content = "Completed!";
        }

        private void openOBSButton_Click(object sender, RoutedEventArgs e)
        {
            var runningProcessByName = Process.GetProcessesByName("OBS");
            if (runningProcessByName.Length == 0)
            {
                if (Environment.Is64BitOperatingSystem == true)
                {
                    Process.Start("C:\\Program Files\\OBS\\OBS.exe");
                }
                else if(Environment.Is64BitOperatingSystem == false)
                {
                    Process.Start("C:\\Program Files (x86)\\OBS\\OBS.exe");
                }
                
            }
        }
    }
}
