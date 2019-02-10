---
title: "Omni-channel Engagement Hub on Unified Service Desk | MicrosoftDocs"
description: "Omni-channel Engagement Hub solution is an application that you need to install on Unified Service Desk client application."
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 2/8/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: C6488858-82BF-450A-90F4-83FB2C41718C
ms.custom: 
---

# Omni-channel Engagement Hub on Unified Service Desk

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!NOTE]
> The topic applies when you want to use Omni-channel Engagement Hub with Unified Service Desk client application. 

Unified Service Desk for Dynamics 365 for Customer Engagement apps is a client application. You need to install the Unified Service Desk client application on every agent desktop to use Omni-channel Engagement Hub. 
 
Omni-channel Engagement Hub is packaged as solution that you need to deploy on a Dynamics 365 for Customer Service Hub application instance. Use the Microsoft Dynamics 365 Package Deployer to deploy the Omni-channel Engagement Hub solution on the Customer Service Hub application instance.

## Download Unified Service Desk client application

To download the Unified Service Desk client application, you must join the Omni-channel Engagement Hub - Preview program.

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.


## Install Unified Service Desk client application

To learn how to install Unified Service Desk, see [Install Unified Service Desk](/dynamics365/customer-engagement/unified-service-desk/admin/install-upgrade-unified-service-desk-client).

Make sure you computer meets all requirements before you install the Unified Service Desk client application. More information: [Unified Service Desk system requirements](/dynamics365/customer-engagement/unified-service-desk/admin/unified-service-desk-system-requirements)

## Deploy Unified Service Desk - Omni-channel Engagement Hub package

Microsoft Dynamics 365 Package Deployer enables you to deploy **Unified Service Desk - Omni-channel Engagement Hub - Preview** package on a Dynamics 365 for Customer Engagement instance.

To download the **Unified Service Desk - Omni-channel Engagement Hub - Preview** package and Dynamics 365 Package Deployer, you must join the Omni-channel Engagement Hub - Preview program.

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

> [!Important]
> As Omni-channel Engagement Hub is in the preview, we recommend deploying the **Unified Service Desk - Omni-channel Engagement Hub - Preview** package on a new organization. We recommend not to use your existing organization (test or production) for testing Omni-channel Engagement Hub - Preview.

1. Download the **OmnichannelUnifiedServiceDeskPackage.zip** and save it on your computer. Extract the contents in to a folder.<br> The extracted contents contain the **PackageDeployer.exe**, **OmnichannelUSDPackage**, and assembly files.

2. Run the **PackageDeployer.exe** file. 

3. In the **Connect to Microsoft Dynamics 365 for Customer Engagement** screen, provide authentication details to connect to the Customer Engagement instance where you want to deploy the package.

4. The next screen displays information about the package that will be installed on your Customer Engagement instance. Review the information, and choose **Next**.

5. The **Ready to Install** screen displays the package name for deployment and name of the Customer Engagement organization. Review the information, and choose **Next**.

6. The next screen displays the validation status of the package. After the validation completes successfully, choose **Next**.

7. The next page displays the package deployment status. A confirmation message is displayed on successful deployment of the package. Select **Next**.

8. The **Installation Complete** screen displays the name and information about the package that you deployed. Review the information, and choose **Finish** to exit the Package Deployer tool.

To learn more, see [Deploy a sample Unified Service Desk package using Package Deployer](/dynamics365/customer-engagement/unified-service-desk/admin/deploy-sample-unified-service-desk-applications-using-package-deployer?view=dynamics-usd-4#deploy-a-sample-unified-service-desk-package-using-package-deployer
).

## Set up Edge Process with Unified Service Desk

The Edge Process is used to host web applications in Unified Service Desk client application. More information: [Edge Process (Preview)](/dynamics365/customer-engagement/unified-service-desk/edge-process)

## Set up Unified Service Desk recommended settings for Internet Explorer

The Internet Explorer process is used to host web applications in Unified Service Desk client application. When you use Omni-channel Engagement Hub on Unified Service Desk client application, certain settings are recommended for Internet Explorer for optimal performance.

Set up the Internet Explorer Settings on the every client desktops for the following areas :

 - Enable popups for trusted sources 
 - Enable Protected Mode option
 - Tab Process Growth (TabProcGrowth) registry key
 - Tab Shutdown Delay (TabShutdownDelay) registry key
 - Enable Automatic Crash Recovery option

You can update the recommended settings in the following ways:

- Using PowerShell script
- Manually

### Set up the recommended settings using PowerShell script

Download the **AddRecommendedIESettings** PowerShell script file from **Dynamics Insider Program** by joining the **Omni-channel Engagement Hub – Preview** program.

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

#### Run the AddRecommendedIESettings PowerShell script file

