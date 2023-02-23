---
title: Add an alternate grid control | MicrosoftDocs 
description: Learn how to replace the out of the box grid control
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: how-to 
ms.date: 03/01/2023 
ms.custom: bap-template 
---

# Add an alternate grid control

Out-of-the-box, **Associated Grid Control** uses the Power Apps grid control that supports the latest Microsoft accessibility standards and is built to be performant, extensible for the future, and aligns with the latest guidance for fonts, sizing, and styling. However, you can choose to add an alternate grid control.

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
2. Select **Solutions**, and then select the required solution.
4. Select **Add Existing** > **More** > **Setting**.
1. On the **Add existing Setting Definition** pane, select the **Grid type for Associated grid control** option and then select **Next**.
1. Select **Add** on the **Selected Setting Definition** to add the **Grid type for Associated grid control** option to your solution.
1.  Go to **Add Existing** > **App** > **Model-driven app**> **Add existing model-driven apps** pane.
1. Select the **Grid type for Associated grid control** option. The **Edit Grid type for Associated grid control** pane appears. The **Default value** is set to **Microsoft.PowerApps.PowerAppsOneGrid**.
1. Select **Add existing value** in **Setting environment value**. Specify **MscrmControls.Grid.PCFGridControl** to replace the default values for all the apps in your environment.
1. Optionally, select **New app value** for the app. For a specified app, the tab set at the application level overrides the environment level setting.
1. Select **Publish All Customizations**.

   :::image type="content" source="media/edit-grid-type-assoc.png" alt-text="Add an alternate grid control" lightbox="media/edit-grid-type-assoc.png":::

## See also

[Overview of the model-driven form designer](/power-apps/maker/model-driven-apps/form-designer-overview)  