---

title: Create time entries
description: This topic provides information about how to create time entries.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 05/20/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Create time entries

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In previous versions of Dynamics 365 Project Service Automation, time entries were entered on a weekly basis. In version 3 of Project Service Automation, time entries are entered on a daily basis. However, after a few time entries have been created, you can bulk create or copy them.

## Create a time entry

Follow these steps to create a time entry.

1. On the **Time Entries** page, select **New**.
2. In the **Quick Create: Time Entry** dialog box, enter the duration of the time entry in minutes, hours, or days. The duration must be entered in the following format: *x* minutes, *x* hours, or *x* days. Hours and days can also be entered as decimal values, such as *x.x* hours or *x.x* days.
3. Select the type of time entry and the project that you're entering the time entry for.
4. In the **Project Task** field, find the task for this time entry.

    > [!NOTE]
    > If you're creating a time entry for a task that isn't assigned to a user, in the **Project Task** field, select the **Search** button, select **Change View**, and then select **All Active Project Tasks** to list all tasks.

5. Enter a description, if a description is required, and then select **Save and Close**.

After the time entry is created and saved, you can edit it in the time entry grid. The time entry grid supports two formats:

- You can enter time entries in **hh:mm** format. This format is then converted to hours and fractions.
- You can enter hours and fractions directly.

Note that the fractions of an hour aren't minutes. Therefore, 1.5 hours represents 1 hour and 30 minutes. The same rule applies to fractions of a day. One day is 24 hours, and 0.5 days represents 12 hours.

## Bulk create time entries

After a few time entries have been created, you can copy them to create additional time entries in bulk.

1. On the **Time Entries** page, select **Copy Week**.
2. In the **From Period** field group, in the **Start Date** and **End Date** fields, define the date range to copy time entries from.
3. In the **To Period** field group, in the **Start Date** field, specify the date to create time entries for.
4. Select **Copy** to create a copy of the time entries that correspond to the day of the week that is specified in the **To Period** field group. For example, the time entry for Monday of last week is copied to Monday of the week that is specified in the **To Period** field group.

## Import data for time entries

You can import data from project bookings and assignments. When you import data, you can specify the date range of the bookings to import and then explicitly select the bookings that should be created as **Draft** time entries.

## Group by, sort, search, and filter capabilities

You can group and filter time entries by the dimensions that are specified in the columns. In the **Group by** field, select the dimension to use to filter time entries. You can also sort the time entry records in ascending or descending order by using the sort arrow on the column headings. Additionally, you can show or hide entries by selecting the **Filter** button on the column headings, and then, in the **Search** box, entering the text that should be used to search for time entries by project name, project task, time entry, or resource.