1. Download the **AddRecommendedIESettings** PowerShell script file from the **Dynamics Insider Portal**.

2. Go to the location where you have saved the PowerShell script file.

3. Right-click the **AddRecommendedIESettings** PowerShell script file to execute and select **Run with PowerShell** to the run the script.

4. After the execution, press any key to exit the batch file execution.

The **AddRecommendedIESettings** PowerShell script file contains the following snippet:

```PowerShell
Write-Host "The powershell script adds necessary registry settings to allow Internet Explorer popups from trusted sources."
Write-Host

Write-Host "-------------------"
Write-Host "TRUSTED URL SOURCES"
Write-Host "-------------------"

$registryPath = "HKCU:\Software\Microsoft\Internet Explorer\New Windows\Allow"
IF((Test-Path $registryPath))
  {
    $sampleOrgUrl = 'https://orgname.dynamics.com'
    $samplePowerBIUrl = 'https://instancename.powerbi.com'
    $orgUrlPromptMessage = 'Enter the Dynamics 365 for Customer Engagement organization URL (' + $sampleOrgUrl + ') to include as a trusted source and allow Internet Explorer popups (Mandatory)'
    $powerBIUrlPromptMessage = 'Enter the Power BI URL (' + $samplePowerBIUrl + ') to include as a trusted source and allow Internet Explorer popups (Mandatory)'

    $orgUrl = Read-Host -Prompt $orgUrlPromptMessage
    $orgUrl = $orgUrl.Trim()
    IF(![string]::IsNullOrEmpty($orgUrl) -And $orgUrl -ne $sampleOrgUrl)
    {
        New-ItemProperty -Path $registryPath -Name $orgUrl -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
        Write-Host "The Dynamics 365 for Customer Engagement organization URL $orgUrl is added as a trusted source."
    }
    ELSE
    {
        Write-Host "$orgUrl is not a valid Dynamics 365 for Customer Engagement organization URL."
    }
    
    Write-Host

    $powerBIUrl = Read-Host -Prompt $powerBIUrlPromptMessage
    $powerBIUrl = $powerBIUrl.Trim()
    IF(![string]::IsNullOrEmpty($powerBIUrl) -And $powerBIUrl -ne $samplePowerBIUrl)
    {    
        New-ItemProperty -Path $registryPath -Name $powerBIUrl -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
        Write-Host "The Power BI URL $powerBIUrl is added as a trusted source."
    }
    ELSE
    {
        Write-Host "$powerBIUrl is not a valid Power BI instance URL."
    }
    Write-Host

    New-ItemProperty -Path $registryPath -Name 'https://login.microsoftonline.com' -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
    New-ItemProperty -Path $registryPath -Name 'https://www.office.com' -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
    New-ItemProperty -Path $registryPath -Name 'https://oc-cdn-public.azureedge.net' -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
    New-ItemProperty -Path $registryPath -Name 'https://oc-auth.azurewebsites.net' -Value ([byte[]](0x00,0x00)) -PropertyType BINARY -Force | Out-Null
    Write-Host "The URLs are added in the registry settings."
 }
 ELSE
 {
    Write-Host "Unable to find registry path $registryPath. The registry settings are not updated."
 }

Write-Host

Write-Host "----------------------------"
Write-Host "ENABLE PROTECTED MODE OPTION"
Write-Host "----------------------------"

Write-Host "Enable the Enable Protected Mode option. The option is a Unified Service Desk recommended registry setting and enables security settings in all Internet Zones. (Optional)"
$inputProtectedMode= Read-Host -Prompt 'Press Y to enable the enable protected mode setting. Press any key to skip the step'
IF($inputProtectedMode -eq "Y")
{
    New-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\1' -Name 2500 -Value 0 -PropertyType DWORD -Force | Out-Null
    New-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\2' -Name 2500 -Value 0 -PropertyType DWORD -Force | Out-Null
    New-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3' -Name 2500 -Value 0 -PropertyType DWORD -Force | Out-Null
    New-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\4' -Name 2500 -Value 0 -PropertyType DWORD -Force | Out-Null
    Write-Host "The Enable Protected Mode registry is enabled successfully."
}
Write-Host

Write-Host "--------------------------------------------"
Write-Host "BEST PRACTICES ANALYZER RECOMMENDED SETTINGS"
Write-Host "--------------------------------------------"

Write-Host "Add Unified Service Desk - Best Practices Analyzer recommended settings for better performance of Internet Explorer process. (Optional)"
$inputIESettings= Read-Host -Prompt 'Press Y to add these settings. Press any key to skip this step'
IF($inputIESettings -eq "Y")
{
    New-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Main" -Name TabProcGrowth -Value 00000010 -PropertyType DWORD -Force | Out-Null
    New-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Main" -Name TabShutdownDelay -Value 00000000 -PropertyType DWORD -Force | Out-Null
    New-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Recovery" -Name AutoRecover -Value 00000002 -PropertyType DWORD -Force | Out-Null
    Write-Host "The settings are added successfully."
}
Write-Host
Read-Host -Prompt 'Press any key to exit...' 
```

