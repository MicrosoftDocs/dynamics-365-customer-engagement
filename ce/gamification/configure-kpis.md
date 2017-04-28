---
title: "Configure KPIs in Dynamics 365 (online) | MicrosoftDocs"
ms.custom: ""
ms.date: "04/18/2017"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b0c9af15-5cdf-4f8b-838c-49bf5dd50b6b
caps.latest.revision: 29
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Configure KPIs in Dynamics 365 (online)

Scores and achievements in your games are based on KPIs that you define in [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)]. It's a two-step process. First, you need to create the KPIs in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], and then you can choose and configure them in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] when you set up a new game.  
  
 For more information about setting up KPIs in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)], see [Run a game in Dynamics 365 - Gamification](run-games.md). For basic information about KPIs, see [Before you get started](get-started.md).  
  

## Create KPIs in Gamification  

 When you set up a game, step 2 of the game setup experience requires you to define the KPIs for the game.  
  
 The KPIs you define in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] will be available when you set up the game and the data syncs from [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)]. For basic information about KPIs, see [Before you get started](get-started.md).  
  

## Configure and edit KPIs in Dynamics 365  

 Configure KPI details  in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] to select them for a new contest in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]. The system creates a set of default KPIs when you install [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)]. Only the owner of a KPI can change its values. If the system created a KPI, you need to assign it to an owner before its values can be changed.  
  
 There are various way to create useful KPIs based on the data of a [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)] instance. Consider some of our examples for inspiration and adapt them to your business and game requirements. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Best practices in working with KPIs](best-practices-kpis.md)  
  
### Configure a KPI  
  
1.  In [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)], go to **[!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]** > **KPIs**.  
  
2.  In the drop-down list, select **NEW**.  
  
3.  In the **Setup KPIs** section, click the KPI you want to configure.  
  
     KPIs you've configured will have a status of **Setup**, while KPIs pending configuration will show as **Not Setup**.  
  
4.  In the **Setup KPI Parameters** section, for **Type**, select the object type you want to base your KPI on.  
  
5.  Define which data field the points will be assigned on.  
  
    > [!TIP]
    >  Be mindful when you choose data fields. If you're using a data field that might change several times a day, like **Modified On** or **Modified By**, assigned points can be removed from one player and assigned to another, or the date of their point assignment may change.  
    >   
    >  For example, let's say you create a KPI  based on  the lead entity, that uses **Modified On** as the date field and **Modified By** as the field that specifies which user to assign points. If a user creates a new lead  on Monday, the system will assign points to this user on Monday. When this lead gets updated on Tuesday, the system will remove the user's points from Monday and move them to Tuesday, which could  change how many points a player earns within the specified game period.  
    >   
    >  If you have a system job that updates lead records on  a daily basis by using a system account, any points players earned will be removed after the job runs because the system modified the lead. The same logic applies if another user updates this lead record.  
    >   
    >  To avoid this, use the **Scoring Behavior** in the **Additional Scoring Settings** section.  
  
6.  Select which users are assigned points from a given KPI.  
  
     You can select multiple users when holding down the Ctrl key.  
  
7.  Optionally, you can set up an additional query parameter for a KPI by creating a **Saved View**.  
  
     Go to **Advanced Find**, select the fields you want to filter on, and then click **Save as new View**. Next, you can edit the KPI, select the saved view, and then click **Save** to apply your changes.  
  
     For example, if you want to only award points for appointments about a specific product, you can add the product name to the appointment description and add a query parameter to only select an appointment for scoring when the **Description** field contains the product name.  
  
    > [!NOTE]
    > [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] doesn't support saved views with linked entities in filters or columns.  
  
8.  Optionally, choose the **Scoring Behavior** in the **Additional Scoring Settings** section. By default (if no checkbox is selected), points are always assigned based on the current state of the record. You can customize this by selecting one or more of the following options:  
  
    - **Keep scores when the record is deleted**: When a record that is used by a KPI is deleted, scored points aren't removed from the player score.  
  
    - **Keep scores when the record is no longer valid**: For example, a KPI is configured based on a  saved view that assigned scores only to records in the **Completed** state. After some time, a workflow automatically moves completed records to an **Archived** state. If the checkbox is selected, the system will keep scores for these records.  
  
    - **Keep scores when the record is reassigned**: When a record is assigned to another user in [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], scores will persist with the user who initially received the scored points.  
  
    - **Keep initial scores**: Scores are assigned based on the values that were initially provided on the record that the KPI uses. For example, if you award points for potential revenue and the revenue forecast, the score won't change when the revenue forecast on the record is updated.  
  
    > [!CAUTION]
    >  If you edit a KPI with a custom scoring behavior that is already used in an active game, all points associated with the selected behavior options will be removed.  
  
9. To apply your configuration, click **Save**.  
  
 When you are done setting up all required KPIs, [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] will sync the data to [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] when you start the game.  
  
 If you want to score a KPI manually, you can use Excel Point Scoring. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Update scores using Excel point scoring](update-scores-using-excel-point-scoring.md)  
  
### Edit a KPI  
  
1.  In [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)], go to **[!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)]** > **KPIs**.  
  
2.  Click the KPI you want to edit.  
  
3.  In the **KPI Parameters** section, click **Edit**.  
  
4.  Change the parameters of the KPI to meet your requirements.  
  
5.  To apply your changes, click **Save**.  
  
> [!NOTE]
>  Before you can edit a KPI that was automatically created when installing [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)], you must assign it an owner. Only the KPI owner can edit the values of a KPI.  
  
## See Also  

 [For Commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Run a game in Dynamics 365 - Gamification](run-games.md)