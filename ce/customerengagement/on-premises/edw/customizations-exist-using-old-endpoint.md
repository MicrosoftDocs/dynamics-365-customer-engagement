---
title: "Customizations exist that are using the Microsoft Dynamics 4.0 (2007) endpoint | Microsoft Docs"
ms.custom: 
ms.date: 10/01/2018
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
ms.assetid: 36e9d26a-2dd7-4815-9510-748812eefa6f
caps.latest.revision: 15
robots: noindex,nofollow
author: Mattp123
ms.author: matp
---
# Customizations exist that are using the Microsoft Dynamics 4.0 (2007) endpoint

## Cause
  
 Some plug-ins or custom workflows are using the [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)] SDK, which is not supported for this version.  
 
## Solution
  
 Upgrade your custom code. For more information, see [Upgrade Your Code from Microsoft Dynamics CRM 4.0](/previous-versions/dynamics-crm2011/developers-guide/gg334220(v=crm.5)) and [Upgrade your code from Microsoft Dynamics CRM 2011](/previous-versions/dynamicscrm-2013/developers-guide/gg334220(v=crm.6)).  
  
## Cause
  
 [!INCLUDE[pn_Setup](../includes/pn-setup.md)] has detected that there are customizations or solutions that are using the [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)] (2007) endpoint. This feature will no longer be supported in later versions of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 ## Solution
  
 Review the Setup log for detailed information about the customization. By default, Setup logs are saved in *SystemDrive*:\Users\\*User*\AppData\Roaming\Microsoft\MSCRM\Logs\  
  
> [!TIP]
>  Copy the path below and paste into the Start or[!INCLUDE [pn-windows-explorer](../includes/pn-windows-explorer.md)] box to view the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Setup log folder on your computer.  
  
```  
%Userprofile%\AppData\Roaming\Microsoft\MSCRM\Logs  
```  
  
 Review the **LegacyFeatureCheck.xml** file.  
  
 Remove the customization or update the customization to use a supported endpoint, such as the REST endpoint. For more information about updating the [!INCLUDE[pn_Microsoft_Dynamics_CRM_4.0](../includes/pn-microsoft-dynamics-crm-4-0.md)] (2007) endpoint, see the [topic in the Microsoft Dynamics 365 Customer Engagement (on-premises) SDK](/previous-versions/dynamicscrm-2016/developers-guide/dn281891(v=crm.8)).



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]