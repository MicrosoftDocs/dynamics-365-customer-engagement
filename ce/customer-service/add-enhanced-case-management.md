---
title: Customize the case resolution experience | MicrosoftDocs
description: Use this article to learn how to configure enhanced case management.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 04/05/2023 
ms.custom: bap-template 
---

# Customize the case resolution experience

Customize the case resolution experience in Power apps as follows:

- When agents try to close a case with open activities, the application displays a warning message with a redirect link. You can configure the tab agents view when they select this link.
- Choose to display the legacy **Resolve case** dialog instead of the default minimal **Resolve case** dialog when an agent closes a case with open activities.

## Specify tab to redirect users to close the open activities for a case

You can configure the tab users must be redirected to when they select the open activities link on the  **Resolve Case** dialog. You'll need to add and configure the **Redirect user to the specified tab to close open activities** setting definition in Power Apps to set the tab at an environment level or for a specific app.

1. In [Power Apps](https://make.powerapps.com/), add the **Redirect user to the specified tab to close open activities** setting definition. More information: [Add an existing setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition).
1.  You'll need to update the setting definition with the tab name. To find the tab's name, perform the following steps:
    - Navigate to a form which has the required tab.
    - Select the tab, and then copy the value in **Name** in **Display options**.  
1. In the **Edit Redirect user to the specified tab to close open activities** pane, paste the name in the **Setting environment value** option. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).
1. Optionally, in the **Setting app values** section, or a required app, you can set the tab in **New app value**. The tab set at the application level overrides the environment level setting.

    :::image type="content" source="media/powerapps-redirect-user-tab.png" alt-text="Redirect link to tab" lightbox="media/powerapps-redirect-user-tab.png":::

1. Select **Publish All Customizations**.

## Disable the minimal case resolution dialog

You can choose to display the legacy case resolution dialog box that appears when an agent selects **Resolve case**. You'll need to add and configure the **Enable minimal case resolution dialog** setting definition in Power Apps to revert to the legacy case resolution dialog.

> [!NOTE]
> - You can revert to the legacy case resolution dialog only if the **Case settings** > **Other settings** > **Resolve case dialog** is set to **Standard dialog** in Customer Service admin center.
> - If **Resolve case dialog**  is set to **Customizable dialog** or **Quick create dialog**, to revert back to the previous experience, do the steps in [Modify the case resolution dialog](modify-case-resolution-dialog.md).

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), add the **Enable minimal case resolution dialog** setting definition. More information: [Add an existing setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#adding-an-existing-setting-definition).
1. In the **Edit Enable minimal case resolution dialog** pane, set the **Setting environment value** option to **No**. More information: [Update a setting definition](/power-apps/maker/data-platform/create-edit-configure-settings#updating-a-setting-definition).
1. Optionally, in the **Setting app values** section, for a required app, you can set the value to **No** in **New app value**. The tab set at the application level overrides the environment level setting.

    :::image type="content" source="media/powerapps-redirect-user-tab.png" alt-text="Redirect link to tab" lightbox="media/powerapps-redirect-user-tab.png":::

1. Select **Publish All Customizations**.

### See also

[Work with cases](customer-service-hub-user-guide-create-a-case.md)  
[Work with queues](work-with-queues.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]
