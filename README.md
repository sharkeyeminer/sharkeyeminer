# Shark Eye Miner

I want to present you mining software that works in one click, it is suitable for any GPU coins, and more specifically ETH, ZEC, BTG, and others. He works with the most relevant mining programs, such as Phoenix miner, Gminer, TT-miner, and takes care of all the inconvenience of using them from you. It is for this that it was created, for situations when you have mining rigs on AMD and Nvidia video cards, and you need to use different programs for mining on both cards. The primary goal of this software is comfort and simplification of the mining process itself.




# Screenshot


[![Running View](https://github.com/sharkeyeminer/sharkeyeminer/blob/master/Screenshots/photo_2020-05-12_20-21-41.png?raw=true)](https://github.com/sharkeyeminer/sharkeyeminer/blob/master/Screenshots/photo_2020-05-12_20-21-41.png?raw=true)
# [](https://github.com/sharkeyeminer/sharkeyeminerr#the-reasons-to-use)The main reasons to use



The main reason for using this software is that setting up the miner takes a lot of time that you can spend on something else. In particular, if you have different GPUs or you need to quickly switch between coins or wallet addresses. It brings some discomfort. Shark Eye Miner specializes in having all these features at hand in one place. This is open source, so anyone can download the code / tool and use it as is or make changes to suit their needs.

The main reason for creating the Shark Eye Miner was my inconvenience with switching between Nvidia and AMD cards. At that time, I used the Claymore miner for AMD and EWBF for Nvidia while mining Zcash. But as we know, often when a new job does not work, the EWBF miner stops its work. After which I had to manually run it later. And so time after time. Scripting for everything had to spend extra time. Therefore, I thought, why don’t I create a tool that will benefit everyone and will solve this problem forever.
Until now, I tested Awesome Miner and Minergate, but both were closed and did not enjoy much trust. Therefore, I intend to create a universal tool that almost anything can use at my discretion to satisfy my needs.

It is very important for me to know your opinion about the project, as well as to delete your wishes, if any. To notify me of problems that require improvement, you can send an email to sharkeyeminer@gmail.com


# [](https://github.com/sharkeyeminer/sharkeyeminer#main-functions)Main Functions

 Below are some Features for the first version:

- Support all coins based on GPU (ETH, ZEC, XMR, BTG, ETN, ZEN, ETC, ZCL and others)
- CPU mining with XMR and ETN.
- Support for different graphics cards. Nvidia and AMD
-  Switching in 1 click between miners and coins.
- Mine on Startup
-  Automatic restart of the miner in case of failure or accidental closure.
- Shark Eye Miner is open source. We do not steal a hashrate like Minergate.
- Quick Switch to Pool Account


# [](https://github.com/sharkeyeminer/sharkeyeminer#donations)Donations

If you would like to support this project, your donations would be greatly appreciated

### [](https://github.com/sharkeyeminer/sharkeyeminer#bitcoin)Bitcoin
1HeS1VaLVAVp67TtVNkuer8YLD2B2V6EFd


### [](https://github.com/sharkeyeminer/sharkeyeminer#ethereum)Ethereum
0xFDc4aafDd16469936D8625fBB773377519153910 

### [](https://github.com/sharkeyeminer/sharkeyeminer#litecoin)Litecoin
LMbUDwYVaNCtbMAD8fwhMR79JUAoxafMvn


# [](https://github.com/sharkeyeminer/sharkeyeminer#how-to-works)How it Works


-    During the first opening of the software, you will have “Default Ethereum Miner” in the settings. This is done so that you could test the software itself

-    This can all be edited and used, in which case it becomes an ordinary miner. To do this, right-click and select “Change Miner”, and replace the address with your wallet.

-    Also, you can click "Add Miner" and create a new miner.

-   ATTENTION! Adding a new miner will remove all unedited miners the next time you restart the application.

-   There is also a right click menu in the list of miners. It is intended to edit / delete or activate the miner.

-   Activation of the miner. The miner can be started using the “Start” button, but when the system restarts, it will not turn on by default, for this you need to select “YES” in the “Mine on Launch” menu.

-  Settings screen: IMPORTANT! Edit the settings and **enable "Launch on Start" and "Mine on Launch".**

-  The Script tab shows a script according to which everything will work. To edit this, click on Edit on the right and then save with Save.

-   . Closing the Shark Eye Miner does not kill the process itself. It minimizes it to tray. For a complete lock, you need to open the system tray, right-click and select "Exit".

-   Closing the Shark Eye Miner during mining will not stop the work of the miners themselves. You can close it if you have completely done the setup and you no longer need a graphical interface.

-   All downloaded data is stored in% Appdata% \ Shark Eye. It creates the <your_miner> .bat file inside the software used for mining. ATTENTION! It is not recommended to make your own corrections if you are not an experienced user. 

-   The sharkeyeminer.json file contains all the information about your configuration. Do not delete this file! Because you will have to reconfigure everything. But even if you deleted do not be afraid, you will not lose your payouts.

-  To transfer all your data to another computer, simply copy the sharkeyeminer.json file to another computer in the same% Appdata% \ SharkEye folder.

-    If the miner’s window is constantly closing, it means that your equipment is not suitable for mining.

-   In order to disable the console display, on the settings screen, select the option “do not display the miner’s user interface”. Personally, we do not recommend doing this.

# [](https://github.com/sharkeyeminer/sharkeyeminer#system-requirements)System requirements

1.  Currently supports only Windows 7 and upwards
2.  .Net Framework 4.5

# [](https://github.com/sharkeyeminer/sharkeyeminer#planned-features)Planned Features

-   Profitability calculator
-   Mining several different coins on different graphics cards
-   Auto reconnect to Wi-Fi. If the Wi-Fi connection is lost, it does not reconnect, and the miner freezes. Therefore, for your comfort, I plan to fix this problem in the future.
-   Launching Scripts and timer commands, for example: rebooting a PC at a set time, and so on. 
-   The possibility of double mining at the expense of temperature increase



## [](https://github.com/sharkeyeminer/sharkeyeminer#nvidia-fixing-monero-cryptonght-problem)(Nvidia) Fixing Monero / Cryptonight Problem

Nvidia (ccminer) is unstable in Cryptonight.
Some antiviruses mistakenly classify ccminer as a virus. Because of this, in turn, they may mistakenly identify Shark Eye Miner as a virus. In this version, Nvidia is supported, but not defined by default when creating a new miner. If you are the owner of video cards from Nvidia then you need to manually select from the checkbox on the scripts tab. Use it only if you need it. In the future, if Anti-Virus becomes a problem, Nvidia for Cryptonight will then have to withdraw it from the main version of Shark Eye Miner. But it may be granted as an Exception. Also monitoring of hashrate and shares is not currently supported for Nvidia for Cryptonight coins.

1.  Either you need to add the file to the exception, or temporarily suspend the antivirus.

2.  For Monero mining on Nvidia, you must install Visual Studio[https://www.microsoft.com/en-in/download/details.aspx?id=5555](https://www.microsoft.com/en-in/download/details.aspx?id=5555)

# [](https://github.com/sharkeyeminer/sharkeyeminer#screenshots-of-different-screens)Screenshots of different screens



![[photo_2020-05-12_20-21-58.png](https://github.com/sharkeyeminer/sharkeyeminer/blob/master/Screenshots/photo_2020-05-12_20-21-58.png "photo_2020-05-12_20-21-58.png")](https://github.com/sharkeyeminer/sharkeyeminer/blob/master/Screenshots/photo_2020-05-12_20-21-58.png?raw=true)



![Adding a Miner](https://github.com/sharkeyeminer/sharkeyeminer/blob/master/Screenshots/photo_2020-05-12_20-21-54.png?raw=true)

