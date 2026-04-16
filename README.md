# CitrixScanning Demo

## Description
This sample application shows the needed code for CreateDeviceSession needed 
for Citrix and RemoteDesktop scanning.

This is the C# vesion. We also have a [VB.NET version](https://github.com/AtalaSupport/DemoGallery_Desktop_CitrixScanningDemo_VB_x86) available.  

## See Also
[HOWTO: Scan through Citrix or RDP (Terminal Server)](https://www.atalasoft.com/kb2/KB/50227/HOWTO-Scan-through-Citrix-or-RDP-Terminal-Server)


## Licensing
This demo assumes you have the Atalasoft DotImage SDK installed, but you only need licsning for DotTwain (Or DotImage Document Imaging)

You may also request a 30 day evaluation when installing / activating.

## SDK Dependencies
This app was built based on 2026.2.0.0. It targets .NET Framework 4.6.2 and was created in Visual Studio 2019. We use this older Visual Studio as it's the last version that ran natively in x86 for 32 bit compatibility "out of the box". As noted above, the choice to use x86 in TWAIN scanning applications is deliberate as many scanner drivers are not native 64 bit. This gives a wider scanner comptaiblity.

[Download DotImage](https://www.atalasoft.com/BeginDownload/DotImageDownloadPage)


### Using NuGet for SDK Dependencies
We do publish our SDK components to NuGet. We have chosen to base the demo on local installed SDK because this leads to much smaller applications (NuGet packages add a lot of overhead due to the way they're packaged and deployed, and many of our demos -- including this one -- are often used to reproduce issues that need to be submitted to support. Apps that use NuGet are often significantly larger and run up against our maximum support case upload size)

Still, if you wish to use NuGet for the dependencies instead of relying on locally installed SDK, you can.

- Take note of each of the references we've included:
    - Atalasoft.DotTwain.dll
    - Atalasoft.Shared.dll
- Remove those referneces
- Open the NuGet Package Manger from `Tools -> NuGet Package Manager -> Manage NuGet Packages for this Solution`
- Browse for and install Atalasoft.DotTwain.x86. It will pull in the needed DotTwain component and the shared dependency.


## Downloading source
The sources can be downloaded for [c#](https://github.com/AtalaSupport/DemoGallery_Desktop_CitrixScanningDemo_CS_x86/archive/refs/heads/main.zip) and [VB.NET](https://github.com/AtalaSupport/DemoGallery_Desktop_CitrixScanningDemo_VB_x86/archive/refs/heads/main.zip)


## Cloning
We recommend the following

Example: git for windows
```bash
git clone https://github.com/AtalaSupport/DemoGallery_Desktop_CitrixScanningDemo_CS_x86.git CitrixScanningDemo
```

## Related documentation
In addition to this README, the Atalasoft documentation set includes the following:  
- [AtalaSupport Github](https://github.com/AtalaSupport/) For an extensive set of sample apps.  
- [Atalasoft's APIs & Developer Guides page](https://www.atalasoft.com/Support/APIs-Dev-Guides) for our Developers guide and API references.  
- [Atalasoft Support](http://www.atalasoft.com/support/) for our main support portal.
- [Atalasoft Knowledgebase](http://www.atalasoft.com/kb2) where you can find answers to common questions / issues.  


## Getting Help for Atalasoft products
Atalasoft regularly updates our support [Knowledgebase](http://www.atalasoft.com/kb2) with the latest information about our products. To access some resources, you must have a valid Support Agreement with an authorized Atalasoft Reseller/Partner or with Atalasoft directly. Use the tools that Atalasoft provides for researching and identifying issues. 

Customers with an active evaluation, or those with active support / maintenance may [create a support case](https://www.atalasoft.com/Support/my-portal/Cases/Create-Case) 24/7, or call in to support ([+1 949 236-6510](tel:19492366510) ) during our normal support hours (Monday - Friday 8:00am to 5:00PM Eastern (New York) time).  

Customers who are unable to create a case or call in may [email our Sales Team](email:sales@atalasoft.com).  
