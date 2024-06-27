---
title: Display case handling time on custom case forms
description: Use this article to learn how to add case handling time on custom case forms.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/01/2024 
ms.custom: bap-template 
---

# Display case handling time on case forms (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/preview-note.md)]

Case handling time is the total time agents spend working on a case. Case handling time allows supervisors and agents to differentiate between the time agents actively spend on the case and the number of days it took to close the case.  The case handling time is displayed as a widget on the out-of-the-box case forms. You can also add the case handling time widget to custom case forms.

## Enable case handling time

1. In Customer Service admin center, select **Case settings** in **Customer Support**.
1. In the Case settings page, select **Manage**  for **Case handling time (preview)**. The Case handling time (preview) page appears.
1. Select the **Enable case handling time** check box.
1. Specify the **Update interval (minutes)**. 
1. The link to Power Apps is enabled. Select the **Go to Power Apps for configuration** link. The **Solutions** page appears.
1. Select the required solution and then select **Tables**. 
1. In the **Tables** page select **Case** and then select **forms**.
1. Select the required form and add the [**Entity handling time** component](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-to-a-form) to the form, and specify the following properties:

    - **Table**: Set this value to **Time Trackers**.
    - **View**: **All Time Trackers**.
    - Select **Allow agents to add time logs** to allow agents to manually add time directly on the case. If this check box isn't selected, agents can't see **Time logs** in the case handling time widget. By default, this checkbox is selected.
    - Select **Show agents only their contributed time** to ensure that a specific agent sees only their time contribution to the case. If this check box isn't selected, agents can see the total time spent on the case by all agents. By default, this checkbox isn't selected.
    - 
1. Save and publish the changes.

## Specify the update interval

When you specify a time for the update interval, the application perform the following actions:

- Updates the database with the tracked time in the frequency specified.
- Automatically refreshes the case handling time widget to display the updated time.

You can specify a value between 10 and 60 minutes. The default value is 10 minutes.

For example, if you specify 10 minutes, and two agents are working on a case for 10 minutes each, the database is updated in 10 minutes and the case handling time widget displays 20 minutes as the time spent on the case.