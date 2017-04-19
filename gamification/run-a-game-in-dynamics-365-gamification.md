---
title: "Run a game in Dynamics 365 - Gamification | MicrosoftDocs"
ms.custom: ""
ms.date: "04/18/2017"
ms.reviewer: ""
ms.service: "gamification"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ec71f8e3-5cc9-4941-8067-5bf8e1081da9
caps.latest.revision: 35
author: "m-hartmann"
ms.author: "mhart"
manager: "sakudes"
---
# Run a game in Dynamics 365 - Gamification
Commissioners and game managers  create and run games to gamify KPIs for [!INCLUDE[pn_CRM_Online](includes/pn-crm-online-md.md)], and motivate employees to deliver their best results. Create games whenever you want, and schedule them to start at any time in the future.  
  
 Before you start setting up a game in [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)], make sure the following prerequisites are met:  
  
-   You are assigned the Commissioner or game manager security role in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)].  
  
- [!INCLUDE[pn_gamification_solution](includes/pn-gamification-solution-md.md)] is installed and correctly configured in your school or organization's [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] instance. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Manage Gamification in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md)  
  
## Set up a game  
 By setting up a game,  a Commissioner or game manager creates a basis for the upcoming contest. Take a moment to read the sections below for step-by-step instructions.  
  
<a name="step1"></a>   
### Basic game options  
 The first step of the game setup process is providing basic information for the game you're creating. In [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)], go to **Games** > **Game Setup** to set up a new game or to **Games** > **Games** to edit existing games.  
  
##### Create a new game  
  
1.  Provide a **Name** for the game.  
  
2.  Select the **Game Model**. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Before you get started](before-you-get-started.md)  
  
     For more information about setting up a Stream TV, see [Configure and view TVs](configure-and-view-tvs.md).  
  
3.  Select the **Sport Theme** you want to use for the game.  
  
4.  Choose if you want to use **Actuals** or **Targets** for the KPIs in this game. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Before you get started](before-you-get-started.md)  
  
5.  To specify how often players can change their teams, set the **Draft Frequency** . Ideally, you'll set a weekly draft frequency to provide players the flexibility to replace players on their team roster if they're removed from the game or take some time off.  
  
6.  Set the **Start Date** and **End Date** for the game. Games run on a weekly schedule, from Monday to Sunday. Set your start and end dates accordingly to avoid game periods of less than a week.  
  
    > [!TIP]
    >  For an engaging experience for players, a game duration between 2 and 6 months is recommended. Shorter games make it harder for people to immerse in the game, while longer games have proven to be harder to keep track of.  
  
7.  In the game setup header, click **1** to proceed to the next step.  
  
<a name="step2"></a>   
### KPI types and user roles  
 KPIs are key to the game. They are metrics based on [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] data that automatically syncs to [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)], and are the basis for points awarded to players. KPIs need to be set for weekly goals.  
  
> [!TIP]
> - **Use descriptive names** for KPIs so players can understand how to earn points.  
> - **The ideal number of KPIs per game is between 3 and 5.** Too many KPIs will result in players focusing on a few metrics while others are forgotten.  But you also want to have enough KPIs so that players of all levels will feel they can contribute and succeed.  A good practice is  including both results-driven and behavioral KPIs.  Results-driven KPIs, for example, are revenue amount, % of quota, and closed sales. Behavioral metrics  include things like number of calls made, number of appointments set, and number of demos held.  However, you can define as many KPIs as you like for your game.  
> - **Use lower numbers for KPIs.** For example, award 1 point for every new lead rather than 100 points for every 5 leads so the spread between first and second place isn't too big. Players might feel they have already lost if there is a vast number of points to reach the next position.  
> - **Include floors and caps for KPIs** to avoid an achievement of a single rep overtaking the entire player field.  Floors define the minimum number a KPI needs to meet for a player to get points. Caps define the upper limit for the KPI to generate points for players. For example, if you set a floor of 5 and a cap of 50 for a KPI that tracks phone calls, players need to achieve at least 5 phone calls to get a point.  Due to the cap, they will get the same points as for 50 calls if they achieve 80 calls.   Floors and caps reset each week of the game.  
  
> For more information about KPIs, see [Before you get started](before-you-get-started.md).  
  
##### Select  a KPI  
  
1.  In step 2 of the game setup process, choose from the available KPIs in the drop-down menu. KPIs are created in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] by a user with the KPI Manager security role. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Configure KPIs in Dynamics 365 (online)](configure-kpis-in-dynamics-365-online.md)  
  
2.  Optionally, provide a different (game-specific) name for the KPI.  
  