The PowerShell script file updates the following URLs to the **Allowed sites** section of the **Pop-up Blocker** settings. You can view and also add the the allowed sites manually by opening **Internet Explorer** > **Settings** > **Internet Options** > **Privacy**. Under the **Pop-up Blocker** section, select Settings and in the **Turn on Pop-up Blocker Settings** window, you can see the sites under the **Allowed sites** section.

 - https://login.microsoftonline.com
 - https://www.office.com
 - <instance name>.powerbi.com
 - <org name>.dynamics.com
 - https://oc-cdn-public.azureedge.net
 - https://oc-auth.azurewebsites.net

 Based on your organization requirements, you can add any other URLs in allowed sites along with the above-mentioned URLs.

Also, the PowerShell script updates the recommended Internet Explorer settings such as **Enable Protected Mode** option, **TabProcGrowth** (Tab Process Growth), **TabShutdownDelay** (Tab Shutdown Delay) registry key, and **Enable Automatic Crash Recovery** option.

## Set up the recommended settings manually

### Enable popups for trusted sources
 1. Open Internet Explorer.

 2.	Select **Tools** > **Internet Options** > **Privacy**.

 3.	In the **Turn on pop-up Blocker** section, select **Settings**.

 4.	In the **Address of website to allow** field, specify one URL and select **Add**. <br>
    Add the following URLs:<br>
    - https://login.microsoftonline.com
    - https://www.office.com
    - https://\<Instance name\>.powerbi.com
    - https://\<Org name\>.dynamics.com
    - https://oc-cdn-public.azureedge.net
    - https://oc-auth.azurewebsites.net

  5. Select **Close**, and then select **OK**.

### Set up Internet Explorer settings

To configure the **Enable Protected Mode** option, **TabProcGrowth** (Tab Process Growth), **TabShutdownDelay** (Tab Shutdown Delay) registry key, and **Enable Automatic Crash Recovery** option, see [Internet Explorer setting guidelines](/dynamics365/customer-engagement/unified-service-desk/admin/internet-explorer-settings-bpa).

## Disable the recommended settings using PowerShell script

You can disable the recommended settings that you set up using the **CleanUpIESettings** PowerShell script.

Download the **CleanUpIESettings** PowerShell script file from **Dynamics Insider Program** by joining the **Omni-channel Engagement Hub – Preview** program.

