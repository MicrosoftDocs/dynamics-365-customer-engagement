---
title: Add case handling time widget to case forms 
description: Learn how to enable and configure the case handling time widget, which shows the total time customer service representatives spend on a case in Dynamics 365 Customer Service.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 11/26/2026
ms.custom: bap-template 
ai-usage: ai-assisted
---

# Configure the case handling time widget on case forms

Case handling time is the total time customer service representatives (service representatives or representatives) actively work on a case. It includes communicating with customers, troubleshooting, researching, collaborating, and updating case details, such as adding notes.

> [!NOTE]
> - Case handling time is supported in both custom and out-of-the-box single session apps, and out-of-the-box multisession apps only, such as Copilot Service workspace.
> - Case handling time differs from case resolution time. For example, if a representative works on a case for 5 hours and resolves it 5 days after creation, the handling time is 5 hours and the resolution time is 5 days.

## Enable case handling time widget

To display the case handling time widget on a case form, follow these steps:

1. In Copilot Service admin center, select **Customer Support** > **Case settings**.
1. On the **Case settings** page, select **Manage** for **Case handling time**. The **Case handling time** page opens.
1. Select the **Enable case handling time** checkbox.
1. Select the Power Apps link to open the [**Solutions**](/power-apps/maker/data-platform/solutions-overview#work-with-solutions-in-power-apps) page.
1. In Power Apps, select the solution that contains your custom case form, and then select **Tables**.
1. On the **Tables** page, select **Case**, and then select **forms**.
1. Select the required form, and [add the **Handling time** component](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-for-a-column-on-the-form). At runtime, the widget appears at the bottom right of the case form, regardless of where you add it. Adding it to an existing section within the viewport is recommended. A blank space appears where you added the component.
1. Configure these component properties:

      - **Table**: Set this value to **Time Trackers**.
      - **View**: Set this value to **All Time Trackers**.
      - **Allow users to add time logs**: Set this value to **True** or **False**, depending on whether you want representatives to manually add time on the case. The default is **True**.
      - **Show users only their contributed time**: Set this value to **True** or **False**, depending on whether you want representatives to see only their own time or the total time of all representatives on the case. The default is **False**.
      - **Make CHT widget visible to users**: Set this value to **False** to hide the time tracking widget from representatives. However, the application still tracks time in the background. The default is **True**. 
1. Select **Show related records**.

   > [!NOTE]
   > - In Copilot Service workspace, the application automatically tracks time in the background when a representative opens a case and the case form is in focus, even if you don't add the widget. You can create reports on the automatically tracked time for each representative and case.
   > - In Customer Service Hub, you must add the widget to the case form to track time automatically.

1. Save and publish the changes.

You can also view time tracker records in the [`msdyn_timetracker`](../../developer/reference/entities/msdyn_timetracker.md) table.

## Set the update interval

The update interval determines how often the application updates automatically tracked time in the database and the widget. You can set an interval between 10 and 60 minutes. The default is 10 minutes. At each interval, the application:

- Updates the database with the automatically tracked time.
- Automatically refreshes the case handling time widget to display the updated time.

For example, with a 10-minute update interval, the application updates the database and widget every 10 minutes. If two representatives open the same case at the same time, the widget displays 20 minutes of total tracked time after 10 minutes.

## Enable case handling time for service representatives

To show the case handling time widget on the case form for service representatives, enable the **Case handling time** feature in **Experience profiles**.

Follow these steps:

1. In Copilot Service admin center, select **Workspaces** in **Support experience**. The **Workspaces** page appears.
1. Select **Manage** for **Experience profiles**. The **Experience profiles** page appears.
1. Select the required experience profile.
1. In the **Case Handling Time** section, select **Edit**.
1. Select the **Enable case handling time** checkbox.
1. Select **Save and close**.

> [!NOTE]
> When the **Enable case handling time** checkbox is selected, the service representative sees the case handling widget on the case form, even if the **Case handling time** feature isn't enabled in **Case settings**.

## Delete time tracker records

The application stores automatic time tracker records for each representative and case at the configured update interval. To free database storage, you can delete time tracker records for old, resolved cases:

1. Select the **Time tracker list** link to view the records.
1. Select the records to delete, and then select the **Delete** icon.

> [!NOTE]
> - Keep these records if you plan to use them in reports.
> - In the legacy case resolution dialog (Standard dialog), the displayed total time might differ from **Total Time** in the widget because the dialog uses only case activities. To use the widget's total time, switch to the Customizable or Quick Create case resolution dialog and include the **Total Time** attribute from the Case Handling Time (Time Tracker) table.


## Related information

[Track your time on cases](../use/case-handling-time.md)
