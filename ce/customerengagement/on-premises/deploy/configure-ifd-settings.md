---
title: "Configure IFD settings | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 24a39c43-7eaf-4259-aef9-44a2106c330d
caps.latest.revision: 15
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure IFD settings



Using the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] `Get-CrmSetting` and `Set-CrmSetting` cmdlets you can update the settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. One of the types of settings you can change is for an Internet-facing deployment (IFD).  
  
## Requirements  
 To set up the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets, see [Get started using the Dynamics 365 Customer Engagement Management (on-premises) PowerShell cmdlets](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&branch=master#get-started-using-the-dynamics-365-customer-engagement-management-on-premises-powershell-cmdlets).  
  
## Demonstrates  
 You can use the following script to update settings for an Internet-facing deployment (IFD). You must specify the following parameters:  
  
 *DiscoveryWebServiceRootDomain* – The discovery Web service domain.  
  
 *Enabled* - A `Boolean` that indicates whether Internet-facing deployment (IFD) is enabled.  
  
 *ExternalDomain* - The external domain value for IFD.  
  
 *OrganizationWebServiceRootDomain* -The organization Web service domain.  
  
 *WebApplicationRootDomain* -The Web application server domain.  
  
## Example  
  
```powershell  
param  
(  
    #optional params  
    [string]$DiscoveryWebServiceRootDomain,  
    [boolean]$Enabled,  
    [string]$ExternalDomain,  
    [string]$OrganizationWebServiceRootDomain,      
    [string]$WebApplicationRootDomain  
)  
  
$RemoveSnapInWhenDone = $False  
  
if (-not (Get-PSSnapin -Name Microsoft.Crm.PowerShell -ErrorAction SilentlyContinue))  
{  
    Add-PSSnapin Microsoft.Crm.PowerShell  
    $RemoveSnapInWhenDone = $True  
}  
  
$IfdSettings = Get-CrmSetting -SettingType IfdSettings  
  
if($DiscoveryWebServiceRootDomain) {$IfdSettings.DiscoveryWebServiceRootDomain = $DiscoveryWebServiceRootDomain}  
if($ExternalDomain) {$IfdSettings.ExternalDomain = $ExternalDomain}  
if($PSBoundParameters.ContainsKey('Enabled')) {$IfdSettings.Enabled = $Enabled}  
if($OrganizationWebServiceRootDomain) {$IfdSettings.OrganizationWebServiceRootDomain = $OrganizationWebServiceRootDomain}  
if($WebApplicationRootDomain) {$IfdSettings.WebApplicationRootDomain = $WebApplicationRootDomain}  
  
Set-CrmSetting -Setting $IfdSettings  
  
$IfdSettings  
  
if($RemoveSnapInWhenDone)  
{  
    Remove-PSSnapin Microsoft.Crm.PowerShell  
}  
```  
  
## See Also  
[Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md)  </br> 
[Get and set deployment configuration settings](update-deployment-configuration-settings.md) </br>
[Additional steps for clients unable to connect to the Dynamics 365 Server via IFD](post-installation-configuration-guidelines-dynamics-365.md#additional-steps-for-clients-unable-to-connect-to-the-dynamics-365-server-via-ifd)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]