> [!Note]
> Go to [Experience Dynamics 365](https://experience.dynamics.com) and select **Insider Program**. Sign in with you account. Choose **Omni-channel Engagement Hub - Preview** and join.

### Run the CleanUpIESettings PowerShell script file

1. Download the **CleanUpIESettings** PowerShell script file from the **Dynamics Insider Portal**.

2. Go to the location where you have saved the PowerShell script file.

3. Right-click the **CleanUpIESettings** PowerShell script file and select **Run with PowerShell** to the run the script.

4. After the execution, press any key to exit the batch file execution.

The **CleanUpIESettings** PowerShell script file contains the following snippet:

```PowerShell
Write-Host "The powershell script deletes the registry settings that you added using the AddRecommendedIESettings.ps1 script."
Write-Host

Write-Host "-------------------"
Write-Host "TRUSTED URL SOURCES"
Write-Host "-------------------"

$registryPath = "HKCU:\Software\Microsoft\Internet Explorer\New Windows\Allow"
IF((Test-Path $registryPath))
  {
    $sampleOrgUrl = 'https://orgname.dynamics.com'
    $samplePowerBIUrl = 'https://instancename.powerbi.com'
    $orgUrlPromptMessage = 'Enter the Dynamics 365 for Customer Engagement organization URL (' + $sampleOrgUrl +') to exclude as a trusted source and allow Internet Explorer popups'
    $powerBIUrlPromptMessage = 'Enter the Power BI URL (' + $samplePowerBIUrl + ') to exclude as a trusted source for Internet Explorer popups.'

    $orgUrl = Read-Host -Prompt $orgUrlPromptMessage
    $orgUrl = $orgUrl.Trim()
    IF(![string]::IsNullOrEmpty($orgUrl) -And $orgUrl -ne $sampleOrgUrl)
    {
        IF ((Get-ItemProperty $registryPath).$orgUrl -ne $null)
        {
            Remove-ItemProperty -Path $registryPath -Name $orgUrl
            Write-Host "The Dynamics 365 for Customer Engagement organization URL $orgUrl is excluded from trusted sources."
        }
        ELSE
        {
            Write-Host "Registry key $orgUrl is not found in path $registryPath"
        }
    }
    ELSE
    {
        Write-Host "$orgUrl is not a valid Dynamics 365 for Customer Engagement organization URL."
    }
    Write-Host

    $powerBIUrl = Read-Host -Prompt $powerBIUrlPromptMessage
    $powerBIUrl = $powerBIUrl.Trim()
    IF(![string]::IsNullOrEmpty($powerBIUrl) -And $powerBIUrl -ne $samplePowerBIUrl)
    { 
        IF ((Get-ItemProperty $registryPath).$powerBIUrl -ne $null)
        {    
            Remove-ItemProperty -Path $registryPath -Name $powerBIUrl
            Write-Host "The Power BI URL $powerBIUrl is excluded from trusted sources."
        }
        ELSE
        {
            Write-Host "Registry key $powerBIUrl is not found in path $registryPath"
        }
    }
    ELSE
    {
        Write-Host "$powerBIUrl is not a valid Power BI instance URL."
    }
    
    Write-Host
    
    IF ((Get-ItemProperty $registryPath).'https://login.microsoftonline.com' -ne $null)
    { 
        Remove-ItemProperty -Path $registryPath -Name 'https://login.microsoftonline.com'
    }
    
    IF ((Get-ItemProperty $registryPath).'https://www.office.com' -ne $null)
    { 
        Remove-ItemProperty -Path $registryPath -Name 'https://www.office.com'
    }

    IF ((Get-ItemProperty $registryPath).'https://oc-cdn-public.azureedge.net' -ne $null)
    {
        Remove-ItemProperty -Path $registryPath -Name 'https://oc-cdn-public.azureedge.net'
    }

    IF ((Get-ItemProperty $registryPath).'https://oc-auth.azurewebsites.net' -ne $null)
    {
        Remove-ItemProperty -Path $registryPath -Name 'https://oc-auth.azurewebsites.net'
    }

    Write-Host "The URLs are removed from the registry settings."
 }
 ELSE
 {
    Write-Host "Unable to find registry path $registryPath. The URLs are not excluded from trusted sources for Popups."
 }

Write-Host

Write-Host "----------------------------"
Write-Host "ENABLE PROTECTED MODE OPTION"
Write-Host "----------------------------"

Write-Host "Disable the Enable Protected Mode option. This option is a Unified Service Desk recommended registry setting and disables security settings in all Internet Zones. (Optional)"
$inputProtectedMode= Read-Host -Prompt 'Press Y to remove these settings. Press any key to skip the step'
IF($inputProtectedMode -eq "Y")
{
    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\1').'2500' -ne $null)
    {
        Remove-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\1' -Name 2500
    }

    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\2').'2500' -ne $null)
    {
        Remove-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\2' -Name 2500
    }

    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3').'2500' -ne $null)
    {
        Remove-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\3' -Name 2500
    }

    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\4').'2500' -ne $null)
    {
        Remove-ItemProperty -Path 'HKCU:\Software\Microsoft\Windows\CurrentVersion\Internet Settings\Zones\4' -Name 2500
    }

    Write-Host "The Enable Protected Mode registry settings are disabled successfully."
}
Write-Host

Write-Host "--------------------------------------------"
Write-Host "BEST PRACTICES ANALYZER RECOMMENDED SETTINGS"
Write-Host "--------------------------------------------"

Write-Host "Remove Unified Service Desk - Best Practices Analyzer recommended settings for better performance of Internet Explorer process."
$inputIESettings= Read-Host -Prompt 'Press Y to remove these settings. Press any key to skip this step'
IF($inputIESettings -eq "Y")
{
    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Internet Explorer\Main').'TabProcGrowth' -ne $null)
    {
        Remove-ItemProperty -Path 'HKCU:\Software\Microsoft\Internet Explorer\Main' -Name TabProcGrowth
    }

    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Internet Explorer\Main').'TabShutdownDelay' -ne $null)
    {
        Remove-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Main" -Name TabShutdownDelay
    }

    IF ((Get-ItemProperty 'HKCU:\Software\Microsoft\Internet Explorer\Recovery').'AutoRecover' -ne $null)
    {
        Remove-ItemProperty -Path "HKCU:\Software\Microsoft\Internet Explorer\Recovery" -Name AutoRecover
    }

    Write-Host "The settings are removed successfully."
}
Write-Host
Read-Host -Prompt 'Press any key to exit...'
```
## See also

- [Configure agent and supervisor configurations in Unified Service Desk](../customizer/create-agent-supervisor-configurations-unified-service-desk.md)
- [Customize Customer summary form](../customizer/customize-customer-360-page.md)
- [Customize the conversation form](../customizer/customize-conversation-form.md)
- [Configure notification (Screen pop) for agents](../customizer/configure-notification-screen-pop-agents.md)
