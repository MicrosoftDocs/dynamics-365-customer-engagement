---

title: Create time entries
description: This topic provides information about how to create time entries in Dynamics 365 for Project Service Automation (PSA).
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/20/2019
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
 
In Microsoft Dynamics 365 for Project Service Automation (PSA) v3.x, time entries are entered on a per day basis instead of on a weekly basis, as in previous versions of PSA. However, after a few time entries have been created, you can select to bulk create or copy time entries.

## Create a new time entry
Complete the following steps to create a new time entry.

1. On the **Time Entries** page, click **New**.
2. In the **Quick Create: Time Entry** pane, enter the time entry duration in minutes, hours, or days by typing **h**, **m**, or **d** and the number.   
3. Select the type of time entry and the project that you are entering the entry for. 
4. In the **Project Task** field, locate the task for this time entry.

> [!NOTE] 
> If you are creating a time entry for a task not assigned to a user, click **Change View** and then in the **Project Task** field, select **All Active Project Tasks**.

5. Enter a description if needed, and then click **Save**

After the time entry is created and saved, you can edit the entry in the time entry grid. 

## Bulk create time entries
After a few time entries have been created, you can copy them to create additional time entries in bulk. 

1. On the **Time Entries** page, click **Copy**. 
2. In the **From Period** group, in the **Start Date** and **End Date** fields, set the date range from which to copy the time periods. 
3. In the **To Period** group, in the **Start Date** field, specify the date for which time entries are to be created in.  
4. Click **Copy** to create a copy of the time entries for the corresponding day of the week entered in the **To Period** field. For example, Monday's time entry from last week is copied into Monday for the week indicated in the **To Period** field.

## Import data for time entries
You can import data from project bookings and ssignments. When you import data, you can specify the date range of the bookings that you want to import and then explicitly select the bookings that should be copied into **Draft** time entries.

## Group by, sort, search, and filter capabilities
You can group and filter time entries by the dimensions specified in the columns. In the **Group by** field, select the dimension that you want to use to filter time entries. You can also sort the time entry records in ascending or descending order using the Sort arrow on the column headings. Additionally, you can show or hide entries by using the Filter icon on the column headings. In the **Search** box, enter the text you want to use to search for time entries by project name, project task, time entry, or resource.  
 
