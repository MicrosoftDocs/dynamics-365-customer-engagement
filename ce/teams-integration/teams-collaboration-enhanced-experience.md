---
title: "Enhanced Collaboration Experience with Microsoft Teams| MicrosoftDocs"
ms.custom: 
description: "Connect with Microsoft Teams and collaborate with team members using the Dynamics 365 app for Microsoft Teams."
ms.date: 8/26/2020
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
# Enhanced Collaboration Experience with Microsoft Teams

Easily connect customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, or Dynamics 365 Project Service Automation) records or views to a Microsoft Teams channel using the **Collaborate** button on the record or view page. The step-by-step process will help you connect the selected record or view to a Microsoft Teams channel.

The [basic collaboration experience](teams-collaboration.md) only lets you pin a record or a view to a team channel from within Microsoft Teams. The enhanced collaboration experience includes everything in the [basic collaboration experience](teams-collaboration.md) and also lets you pin connect a record or a view to a team channel while you are working in customer engagement apps in Dynamics 365 (such as Dynamics 365 Sales and Dynamics 365 Customer Service). 

## Connect a record or a view to a team channel from customer engagement apps in Dynamics 365

1. In customer engagement apps (such as Dynamics 365 Sales and Dynamics 365 Customer Service), open a record or view.
2. When the record or view is open, on the command bar, select **Collaborate**.

   > [!div class="mx-imgBorder"]
   > ![Collaborate option](media/teams-collorate-option_1.png "Collaborate option in Dynamics 365 app")

3. On the **Collaborate with Microsoft Teams** window, you will see one of the following: 
    - **If there’s no channel that is already connected**: You can connect the current record or view to any team channel by selecting, **Get started**.

      > [!div class="mx-imgBorder"]
      > ![Get started button](media/teams-get-started-2.png "Selected Get Started")

    - **If there is channel that is already connected**: You can use the existing connected channel by selecting the channel and then select **Start collaboration**. This will open Microsoft Teams and navigate to the connected channel that you selected, or you can connect the current record or view to another team channel by selecting, **Create a new connection**.

      > [!div class="mx-imgBorder"]
      > ![Select existing channel](media/teams-existing-channel-screen-note.png "Selected existing channel")

     > [!NOTE]
     >  If you selected an existing connected team channel where you are not the owner or member in that team, then when Microsoft Teams opens, select **Join** to send request to be added to the channel. 

4. After you select **Get started** or **Create a new connection**, you will enter into the connection process. 

   **Step 1**- **Team selection**: Choose an existing team or create a new team.
   - Choose an existing team that you belong to and then select **Next**.

     > [!div class="mx-imgBorder"]
     > ![Choose a team](media/teams-add-to-existing-team-3.png "Choose a team")

   - Or, create a new team:  

        1. Select **Create new team**.
            > [!div class="mx-imgBorder"]
            > ![Choose a team](media/teams-create-new-team-4.png "Choose a team")


        2. Enter a name for the team and then select **Next**.
            > [!div class="mx-imgBorder"]
            > ![Enter name](media/teams-enter-team-name-5.png "Enter a team name")


   **Step 2**- **Channel selection**: Choose an existing channel and then select **Next**, or select **Create new channel** to create a new channel.

      > [!div class="mx-imgBorder"]
      > ![Choose a channel](media/teams-choose-channel.png "Choose a channel")

      > [!NOTE]
      > When you create a new team, the system automatically creates a channel named **General**. You can connect the current record to the **General** channel and then select **Next** or select **create new channel** to create a new channel under the new created team.
      > > [!div class="mx-imgBorder"]
      > > ![Enter name](media/teams-add-channel-6.png "Enter a team name")


   **Step 3**- **Add recommended team members**: If you are the owner of the selected team then you can add recommended teammates who either own the record or the record has been shared with them to the team member group. From the list, select any or all listed teammates. You can also use the search option to find the teammates in the list. When you are done, select **Finish**.

   > [!NOTE]
   > You will only see this step only if you are the owner of the selected team while connecting to a customer engagement app record. If you are connecting a view of customer engagement app to a Microsoft Teams channel, you will skip this step. For more information on how to share a record, see [Assign or share records.](/powerapps/user/assign-or-share-records).

   > [!div class="mx-imgBorder"]
   > ![Choose teammates](media/teams-choose-teammates-7.png "Choose teammates")

5. When the connection process is complete, the system will open Microsoft Teams and go to channel that you connected.




[!INCLUDE[footer-include](../includes/footer-banner.md)]