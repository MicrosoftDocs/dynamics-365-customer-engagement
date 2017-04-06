---
title: "Understand Gamification security roles | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-04-06"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: afad369f-fe8a-4ced-8808-0af86ffad2c1
caps.latest.revision: 15
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Understand Gamification security roles
Administrators assign licenses to users to grant them permissions for certain applications. To enable [!INCLUDE[pn_azure_active_directory](includes/pn-azure-active-directory-md.md)] users for [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)], they need to have a [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] license assigned. The first user to have a KPI Manager security role assigned by a system admin in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] is required to set up the connection between [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] and [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)]. The same user automatically becomes the first Commissioner in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)].  
  
## Available security roles  
 The permissions in games are exclusively granted by the security roles in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]. For a description of the available security roles, review the [Gamification Glossary](http://msdn.microsoft.com/en-us/10c6a538-985a-4ea2-b8d9-4efc67f7363f).  
  
 To learn more about the permissions of the available security roles, refer to the following table.  
  
|Permission|Commissioner|Game Manager|User|  
|----------------|------------------|------------------|----------|  
|[Manage Gamification in Microsoft Dynamics 365](http://msdn.microsoft.com/en-us/cff88aa0-01a3-4cd7-adcf-8d4b8dec9f20)|No*|No*|No*|  
|[Manage players and fans](http://msdn.microsoft.com/en-us/4df5e61b-0d7b-4cef-b741-14bed0637756)|Yes|No|No|  
|[Set up a game](http://msdn.microsoft.com/en-us/ec71f8e3-5cc9-4941-8067-5bf8e1081da9)|Yes|Yes|No|  
|[Configure and view Gamification Stream TV](http://msdn.microsoft.com/en-us/31346f85-42c9-4675-a8dd-062da7b94d4f)|Yes|Yes|No|  
|[Update scores using Excel Point Scoring](http://msdn.microsoft.com/en-us/1c58f29f-95df-4b2d-b0c4-56cea45bf196)|Yes|Yes|No|  
|[Schedule weekly or one-time emails](http://msdn.microsoft.com/en-us/1e93e7a0-a0f6-4817-a361-a173df8fc74b)|Yes|Yes|No|  
|[Define weekly awards](http://msdn.microsoft.com/en-us/f34678ce-1037-4788-8394-f83866583c3c)|Yes|Yes|No|  
|[Manage a Fantasy Sports team](http://msdn.microsoft.com/en-us/ce3d8906-0c19-4aac-aba6-e9385a21f18d)|No|Yes**|Yes|  
|[Post on Smack Talk](http://msdn.microsoft.com/en-us/958c8d0d-d57e-492b-bb83-1594c4d1a984)|Yes|Yes|Yes|  
|[View the leaderboard](http://msdn.microsoft.com/en-us/088b9a63-9cda-4e45-80b6-5482ac81147b)|Yes|Yes|Yes|  
  
 No* = Managing the [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] is regulated by [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] permissions and requires a KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)].  If you are looking for information about the KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)], see [Configure KPIs in Dynamics 365](http://msdn.microsoft.com/en-us/b0c9af15-5cdf-4f8b-838c-49bf5dd50b6b) and [Manage Gamification in Microsoft Dynamics 365](http://msdn.microsoft.com/en-us/cff88aa0-01a3-4cd7-adcf-8d4b8dec9f20).  
  
 Yes** = Game Managers can participate as a fan or a player in a game they don't administer.  
  
## See Also  
 [For admins](http://msdn.microsoft.com/en-us/9cbe15a2-8239-4601-8af2-50a92c28f81f)   
 [For players and fans](http://msdn.microsoft.com/en-us/4aa06e76-6c87-424e-9068-58e706ddd7f9)   
 [Manage players and fans](http://msdn.microsoft.com/en-us/4df5e61b-0d7b-4cef-b741-14bed0637756)