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

Case handling time is the total time agents actively spend working on a case. Handling time includes activities such as communicating with the customer, troubleshooting, conducting research, collaborating with colleagues, or updating case specifics, such as adding notes.

> [!NOTE]
> Case handling time and case resolution time are calculated differently. For example, and agent works actively on a case for 5 hours. The case is resolved 5 days after it was created. In this example, the case handling time is 5 hours, and the case resolution time is 5 days.


## Enable case handling time

Perform the following steps to display the case handling time widget on a case form: 

1. In Customer Service admin center, select **Case settings** in **Customer Support**.
1. In the Case settings page, select **Manage**  for **Case handling time (preview)**. The Case handling time (preview) page appears.
1. Select the **Enable case handling time** check box.
1. Select the Power Apps link. The application displays the [**Solutions**](/power-apps/maker/data-platform/solutions-overview#work-with-solutions-in-power-apps) page. Perform the following steps in Power Apps:

    1. Select the required solution and then select **Tables**. 
    1. In the **Tables** page select **Case** and then select **forms**.
    1. Select the required form and add the [**Handling time** component](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-to-a-form) to the form, and specify the following properties:

      - **Table**: Set this value to **Time Trackers**.
      - **View**: **All Time Trackers**.
      - Set **Allow agents to add time logs** to **True**. This allows agents to manually add time directly on the case. If the value is set to **False**, agents can't see **Time logs** in the case handling time widget. By default, **Allow agents to add time logs** is set to **True**.
      - Set **Show agents only their contributed time** to **True**, for agents to view only the time they have contributed to a case. When this setting is **False**, it enables agents to see the cumulative time all agents have spent on the case. The default setting for Show agents only their contributed time is False.
    > [!NOTE]
    >  When you add a **Handling time** component on the case form, there's a blank space that appears on the form during runtime. We recommend that you add the component at the bottom of the form.
    1. Save and publish the changes.

1. [Specify the **Update interval (minutes)**](#specify-the-update-interval). 
1. Time tracker records, are stored in the database per the specified update frequency for each case and agent, can consume significant storage space. To manage storage efficiently, delete the time tracker records for resolved cases. Select the **Time tracker list** link to view the list of time tracker records.
1. Select the  required records and then select the **Delete** icon to delete the time tracker records.


> [!NOTE]

> Based on the case resolution dialog, the total time that agents see is as follows:
> - Legacy case resolution dialog: Total time is the time tracked using the case handling time.
> - Customizable case resolution dialog or quick create form: Total time is the total time from the incident resolution entity. We recommend you add the Total Time attribute from the case handling time to the case resolution.

## Specify the update interval

When you specify a time for the update interval, the application perform the following actions:

- Updates the database with the tracked time in the frequency specified.
- Automatically refreshes the case handling time widget to display the updated time.

You can specify a value between 10 and 60 minutes. The default value is 10 minutes.

For example, if you specify 10 minutes as the update interval, the automatic time tracked on the case is updated to the database after every 10 minutes. If two agents open the same case at the same time, after 10 minutes, the case handling time widget displays 20 minutes as the total time spent on the case. 
