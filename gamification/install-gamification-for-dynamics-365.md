---
title: "Install Gamification for Dynamics 365 | MicrosoftDocs"
ms.custom: ""
ms.date: "2016-11-01"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b8a484c3-b66b-4784-a26b-736e16490a21
caps.latest.revision: 10
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
robots: noindex,nofollow
---
# Install Gamification for Dynamics 365
The [!INCLUDE[pn_gamification_solution](../gamification/includes/pn-gamification-solution-md.md)] capabilities in [!INCLUDE[pn_crm_8_1_0_online](../gamification/includes/pn-crm-8-1-0-online-md.md)] are an end-to-end solution that you need to install before you can start using the capabilities to manage your [!INCLUDE[pn_gamification](../gamification/includes/pn-gamification-md.md)] games, metrics and players.  
  
 [!INCLUDE[proc_on_this_page](../gamification/includes/proc-on-this-page-md.md)]  
  
 ![Down arrow button](../gamification/media/down-arrow.png "Down arrow button") [Prerequisites](#BKMK_prerequisistes)  
  
 ![Down arrow button](../gamification/media/down-arrow.png "Down arrow button") [Install Gamification for Dynamics 365](#BKMK_install)  
  
 ![Down arrow button](../gamification/media/down-arrow.png "Down arrow button") [Authorize Gamification with Dynamics CRM](http://msdn.microsoft.com/en-us/b8a484c3-b66b-4784-a26b-736e16490a21)  
  
 ![Down arrow button](../gamification/media/down-arrow.png "Down arrow button") [KPI Manager security role](#BKMK_users)  
  
<a name="BKMK_prerequisistes"></a>   
## Prerequisites  
  
- [!INCLUDE[cc_capabilities_require_online_8_1_0](../gamification/includes/cc-capabilities-require-online-8-1-0-md.md)]  
  
-   Users must have a CRM license assigned to access the [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)] service.  
  
<a name="BKMK_install"></a>   
## Install Gamification for Dynamics 365  
 [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)] capabilities in [!INCLUDE[pn_crm_shortest](../gamification/includes/pn-crm-shortest-md.md)] is an App for CRM that you install from [!INCLUDE[pn_microsoft_appsource](../gamification/includes/pn-microsoft-appsource-md.md)]. In [!INCLUDE[pn_microsoft_appsource](../gamification/includes/pn-microsoft-appsource-md.md)], select [!INCLUDE[pn_gamification_solution](../gamification/includes/pn-gamification-solution-md.md)] to install the app.  
  
<a name="BKMK_authorize"></a>   
## Authorize Gamification with Dynamics CRM  
 Before you can sync [!INCLUDE[pn_gamification](../gamification/includes/pn-gamification-md.md)] with CRM, a user with a KPI Manager or a sytem admin needs to complete the set-up process to obtain the Service Account Identifier and the  Security Token.  
  
 In [!INCLUDE[pn_microsoftcrm](../gamification/includes/pn-microsoftcrm-md.md)], go to **Settings** > **Solutions** and then double-click the **[!INCLUDE[pn_gamification_solution](../gamification/includes/pn-gamification-solution-md.md)]** solution to obtain the Service Account Identifier and the Security Token.  
  
<a name="BKMK_users"></a>   
## KPI Manager security role  
 When you install the [!INCLUDE[pn_gamification_solution](../gamification/includes/pn-gamification-solution-md.md)], a CRM-specific security role called **KPI Manager** is created. System admins can assign this security role to CRM users they want to enable to create KPIs for [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)] in CRM and configure the connection between CRM and [!INCLUDE[pn_gamification_subsequent](../gamification/includes/pn-gamification-subsequent-md.md)].  
  
 To learn more about security roles and privileges, see [TechNet: Security roles and privileges](https://technet.microsoft.com/library/dn531090.aspx)  
  
## See Also  
 [Increase productivity using the Gamification platform](http://msdn.microsoft.com/en-us/6a70c280-4e08-4382-bb53-af82d0bfa9fb)   
 [Manage Gamification in Microsoft Dynamics CRM](http://msdn.microsoft.com/en-us/cff88aa0-01a3-4cd7-adcf-8d4b8dec9f20)   
 [For admins](http://msdn.microsoft.com/en-us/9cbe15a2-8239-4601-8af2-50a92c28f81f)