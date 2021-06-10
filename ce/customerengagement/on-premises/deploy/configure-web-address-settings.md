---
title: "Configure web address settings | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 352c7bff-91c2-4b9e-a167-d746ffbeeda6
caps.latest.revision: 17
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure web address settings



Using the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] `Get-CrmSetting` and `Set-CrmSetting` cmdlets you can update the settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. One of the types of settings you can change is the web address settings.  
  
## Requirements  
 To set up the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets, see [Get started using the Dynamics 365 Customer Engagement Management (on-premises) PowerShell cmdlets](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&branch=master#get-started-using-the-dynamics-365-customer-engagement-management-on-premises-powershell-cmdlets).  
  
## Demonstrates  
 You can use the following script to update web address settings: partner-hosted (IFD). You must specify the following parameters:  
  
 *RootDomainScheme*: The root domain scheme: http or https.  
  
 *DeploymentSdkRootDomain*: The root domain for the deployment web service (SDK).  
  
 *DiscoveryRootDomain*: The root domain for the discovery web service.  
  
 *NlbEnabled*: A `Boolean` that specifies whether network load balancing (NLB) is enabled.  
  
 *SdkRootDomain*: The root domain for the organization web service (SDK).  
  
 *SslHeader*: The secured sockets layer (SSL) header.  
  
 *WebAppRootDomain*: The root domain for the Web application.  
  
## Example  
  
```powershell  
param  
(  
    #optional params  
    [string]$RootDomainScheme,  
    [string]$DeploymentSdkRootDomain,  
    [string]$DiscoveryRootDomain,  
    [boolean]$NlbEnabled,  
    [string]$SdkRootDomain,  
    [string]$SslHeader,  
    [string]$WebAppRootDomain  
)  
  
$RemoveSnapInWhenDone = $False  
  
if (-not (Get-PSSnapin -Name Microsoft.Crm.PowerShell -ErrorAction SilentlyContinue))  
{  
    Add-PSSnapin Microsoft.Crm.PowerShell  
    $RemoveSnapInWhenDone = $True  
}  
  
$WebAddressSettings = Get-CrmSetting -SettingType WebAddressSettings  
  
if($DeploymentSdkRootDomain) {$WebAddressSettings.DeploymentSdkRootDomain = $DeploymentSdkRootDomain}  
if($DiscoveryRootDomain) {$WebAddressSettings.DiscoveryRootDomain = $DiscoveryRootDomain}  
if($PSBoundParameters.ContainsKey('NlbEnabled')) {$WebAddressSettings.NlbEnabled = $NlbEnabled}  
if($RootDomainScheme) {$WebAddressSettings.RootDomainScheme = $RootDomainScheme}  
if($SdkRootDomain) {$WebAddressSettings.SdkRootDomain = $SdkRootDomain}  
if($PSBoundParameters.ContainsKey('SslHeader')) {$WebAddressSettings.SslHeader = $SslHeader}  
if($WebAppRootDomain) {$WebAddressSettings.WebAppRootDomain = $WebAppRootDomain}  
  
Set-CrmSetting -Setting $WebAddressSettings  
  
$WebAddressSettings  
  
if($RemoveSnapInWhenDone)  
{  
    Remove-PSSnapin Microsoft.Crm.PowerShell  
}  
```  
  
## See Also  
 [Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md)  </br> 
 [Get and set deployment configuration settings](update-deployment-configuration-settings.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]