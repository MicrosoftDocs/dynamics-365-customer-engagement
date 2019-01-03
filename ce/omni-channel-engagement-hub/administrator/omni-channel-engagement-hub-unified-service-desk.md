---
title: "Omni-channel Engagement Hub on Unified Service Desk"
description: "Omni-channel Engagement Hub solution is an application that you need to install on Unified Service Desk client application."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: C6488858-82BF-450A-90F4-83FB2C41718C
ms.custom: 
---

# Omni-channel Engagement Hub – Unified Service Desk

Unified Service Desk for Dynamics 365 Customer Engagement apps is a client application. You need to install the Unified Service Desk client application on every agent desktop to use Omni-channel Engagement Hub. 
 
Omni-channel Engagement Hub is packaged as solution that you need to deploy on a Dynamics 365 for Customer Service Hub application instance. Use the Microsoft Dynamics 365 Package Deployer to deploy the Omni-channel Engagement Hub solution on the Customer Service Hub application instance.

## Download the Package Deployer

Download the [Microsoft Dynamics 365 Package Deployer](http://go.microsoft.com/fwlink/p/?LinkID=872261) and extract the contents in to a folder.

## Download Unified Service Desk client application

To download the Unified Service Desk client application, you must join the Omni-channel Engagement Hub - Preview program.

> [!Note]
> Go to (Experience Dynamics 365)[https://experience.dynamics.com/] and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

## Install Unified Service Desk client

To learn how to install Unified Serivce Desk, see [Install Unified Service Desk](../../unified-service-desk/admin/install-upgrade-unified-service-desk-client.md).

Make sure you computer meets all requirements before you install the Unified Service Desk client application. More information: [Unified Service Desk system requirements](../../unified-service-desk/admin/unified-service-desk-system-requirements.md) 

## Configure Unified Service Desk recommended settings for Internet Explorer

The Internet Explorer process is used to host web applications in Unified Service Desk. When you use Omni-channel Engagement Hub on Unified Service Desk client application, certain settings are recommended for Internt Explorer for optimal performance.

To know more information about manually configuring the settings of Internet Explorer, see [Internet Explorer setting guidelines](../../unified-service-desk/admin/internet-explorer-settings-bpa.md).

Download the **AddRecommendedIESettings** batch file from **Dynamics Insider Program** by joining the **Omni-channel Engagement Hub – Preview** program.

Use the batch file and configure the settings on the every client desktops. The batch file configures the Internet Explorer Settings for the following areas:

 - Enable popups for trusted sources 
 - Enable Protected Mode option
 - Tab Process Growth (TabProcGrowth) registry key
 - Tab Shutdown Delay (TabShutdownDelay) registry key
 - Enable Automatic Crash Recovery option

## Execute the batch file

1.	Download the batch file from the **Dynamics Insider Portal**.

2.	Go to the location where you have saved the batch file.

3.	Double-click the **AddRecommendedIESettings.bat** file to execute. You can see the command prompt showing the script execution.

4.	After the execution, press any key to exit the batch file execution.

The **AddRecommendedIESettings** batch file contains the following script:

```Shell
@echo off

echo Adding sources for trusted popups
echo.

REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.core.windows.net /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.microsoftonline.com /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.office.com /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.powerbi.com /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.dynamics.com /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.crmdynint.com /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.azureedge.net /t REG_BINARY /d 0 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\New Windows\Allow" /v *.azurewebsites.net /t REG_BINARY /d 0 /f

echo.
echo Setting protected mode in all zones
echo.

REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\1" /v 2500 /t REG_DWORD /d 00000000 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\2" /v 2500 /t REG_DWORD /d 00000000 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3" /v 2500 /t REG_DWORD /d 00000000 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\4" /v 2500 /t REG_DWORD /d 00000000 /f

echo.
echo Adding Best Practices Analyzer recommended settings for better performance
echo.

REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main" /v TabProcGrowth /t REG_DWORD /d 00000010 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main" /v TabShutdownDelay /t REG_DWORD /d 00000000 /f
REG ADD "HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Recovery" /v AutoRecover /t REG_DWORD /d 00000002 /f

echo.
set /p input="Press any key to exit..."

```

The batch file updates the following URLs to the **Allowed sites** section of the **Pop-up Blocker** settings. You can view and also add the the allowed sites manually by opening Internet Explorer > Settings > Internet Options > Privacy. Under the **Pop-up Blocker** section, select Settings and in the **Turn on Pop-up Blocker Settings** window, you can see the sites under the **Allowed sites** section.

 - *.core.windows.net
 - *.microsoftonline.com
 - *.office.com
 - *.powerbi.com
 - *.dynamics.com
 - *.crmdynint.com
 - *.azureedge.net
 - *.azurewebsites.net

Based on your organization requirements if you have added any URLs in allowed sites, the batch file adds the the above-mentioned URLs to the existing list.

You can also manually add the websites to enable pops for trusted sources by following steps:

1. Open Internet Explorer.
2. Select **Tools** > **Internet Options** > **Privacy**.
3. In the **Turn on pop-up Blocker** section, select **Settings**.
4. In the **Address of website to allow** field, specify one URL and select **Add**. <br>
    Add the above mentioned websites.
5. Select **Close**, and then select **OK**.

To add the other settings manually, see [Internet Explorer setting guidelines](../../unified-service-desk/admin/internet-explorer-settings-bpa.md).
