---
title: "Add the personalization tab to enable personal quick replies | MicrosoftDocs"
description: "Learn how to add the personalization tab to enable quick replies on a Unified Service Desk client in Omnichannel for Customer Service."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 01/05/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Enable personal quick replies

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You can enable personal quick replies by adding a personalization tab to your Unified Service Desk configuration. After you add the personalization tab, you can view the tab depending on where it was added. More information on quick replies: [Create a record in Ominchannel for Customer Service](create-record.md) and [Create personal quick replies in Omnichannel for Customer Service in Unified Service Desk](create-personal-quick-replies-usd.md).

**To add the personalization tab**

1. Open the **Unified Service Desk Administrator** app. Inthe left pane, go to **Basic Settings** > **Action Calls**.

2. To create an action call record, select **New** and then provide the following information:

    * **Name**: OpenPersonalizationPage
    
    * **Order**: 4
    
    * **Hosted Control**: Search Page HC
    
    * **Action**: Navigate

    * **Data**: `url=/main.aspx?pagetype=entityrecord&etn=msdyn_usersetting&id=b5c6b1bb-47ad-ea11-a812-000d3a8c9c8c <br> HideNavigationBar=True`

3. Select **Save**.

    > [!div class=mx-imgBorder]
    > ![Create new action call record](../media/create-new-action-call-record.png "Create new action call record")

4. In the left pane, under **Basic Settings**, go to **Toolbars** > **Omnichannel ToolbarStrip**.

5. In the **Buttons** area, select the button under which you want the personalization button to appear, and then in the **Related** tab, select **Toolbar Buttons**.

    > [!div class=mx-imgBorder]
    > ![Select Toolbar Buttons in the Related section](../media/select-toolbar-buttons-related-section.png "Select Toolbar Buttons in the Related section")

6. Select **New Toolbar Button** and create a toolbar button record with the following parameters:

    * **Name**: Personalization
    
    * **Button** Text: Personalization
    
    * **Tooltip**: Personalization

7. Select **Save**.

8. Select **Add Existing Action Call**, and add the following action calls in this order:

    i. Switch to Agent Home Page
    
    ii. OpenPersonalizationPage
    
    iii. ToggleGlobalSearchControl
    
    iv. Focus on Search Grid

    > [!div class=mx-imgBorder]
    > ![Add action calls from the lookup records](../media/add-action-calls-from-lookup-records.png "Add action calls from the lookup records")

9. Under **Advanced Settings** in the left pane, go to **Configurations** > **Agent Configuration** > **Hosted Controls, Events and Action Calls** tab.

10. In the **Action Calls** area, go to **Add Existing Action Call**, and then add the created Action Call **OpenPersonalizationPage**.

    > [!div class=mx-imgBorder]
    > ![Add the newly created action call](../media/add-newly-created-action-call.png "Add the newly created action call")






