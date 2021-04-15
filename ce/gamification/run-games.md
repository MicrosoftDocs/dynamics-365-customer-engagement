---
title: "Run games in Dynamics 365 – Gamification | Microsoft Docs"
description: "Learn how to set up games in a few steps and how to keep them running smoothly."
keywords: game, gamification KPI, game setup
ms.date: 03/05/2019
ms.service: dynamics-365-sales
ms.topic: get-started-article
ms.assetid: ec71f8e3-5cc9-4941-8067-5bf8e1081da9
author: m-hartmann
ms.author: mhart
ms.custom: 
  - dyn365-gamification
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Gamification
---

# Set up and run games in Gamification

[!INCLUDE[cc-gamification-deprecation-notice](../includes/cc-gamification-deprecation-notice.md)]

Commissioners and game managers create and run games in [!INCLUDE[pn_gamification](../includes/pn-gamification.md)] to gamify KPIs for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] and motivate employees to deliver their best results. Create games whenever you want, and schedule them to start at any time.

Before you start setting up a game in [!INCLUDE[cc_gamification_portal](../includes/cc-gamification-portal.md)], make sure the following prerequisites are met:

- You are assigned the **Commissioner** or **Game manager** [security role](understand-security-roles.md).  

- [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] is installed and correctly configured in your school or organization. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Install and configure the Gamification solution in Dynamics 365 apps](manage-gamification-in-dynamics-365-online.md)  

## Set up a game

By setting up a game in [!INCLUDE[cc_gamification_portal](../includes/cc-gamification-portal.md)], a commissioner or game manager creates a basis for the upcoming contest.

### Basic game options

 The first step of the game setup process is to provide basic information for the game you're creating. In [!INCLUDE[cc_gamification_portal](../includes/cc-gamification-portal.md)], go to **Games** > **Game Setup** to set up a new game, or to **Games** > **Games** to edit existing games.

#### Create a new game

1. Select the business unit you want to create a game for. The business unit represents a Dynamics 365 organization. [!include[](../includes/proc-more-information.md)] [Install and configure the Gamification solution](manage-gamification-in-dynamics-365-online.md)

2. Provide a **Name** for the game.

3. Select the **Game Model**.  
   [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Concepts to learn before you get started using Gamification](get-started.md)  
   More information about setting up a Stream TV: [Manage Stream TV games in Gamification](configure-view-tvs.md)

4. Select the **Sport Theme** you want to use for the game.

5. To specify how often players can change their teams, set the **Draft Frequency**. Ideally, you'll set a weekly draft frequency to provide players the flexibility to replace members of their teams if they're removed from the game or they take some time off.

6. Set the **Start Date** and **End Date** for the game. Games run on a weekly schedule, from Monday to Sunday. Set your start and end dates accordingly to avoid game periods of less than a week.

   > [!TIP]
   > For an engaging experience for players, we recommend you set the game duration between two and six months. Shorter games make it harder for people to become immersed in the game, while longer games have proven to be harder to keep track of.

7. In the game setup header, select **1** to proceed to the next step.

### KPI types and user roles

 KPIs are the key to games. They are metrics based on Dynamics 365 data that automatically syncs to [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] and are the basis for points awarded to players. KPIs need to be set for weekly goals.  

> [!TIP]
> - **Use descriptive names** for KPIs so players can understand how to earn points.
> - **The ideal number of KPIs per game is between three and five.** Having too many KPIs will result in players focusing on a few metrics while others are forgotten. But you also want to have enough KPIs so that players of all levels will feel they can contribute and succeed. A good practice is to include both results-driven and behavioral KPIs.  Examples of results-driven KPIs are revenue amount, % of quota, and closed sales. Behavioral metrics include things like number of calls made, number of appointments set, and number of demos held. Of course, you can define as many KPIs as you like for your game.
> - **Use lower numbers for KPIs.** For example, award 1 point for every new lead rather than 100 points for every five leads so there isn't too large a spread between first and second place. Players might feel they've already lost if they have to earn a vast number of points to reach the next position.
> - **Include floors and caps for KPIs** to avoid the achievements of a single rep overwhelming the entire playing field. Floors define the minimum number a KPI needs to meet for a player to get points. Caps define the upper limit for the KPI to generate points for players. For example, if you set a floor of 5 and a cap of 50 for a KPI that tracks phone calls, players need to achieve at least 5 phone calls to get a point. Due to the cap, they will get the same points for 80 calls as they'd get for 50 calls. Floors and caps are reset each week of the game.
> More information about KPIs: [Concepts to learn before you get started using Gamification](get-started.md)

#### Select a KPI

1. In step 2 of the game setup process, choose whether you want to use **Actuals** or **Targets** for the KPIs in this game. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Concepts to learn before you get started using Gamification](get-started.md)

