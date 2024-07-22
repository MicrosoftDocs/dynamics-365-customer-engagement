---
title: Display case handling time on case forms (preview)
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

Case handling time is the total time agents actively work on a case. It includes activities such as communicating  with customers, troubleshooting, researching, collaborating, or updating case details, like adding notes.

> [!NOTE]
> Case handling time and case resolution time are different. For example, an agent works actively on a case for 5 hours. The case is resolved 5 days after it was created. In this example, the case handling time is 5 hours, and the case resolution time is 5 days.

## Enable case handling time

To display the case handling time widget on a case form, follow these steps:: 

1. In Customer Service admin center, select **Customer Support** > **Case settings**.
1. In the Case settings page, select **Manage** for **Case handling time (preview)**. The Case handling time (preview) page opens.
1. Select the **Enable case handling time** check box.
1. Select the Power Apps link. The application shows the [**Solutions**](/power-apps/maker/data-platform/solutions-overview#work-with-solutions-in-power-apps) page. Then do these steps in Power Apps:

    1. Select the required solution and then select **Tables**. 
    1. In the **Tables** page select **Case** and then select **forms**.
    1. Select the required form and add the [**Handling time** component](/power-apps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form#add-components-to-a-form) to the form, and specify the following properties:

      - **Table**: Set this value to **Time Trackers**.
      - **View**: **All Time Trackers**.
      - Set **Allow agents to add time logs** to **True** to let agents manually add time on the case. If this is set to **False**, agents can't see **Time logs** in the widget. The default is **True**.
      - Set **Show agents only their contributed time** to **True** to show agents only their own time on a case. If this is set to **False**, agents can see the total time of all agents on the case. The default is **False**.
    > [!NOTE]
    >  - If you are using Customer Service Workspace, you can choose not to add the Case Handling time widget, if you do not want the widget to be visible to the users on the case form. The automatic time will be tracked silently in the background whenever a user opens the case, and the case form is in focus. You will be able to create reports on automatic time tracked per user for each case.
    > - If you are using Customer Service Hub, it is mandatory to add Handing time widget on the case form for automatic time to be tracked.
    > - Irrespective of where you add Handling time component on the case form, it will appear on the bottom right of the case form at runtime. We recommend that you add the component in an existing section within the viewport. During runtime, you will see a small blank space at the position where this control is added on the case form.
    1. Save and publish the changes.

1. You can specify the interval at which the automatic time tracked is stored in the database and the timer gets refreshed to show the latest Total time tracked on a case. You may refer the following steps in [Specify the **Update interval (minutes)**](#specify-the-update-interval). 
1. Automatic time tracker records for each agent for every case are stored in the database according to the update frequency that you set. These records can take up a lot of space over time. To save storage space in the database, you can delete the time tracker records for old resolved cases. Perform the following steps to delete the records:
   1. Select the **Time tracker list** link to view the list of time tracker records.
   1. Select the  required records and then select the **Delete** icon to delete the time tracker records.

> [!NOTE]
> The total time that agents see depends on the case resolution dialog:
> - If you plan to use these individual time tracker records for building reports (like automatic time tracked for each agent per day, for all cases), you should not delete these records.
> - If you are using Legacy case resolution dialog (Standard dialog), Total Time shown might not match with the Total time shown on the Case Handling Timer widget since Total time shown on legacy case resolution standard dialog is the time from the incident resolution entity and is a sum of time tracked only on case activities. If you want to see the Total time tracked by Case Handling timer, we recommend you using either Customizable case resolution dialog or quick create case resolution dialog and add Total time attribute from the case handling time (Time Tracker) table to it.

## Specify the update interval

When you specify a time for the update interval, the application perform the following actions:

- Updates the database with the automatic tracked time in the frequency specified.
- Automatically refreshes the case handling time widget to display the updated time.

You can specify a value between 10 and 60 minutes. The default value is 10 minutes.

For example, if you specify 10 minutes as the update interval, the automatic time tracked on the case is updated to the database after every 10 minutes. If two agents open the same case at the same time, after 10 minutes, the case widget displays 20 minutes as the total time. 
