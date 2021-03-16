---
title: "Emails and appointments are tracked with a Regarding record in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 07/17/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Ensure emails and appointments are tracked with a Regarding record in Dynamics 365 App for Outlook


Dynamics 365 App for Outlook allows people to track emails and appointments from Outlook to Dynamics 365 apps. There are two options to track: 

-	Track the email/appointment to Dynamics 365 apps without **Regarding**.
-	Track the email/appointment to Dynamics 365 apps with **Regarding**, so the communication is associated to a specific record.


With the OrgDBOrgSetting [OverrideTrackInCrmBehaviour](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm), ensure that everyone in your organization who has App for Outlook always tracks the email/appointment with a Regarding record.
Enabling this setting will hide the option to track an email/appointment without a **Regarding** record in App for Outlook. Previously tracked items without **Regarding** will be unaffected. However, if such an item is untracked, then it cannot be tracked again without a **Regarding** record as long as the OrgDBOrgSetting [OverrideTrackInCrmBehaviour](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) is enabled.
  
 > [!NOTE]
 > - This OrgDBOrgSetting does not apply to tracking contacts through Dynamics 365 App for Outlook.
 > - This is an existing OrgDBOrgSetting which only applied to Dynamics 365 for Outlook and it will not apply to App for Outlook as well.



[!INCLUDE[footer-include](../includes/footer-banner.md)]