3.  Select the method to measure the KPI from the drop-down list. You can choose between **Number of**, **Revenue or Amount**, **Percentage**, and **Percentage of Quota**.  
  
     If you select **Percentage of Quota** in one of your KPIs, a new step is added to the game setup process where you will be asked to define the quotas for each player.   Experience has shown that using **Default** rather than **Linear** is easier to keep track of for players.  
  
 [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Game quotas](#step5)  
  
4.  Define how many points players will get when they reach a KPI.  
  
     To set a weekly target that the player can achieve, create a hit or miss KPI, and then change the word **every** to **at** in step 2 of the game setup process.  
  
5.  Optionally, set the **Floor** and **Cap** values for the KPI.  
  
6.  Repeat the steps above for all KPIs you have planned for the game.  
  
7.  Optionally, you can use Excel Point Scoring for certain KPIs. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Update scores using Excel point scoring](update-scores-using-excel-point-scoring.md)  
  
8.  In the game setup header, click **2** to proceed to the next step.  
  
> [!IMPORTANT]
>  When you remove a KPI from an active game, a user with a KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] needs to click **Refresh Data** in **Dynamics 365 (online)** > **Gamification** > **Gamification Settings** to update the data shown in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)].  
  
<a name="step5"></a>   
#### Game quotas  
 If you created a Percentage of Quota KPI in step 2 of the game setup process, you need to define the game quotas for the players. Optionally, you can set the quota for all players on all or individual KPIs to the same value.  
  
> [!NOTE]
>  You can have up to four KPIs per game that use a quota.  
  
<a name="step3"></a>   
### Players and fans  
 Depending on the selected sports theme, you can now assign the players to positions, and in a next step, select fans to participate in the game.  
  
 To assign a player to a position, click the position and select the check box for the users you want to assign to the position.  
  
> [!TIP]
>  Make sure to distribute players evenly on positions to prevent someone from drafting all top performers onto their team.  
  
 To add fans to a game, select them from the list in step 3.  
  
 Click **4** to proceed to the next step.  
  
<a name="step4"></a>   
### Awards and prizes  
 In this step, you can define the various awards and prizes for the overall game. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Before you get started](before-you-get-started.md)  
  
 In addition to game awards, you can  set up weekly awards. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Define weekly awards for Gamification players and fans](define-weekly-awards-for-gamification-players-and-fans.md)  
  
 To complete the game setup, click **Start Game** for the dates you defined. You can also save the game and refine your settings before you start it.  
  
 After you activate the game,  and prior to the game start date, you can  change only KPIs, game awards, and player game quotas, but you can't add new Percentage of Quota KPIs.  On or after the game start date, you can still change the game awards and player game quotas.  
  
> [!NOTE]
>  Add or remove players or fans at any time after you activate a game by using the **Add or remove players or fans** button on the **Games** page, which you'll see after the game is activated. If a player is no longer with the organization, deactivate them from the **Players** page. If you're running a game that uses fantasy teams, you need to first deactivate a player in [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)] to freeze the points for that player so teams don't lose points for the current and past game periods.  
  
 Don't forget to complete the game when you reach the game end date. It's a critical step to be sure prizes get awarded to the players. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Complete a game](#completeGame)  
  
<a name="BKMK_runGame"></a>   
## Run the game and keep scores up to date  
 During an active game, make sure the players and fans stay engaged. If you update certain KPIs manually, you'll use the Excel Point Scoring feature. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Update scores using Excel point scoring](update-scores-using-excel-point-scoring.md)  
  
> [!IMPORTANT]
>  When you edit an active game and remove a KPI or change the active players, a user with a KPI Manager security role in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)] needs to click Refresh Data to update the data shown in [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)].  
  
> [!TIP]
> - Consider setting up a TV for your office to show the leaderboard and announcements on the Smack Talk board. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Configure and view TVs](configure-and-view-tvs.md)  
> - Send weekly email blasts to all participants to share who's leading the pack in the current game and motivate them to deliver their best results. [!INCLUDE[proc_more_information](includes/proc-more-information-md.md)] [Schedule weekly or one-time emails](schedule-weekly-or-one-time-emails.md)  
  
<a name="completeGame"></a>   
## Complete a game  
 After the game end date, a game manager or Commissioner must complete point scoring for the last game period. If you integrated [!INCLUDE[pn_gamification](includes/pn-gamification-md.md)] with [!INCLUDE[pn_crm_online_subsequent](includes/pn-crm-online-subsequent-md.md)], they also need to make sure all the data is correct so KPIs reflect the correct values and players are assigned the correct final scores and prizes. Complete a game manually or let the game complete automatically, 30 days after the game end date.  
  
#### Manually complete a game  
  
1.  In [!INCLUDE[pn_gamification_subsequent](includes/pn-gamification-subsequent-md.md)], go to **Games**.  
  
2.  In the **Active Games** list, click the **End Game** button for the game you want to complete.  
  
## See Also  
 [For Commissioners and game managers in Gamification](for-commissioners-and-game-managers-in-gamification.md)   
 [Manage Gamification in Dynamics 365 (online)](manage-gamification-in-dynamics-365-online.md)   
 [Manage players and fans in Gamification](manage-players-and-fans-in-gamification.md)