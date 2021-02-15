---
title: "Personalize the game experience in Dynamics 365 – Gamification | Microsoft Docs"
description: "Learn how to manage the settings that apply to all users of Dynamics 365 – Gamification."
ms.date: 09/28/2018
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: 6603e30d-19bc-4bcf-a48a-c8fb9cb84a54
author: m-hartmann
ms.author: mhart
manager: shellyha
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

# Manage settings to personalize the game experience in Gamification

As a commissioner, you can upload custom logos, provide a pointer for players to get in touch with you, configure Stream TV posts, and choose how to handle player stats and completed games in [!INCLUDE[pn_gamification](../includes/pn-gamification.md)].  

## Generate a security key

The security key is required to connect the web portal of [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] with a Dynamics 365 organization. If you disconnect the web portal from Dynamics 365 and want to connect it again, select **Generate Security Key** to get a new key.
If you are already connected to an organization, you can remove it after all active games are completed. 

> [!WARNING]
> When you remove an organization, all related data such as games, points, KPIs, and user accounts will be permanently deleted.

## Edit the company logo  

Change the company logo to be shown in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] leaderboards.  

### Upload your company logo  

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)],  go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").  

2. Select the **Gamification Settings** tab.  

3. Next to **Organization Logo**, select **Upload Logo**.  

4. Select a logo and upload it. It will be updated automatically.

The company logo is updated when you access games in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)].  

## Configure the contact menu

Define how players and fans get in touch with the commissioner. Participants can select the **Help** > **Contact Commissioner** control when they are signed in to [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Ask game-specific questions or report issues to the commissioner](contact-commissioner.md)  

### Set the link for the contact menu  

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").  

2. Select the **Gamification Settings** tab.  

3. Next to **Contact Menu**, enter an email address or a URL for a help page.  

4. To apply your changes, select **Save**.

## Customize player stats

Choose whether you want to show or hide the **Actuals** tab in the **Player Stats** page. If you want players to see how they're progressing in the leaderboard in real time, don't hide the actuals.  

### Show or hide actuals in player stats  

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").  

2. Select the **Gamification Settings** tab.  

3. In the **Hide Actuals** line, set the value to **On** if you don't want to show the actuals.  

    --Or--  

    Set the value to **Off** if you want to show actuals.  

4. To apply your changes, select **Save**.  

## Display completed games  

 Choose whether you want to display completed games more than 31 days after the game end date on the leaderboard, smack talk board, and player stats page.  

> [!NOTE]
>  Regardless of this setting, games appear on a player's **Teams** page and on their **Player Profile** page.  

## Enable early access to new features

You can opt in for early access to newly developed features to evaluate them for your business scenario.

> [!NOTE]
> Features in preview may not behave as expected and may not be translated into your language yet.

### Opt in for early access

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").

2. Select the **Gamification Settings** tab.

3. Set **Enable early access to new features** to **On**.

4. To apply your changes, select **Save**.


## Show or hide completed games  

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").  

2. Select the **Gamification Settings** tab.  

3. Set the value for **Hide Completed Games** to **On** if you don't want to display completed games more than 31 days after their end date.  

    Set the value for **Hide Completed Games** to **Off** if you want to show completed games continuously.  

4. To apply your changes, select **Save**.  

## Define the posts to show in Stream TV games  

 You can configure which posts from the **Smack Talk** board appear in Stream TV and which posts are hidden when you are streaming the leaderboard to a screen in your office. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Manage Stream TV games in Gamification](configure-view-tvs.md)  

### Configure Stream TV settings  

1. In [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)], go to **Settings** ![Settings button in Gamification](media/settings-symbol-gamification.png "Settings button in Gamification").  

2. Select the **Stream TV Settings** tab.  

3. Set the values to meet your requirements.  

   - **Show Board Posts**: Shows all posts on the smack talk board from a leaderboard shown in a Stream TV.  

   - **Leaderboard Post Display Time (Seconds)**: Number of seconds a smack talk post appears in a Stream TV.  

   - **Leaderboard Post Display Count**: Define how many times a smack talk post appears in a Stream TV.  

   - **Display Waiting Time (Seconds)**: Number of seconds before a smack talk post appears again in a Stream TV.  

   - **Show BAM Posts**: Show all [BAM posts](glossary.md#bam-posts) on smack talk from a leaderboard shown in a Stream TV.  

   - **BAM Display Count**: Define how many times a [BAM post](glossary.md#bam-posts) appears in a Stream TV.  

   - **BAM Display Time (Seconds)**: Number of seconds before a [BAM post](glossary.md#bam-posts) appears again in a Stream TV.  

   - **Enable Public Stream TV**: Allows game owners to create Stream TVs that people can view without signing in to [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Manage Stream TV games in Gamification](configure-view-tvs.md)  

4. To apply your changes, select **Save**.

### See also  

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)   
 [Set up and run games in Gamification](run-games.md)   
 [Manage Stream TV games in Gamification](configure-view-tvs.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]