2. Choose from the available KPIs in the list. KPIs are created by a user who has the **Game Manager** security role assigned. Those users also get a game manager user role when they sign in to [!INCLUDE[cc_gamification_portal](../includes/cc-gamification-portal.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Configure KPIs for Gamification](configure-kpis.md)

3. Optionally, provide a different (game-specific) name for the KPI.

4. Select the method to measure the KPI from the list. You can choose **Number of**, **Revenue or Amount**, **Percentage**, or **Percentage of Quota**.

   If you select **Percentage of Quota** in one of your KPIs, a new step is added to the game setup process where you will be asked to define the quotas for each player.   Experience has shown that using **Default** rather than **Linear** is easier to keep track of for players.

5. Define how many points players will get when they reach a KPI.

   To set a weekly target that the player can achieve, create a hit or miss KPI, and then change the word **every** to **at** in step 2 of the game setup process.

6. Optionally, set the **Floor** and **Cap** values for the KPI.

7. Repeat the steps above for all KPIs you have planned for the game.

8. Optionally, you can use Excel point scoring for certain KPIs. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Update game scores by using Excel point scoring capabilities in Gamification](update-scores-using-excel-point-scoring.md)

9. In the game setup header, select **2** to proceed to the next step.

> [!IMPORTANT]
> When you remove a KPI from an active game, a user with the **Game manager** security role needs to select **Refresh Data** in the Dynamics 365 app (**Gamification** > **Gamification Settings**) to update the data. You can edit and update KPIs in an active game up to 14 days after the start of the game. 

#### Game quotas

 If you created a **Percentage of quota** KPI in step 2 of the game setup process, you need to define the game quotas for the players. Optionally, you can set the quota for all players on all or individual KPIs to the same value.  
  
> [!NOTE]
>  You can have up to four KPIs per game that use a quota.
  
### Players and fans

 Depending on the selected sports theme, you can now assign players to positions and then select fans to participate in the game.

 To assign a player to a position, select the position, and then select the check box for the users you want to assign to the position.

> [!TIP]
>  Make sure you distribute players evenly on positions to prevent anyone from drafting all the top performers onto their team.

 To add fans to a game, select them from the list in step 3.

 Select **4** to proceed to the next step.

### Awards and prizes

In this step, you can define the various awards and prizes for the overall game. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Concepts to learn before you get started using Gamification](get-started.md)

In addition to game awards, you can set up weekly awards. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Create weekly awards to keep players and fans engaged](define-weekly-awards.md)

To complete the game setup, select **Start Game** for the dates you defined. You can also save the game and refine your settings before you start it.

After you activate the game, and before the game start date, you can change KPIs, game awards, and player game quotas, but you can't add new **Percentage of quota** KPIs. On or after the game start date, you can still change the game awards and player game quotas.

> [!NOTE]
> Add or remove players or fans up to 14 days after you activate a game by choosing **Add or remove players or fans** on the **Games** page, which you'll see after the game is activated. If a player is no longer with the organization, deactivate them from the **Players** page. If you're running a game that uses fantasy teams, you need to first deactivate a player in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] to freeze the points for that player, so teams don't lose points for the current and past game periods.

 Don't forget to complete the game when you reach the game end date. It's a critical step to be sure prizes get awarded to the players.

## Run the game and keep scores up to date

 During an active game, make sure the players and fans stay engaged. If you update certain KPIs manually, you'll use the Excel point scoring feature. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Update game scores by using Excel point scoring capabilities in Gamification](update-scores-using-excel-point-scoring.md)

> [!IMPORTANT]
> When you edit an active game and remove a KPI or change the active players, a user who has the **Game manager** security role needs to select **Refresh Data** to update the data.
> 
> [!TIP]
> - Consider setting up a TV for your office to show the leaderboard and announcements on the smack talk board. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Manage Stream TV games in Gamification](configure-view-tvs.md)
> - Send weekly email blasts to all participants to share who's leading the pack in the current game and motivate them to deliver their best results. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Schedule weekly or one-time emails](schedule-weekly-one-time-emails.md)

## Complete a game

 After the game end date, a game manager or commissioner must complete point scoring for the last game period. The game manager or commissioner also needs to make sure all the data is correct so KPIs reflect the correct values and players are assigned the correct final scores and prizes. Complete a game manually, or let the game be completed automatically 31 days after the game end date.

### Manually complete a game

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Games**.

2. In the **Active Games** list, select **End Game** for the game you want to complete.

### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Install and configure the Gamification solution](manage-gamification-in-dynamics-365-online.md)   
 [Import players and fans from Dynamics 365 apps and manage their security roles](manage-players-fans.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
