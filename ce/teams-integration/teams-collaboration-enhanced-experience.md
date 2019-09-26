---
title: "Enhanced Collaboration Experience with Teams| MicrosoftDocs"
ms.custom: 
description: "Connect with Microsoft Teams and collaborate with team members using the Dynamics 365 app for Teams."
ms.date: 8/5/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Enhanced Collaboration Experience with Team


[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Easily pin a Dynamics 365 apps record or view to a Teams channel using the **Collaborate** option in the Dynamics 365 app. The step-by-step process will help you connect the selected record or view to a Teams channel.

The [basic collaboration experience](teams-collaboration.md) only lets you pin records to a Teams channel from within Teams. The enhanced collaboration experience lets you pin a record or a view of records to a Teams channel while you are working in Dynamics 365 apps.

For more information on which entities support the collaborate option, see [Record types supporting collaborate](teams-work-records-and-view.md#record-types-supporting-collaborate)

## Pin a Dynamics 365 apps record or view to a Teams channel

1. In Dynamics 365 app, open a record or view.
2. When the record or view is open, on the command bar, select **Collaborate**.

   > [!div class="mx-imgBorder"]
   > ![Collaborate option](media/teams-collorate-option_1.png "Collaborate option in Dynamics 365 app")

3. On the **Collaborate with Microsoft Teams** window, select **Get started**.

   > [!div class="mx-imgBorder"]
   > ![Get started button](media/teams-get-started-2.png "Selected Get Started")
   
   > [!NOTE]
   >  - If there is channel that is already set-up, then you can use the existing pinned channel by selecting the channel and then select **Start collaboration**. This will open the Teams app and go to the pinned channel that you selected. Or, you can pin the page to another Teams channel, by selecting **Create a new connection**.
    
      > [!div class="mx-imgBorder"]
      > ![Select existing channel](media/teams-existing-channel-screen-note.png "Selected existing channel")
   
     >  - If you selected an existing channel where you are not the owner or member, then when the Teams app opens select **Join** to send request to be added to the channel. 
   
4. To pin the record to an exising team or a new team, do one of the following:

  - **To pin to an existing team**
    1. From the list of teams that you belong to, choose the team that you want to pin the record to and select **Next**.
   
       > [!div class="mx-imgBorder"]
       > ![Choose a team](media/teams-add-to-existing-team-3.png "Choose a team")
    
    2. Choose an existing channel and then select **Next** or select **Create new channel** to create a new channel.
    
       > [!div class="mx-imgBorder"]
       > ![Choose a channel](media/teams-choose-channel.png "Choose a channel")
   
  - **Or, to pin to a new team**
    1. To create a new team select, **Create new team**. 
 
       > [!div class="mx-imgBorder"]
       > ![Choose a team](media/teams-create-new-team-4.png "Choose a team")

    2. Enter a name for the team and then select **Next**.
    
       > [!div class="mx-imgBorder"]
       > ![Enter name](media/teams-enter-team-name-5.png "Enter a team name")
      
    3. When you create a new team, the system automatically creates a channel named **General**. You can add the record to the **General** channel and then select **Next** or select **create new channel** to create a new channel. 
    
       > [!div class="mx-imgBorder"]
       > ![Enter name](media/teams-add-channel-6.png "Enter a team name")
       
 > [!NOTE]
 >  You will only see the next step only if you pin a record and you are the owner of the Teams channel. If you pin a view  of Dynamics 365 apps records, then you will not see the next step.
 
 5. If you are the owner of the Teams channel then you can add teammates to the channel. From the list, select the recommended members who either own the record or the record has been shared with them. You can also use the search option to find other teammates related to the record. When you are done, select **Finish**.
 
 > [!NOTE]
 > For more information on how to share a record, see [Assign or share records.](https://docs.microsoft.com/powerapps/user/assign-or-share-records)

   > [!div class="mx-imgBorder"]
   > ![Choose teammates](media/teams-choose-teammates-7.png "Choose teammates")
   
When the set-up process is complete, the system will open the Teams app and go to channel that you created.


### See also  

[Install the app and set up the Teams tab](teams-install-app.md#install-the-app-and-set-up-the-teams-tab)

[Use Teams to open a record or view](teams-work-records-and-view.md)

[Basic Collaboration with Teams](teams-collaboration.md)
