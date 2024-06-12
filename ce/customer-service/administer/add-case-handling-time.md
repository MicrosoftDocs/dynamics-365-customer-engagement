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

# Display case handling time on custom case forms

Case handling time is the total time agents spend working on a case. The case handling time is displayed as a bubble on the out-of-the-box case forms by default. 

Perform the following steps to add the case handling component to a case form:

1. In Customer Service admin center, select **Case settings** in **Customer Support**.
1. In the Case settings page, select **Manage**  for **Case handling time (preview)**. The Case handling time (preview) page appears.
1. Select the **Enable case handling time** check box. The link to Power Apps is enabled.
1. Select the **Go to Power Apps for configuration** link. The Power Apps form page for Case table appears.
1. Select the required form and add the [**Case handling time** component](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-to-a-form) to the form, and specify the following properties:

    - Track automatic time: Specify if the application should track time automatically only for the case owner or for any user who is working on the case.
    - Select **Allow agents to add time logs** to allow agents to manually add time to a case. If this check box isn't selected, agents can't see **Time logs** in the case handling time widget. By default, this checkbox is selected.
    - Select **Show agents only their contributed time** to see a specific agent's time contribution to the case. If this check box isn't selected, agents can see the total time spent on the case by all agents.
1. Save and publish the changes.