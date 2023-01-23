---
title: "Configure the enhanced case management experience | MicrosoftDocs"
description: "Use this article to learn how to configure enhanced case management "
ms.date: 02/01/2023
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
searchScope:
- D365-App-customerservicehub
- D365-Entity-queueitem
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Use Power Apps to customize the case management experience

This article discusses how to configure the redirection link in the resolve case dialog and how to disable the default resolve cases dialog.

## Specify tab to redirect users to close open activities for a case

You can configure the tab users must be redirected to when they select the open activities link on the  **Resolve Case** dialog. You can set this at an environment level or for a specific app.

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to configure the tab users must be redirected to when they select the open activities link on the **Resolve Case** dialog.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Redirect user to the specified tab to close open activities** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Redirect user to the specified tab to close open activities** option to your solution. 
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Redirect user to the specified tab to close open activities** option. The **Redirect user to the specified tab to close open activities** pane appears.
1. Set the **Setting environment value** option to the required tab. You can find the tab's name in the **Display options** > **Name** field of the corresponding form. 
1. In the **Setting app value** section, the Customer Service Hub and Customer Service workspace apps are displayed. 
1. Select **New app value** for the app, and specify the activity tab that the user must be redirected to for the respective apps. This step is optional. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.


## Disable the minimal case resolution dialog

You can choose to display the standard case resolution dialog box that appears when an agent selects **Resolve case**. Perform the following steps:

1. In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the solution in which you want to turn off the minimal case resolution dialog.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Enable the minimal case resolution dialog** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Enable the minimal case resolution dialog** option to your solution. 
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Enable the minimal case resolution dialog** option. The **Enable the minimal case resolution dialog** pane appears.
1. Set the **Setting environment value** option to **Yes**.
1. In the **Setting app value** section, the Customer Service Hub and Customer Service workspace apps are displayed.
1. Select **New app value** for the app, and set the value to **Yes** for the respective apps. This step is optional. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.


