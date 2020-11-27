---
title: "Add the personalization tab in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn on how to add the personalization tab on a Unified Service Desk client in Omnichannel for Customer Service."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 11/27/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Add personalization tab

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

You need to add the personalization tab to your Unified Service Desk configuration in order to use personal quick replies. After you add the personalization tab, you can view the tab depending on where it was added.

1. In the Unified Service Desk Administrator app, in the left pane, under **Basic Settings**, select **Action Calls**.

2. To create a new action call record, select **New**.

3. Provide the following information:<br>

   - **Name**: OpenPersonalizationPage

   - **Order**: 4

   - **Hosted Control**: Search Page HC

   - **Action**: Navigate

   - **Data**: `url=/main.aspx?pagetype=entityrecord&etn=msdyn_usersetting&id=b5c6b1bb-47ad-ea11-a812-000d3a8c9c8c` <br><br> `HideNavigationBar=True`

4. Select **Save**. 

    > [!div class=mx-imgBorder]
    > ![Create new action call record](../../media/create-new-action-call-record.png "Create new action call record")

5. Under **Basic Settings** in the left panel, go to **Toolbars** > **Omnichannel ToolbarStrip**.

6. In the **Buttons** subgrid, select the button under which you want the personalization button to appear.

7. In the **Related** section, select **Toolbar Buttons**.

    > [!div class=mx-imgBorder]
    > ![Select Toolbar Buttons in the Related section](../../media/select-toolbar-buttons.png "Select Toolbar Buttons in the Related section")

8. Select **New Toolbar Button**.

9. Create a new toolbar button record with the following parameters: <br>

   - **Name**: Personalization
   
   - **Button Text**: Personalization

   - **Tooltip**: Personalization

10. Select **Save**.

11. Select **Add Existing Action Call**, and add the following action calls in the following order: <br>

    i. Switch to Agent Home Page

    ii. OpenPersonalizationPage

    iii. ToggleGlobalSearchControl

    iv. Focus on Search Grid

    > [!div class=mx-imgBorder]
    > ![Add action calls from the lookup records](../../media/add-action-calls-from-lookup-records.png "Add action calls from the lookup records")

12. Under **Advanced Settings** in the left panel, go to **Configurations** > **Agent Configuration** > **Hosted Controls, Events and Action Calls** tab.

13. In the **Action Calls** subgrid, go to **Add Existing Action Call**, and then add the newly created Action Call **OpenPersonalizationPage**.

    > [!div class=mx-imgBorder]
    > ![Add the newly created action call](../../media/add-newly-created-action-call.png "Add the newly created action call")