---
title: "Configure channel provider in Channel Integration Framework (CIF) | Microsoft Docs"
description: "Learn how to configure a channel provider install and setup Channel Integration Framework (CIF) for Microsoft Dynamics 365."
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 5612019a-a4b5-4ba5-a232-6b7d66bdfc21
author: kabala123
ms.author: kabala
manager: shujoshi
---

# How to configure a channel provider for your Dynamics 365 organization

Using the Channel Integration Framework solution, you can configure channel providers.
To configure channel providers:

1. Sign-in to Dynamics 365.

2. Select the drop-down button on the Dynamics 365 and select **Channel Integration Framework**.

  ![Dynamics 365 drop-down button to find Channel Integration Framework](media/cif-app-navigation.png "Dynamics 365 drop-down button to find Channel Integration Framework")

3.	Select **+ New** to add a new provider.

4.	In the **New Channel** page, specify the following:

    | Field | Description |
    |-------|-------|
    |Name|Name of the channel provider.|
    |Label|The label is displayed as the title on the widget.|
    |Channel URL|The URL of the provider to host in the widget. See the JavaScript APIs on how to develop communication widget with Dynamics 365 Channel Integration Framework.|
    |Enable Outbound Communication|Clicking on a phone number in the Dynamics 365 Unified Interface page, the widget initiates the call or outbound communication.|
    |Channel Order|Priority number to display the channel for the agents and unified Interface Apps.|
    |API Version|Version of the of Channel Integration Framework|
    |Select the Unified Interface Apps for the Channel| The list of Unified Interface Apps where the channel is displayed for the agents. |
    |Select Roles for the Channel|The security roles that is present in Dynamics 365.<br>**Note:** If you do not assign any role, the channel provider is shown to all users assigned for the Dynamics 365 Unified Interface App.|

5. Launch the Unified Interface App to see the communication widget on the right-side.