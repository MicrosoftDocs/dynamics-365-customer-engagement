---
title: "Configure claims settings | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 85f74dae-06a4-48a3-96e1-3e0a8a78934e
caps.latest.revision: 13
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure claims settings



Using the [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] `Get-CrmSetting` and `Set-CrmSetting` cmdlets you can update the settings in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deployment. One of the types of settings you can change is the claims setting.  
  
## Requirements  
 To set up the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] cmdlets, see [Get started using the Dynamics 365 Customer Engagement Management (on-premises) PowerShell cmdlets](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&branch=master#get-started-using-the-dynamics-365-customer-engagement-management-on-premises-powershell-cmdlets).  
  
## Demonstrates  
 You can use the following script to enable or disable claims authentication. You must specify the following parameters:  
  
 *Enabled* - A `Boolean` that specifies whether claims authentication is enabled or disabled.  
  
 *EncryptionCertificate* – An encryption certificate.  
  
 *FederationMetadataUrl* – A URL for federation metadata.  
  
## Example  
  
```powershell  
param  
(  
    #optional params  
    [boolean]$Enabled,  
    [string]$EncryptionCertificate,  
    [string]$FederationMetadataUrl  
)  
  
$RemoveSnapInWhenDone = $False  
  
if (-not (Get-PSSnapin -Name Microsoft.Crm.PowerShell -ErrorAction SilentlyContinue))  
{  
    Add-PSSnapin Microsoft.Crm.PowerShell  
    $RemoveSnapInWhenDone = $True  
}  
  
$ClaimsSettings = Get-CrmSetting -SettingType ClaimsSettings  
  
if($PSBoundParameters.ContainsKey('Enabled')) {$ClaimsSettings.Enabled = $Enabled}  
if($EncryptionCertificate) {$ClaimsSettings.EncryptionCertificate = $EncryptionCertificate}  
if($FederationMetadataUrl) {$ClaimsSettings.FederationMetadataUrl = $FederationMetadataUrl}  
  
Set-CrmSetting -Setting $ClaimsSettings  
  
$ClaimsSettings  
  
if($RemoveSnapInWhenDone)  
{  
    Remove-PSSnapin Microsoft.Crm.PowerShell  
}  
```  
  
## See Also  
 [Administer the deployment using Windows PowerShell](administer-the-deployment-using-windows-powershell.md)   </br>
 [Get and set deployment configuration settings](update-deployment-configuration-settings.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]