---
title: Enable pagination for a grid | MicrosoftDocs 
description: Learn about adding pagination to a grid
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# Enable pagination for a grid

The grid supports sorting and will be paginated if the number of records is larger than the page size specified.

You can configure if the grid supports if the number of records is larger than the page size specified.You can set this at an environment level or for a specific app.

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the required solution.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Redirect user to the specified tab to close open activities** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Case association grid control name** option to your solution.
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Case association grid control name** option. The **Case association grid control name** pane appears.
1. Set the **Setting environment value** option to the required value. In the **Setting app value** section, the Customer Service Hub and Customer Service workspace apps are displayed.
1. Optionally, select **New app value** for the app. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.
