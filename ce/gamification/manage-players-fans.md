---
title: "Import and manage players and fans in Dynamics 365 – Gamification | Microsoft Docs"
description: "Learn how to import players from your Azure Active Directory and how to assign them the appropriate security roles for the games."
ms.custom: ""
ms.date: 05/31/2017
ms.reviewer: ""
ms.service: gamification
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
applies_to: Dynamics 365 (online)
ms.assetid: 4df5e61b-0d7b-4cef-b741-14bed0637756
caps.latest.revision: 34
author: "m-hartmann"
ms.author: mhart
manager: sakudes
---
# Import players and fans from Dynamics 365 (online) and manage their security roles

When you set up a new game, you need to define which users will be players and which will be fans in your upcoming [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] game.

**Players** are competing participants in your game who get points for achieving defined KPIs.

**Fans** are people who aren’t players in an active game—for example, executives, managers, or receptionists—who participate in a [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)] game by drafting a team. If your CEO gets involved in the game, drafts a team, and is personally following player stats, that’s quite an incentive for players to do their best!

## Import users from Azure Active Directory

Users from [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] are available automatically in [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)]. Commissioners can import additional users from [!INCLUDE[pn_azure_active_directory](includes/pn-azure-active-directory-md.md)] who don't have a [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] license assigned.  

### Import users from [!INCLUDE[pn_microsoftcrm](includes/pn-microsoftcrm-md.md)]

1.  In [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)], go to **Users**.

2.  On the **Import Users from Dynamics 365** page, select the **Security role** for each user.

     It's likely that the vast majority of imported users will be assigned the **User** role, and only a handful will have the **Game manager** role. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Understand Gamification security roles](understand-security-roles.md).

3.  Select the users you want to import to [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)].

4.  To start the import process, select **Import Selected Users**.
    It can take up to a couple of minutes, depending on the number of users who are being imported.

Imported users now appear in [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)] when you navigate to the **Users** page, where you can edit their roles according to your planned game setup.

## Change a user's security role in Dynamics 365 - Gamification

> [!VIDEO https://www.youtube.com/embed/ifmGw3md6_E]

After users are imported, a commissioner can change the security role of the users.

1. In [!INCLUDE[pn_gamification_shortest](includes/pn-gamification-shortest-md.md)], go to **Users**.

2. On the **Import Users from Dynamics 365** page, search for the user whose role you want to change.

3. Select **Change Role** for the selected user, and then choose the new security role.  
   [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Understand Gamification security roles](understand-security-roles.md)

4. Select **Update Role** to apply your changes.

### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Set up and run games in Gamification](run-games.md)
