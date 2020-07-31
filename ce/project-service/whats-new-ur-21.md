---

title: What's new or changed in Project Service Automation Update Release 21, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 21, V3. 
author: ruhercul  
manager: kfend 
ms.service: dynamics-365-projectservice 
ms.custom: dyn365-projectservice 
ms.date: 06/19/2020 
ms.topic: article 
ms.prod: 
ms.technology: Microsoft Dynamics 365 Project Service Automation 3.x 
ms.author: ruhercul 
audience: Admin 
search.audienceType: 
    - admin
    - customizer 
    - enduser 
search.app: 
    - D365CE 
    - D365PS 
---

# Project Service Automation Update Release 21, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 21. This version has a build number of V 3.10.32.50 and is generally available through a self-update in June 2020.

## Update Release 21

### Bug fixes

**Time and Expense**

The following issues have been fixed:

- When hosting the **Time Entry Grid Control** in Dashboards, the grid does not utilize the full width of the dashboard grid container.
- For specific time zones, the **Time Entry** grid control does not display records.
- Time entries that are after 9:00 PM appear on the wrong day.
- Users are unable to submit expenses if the expense category, **Expense receipt required** has no value.

**Resource Management**

The following issues have been fixed:

- Inactive bookings are displayed in the **Reconciliation** view.
- Generic resource fulfillment was missing validation to ensure that a valid booking status exists.

**Project Management**

The following issues have been fixed:

- The **Project** form grids (**Resource Assignment**, **Task**, **Reconciliation** view, **Expense Estimates**) remain editable even when a project is not active.
- Duplicate customers can't be merged with customers that are linked to confirmed project contracts.
- When a resource who does not have a valid calendar is added, the system does not return a user friendly-error message.
- The **Add Task** button on the task grid is enabled when the project is linked to **Microsoft Project add-in**.
- Effort grows uncontrollably when a task with a category is assigned to a resource with a role for which there is a cost price defined.

**Sales**

The following enhancements have been made:

- **Invoice Frequency** and **Billing Start** have been moved to the **Invoice Schedule** tab.

The following issues have been fixed:

- **Total Sales Price** is zero (0) for **Category** even though **Role** has a total sales price that is not zero.
- Customers can't change the value of the **Invoice Status** field to **Ready for invoicing** when another customized process is updating an additional field.
- The **Refresh Invoice Lines** button can create multiple duplicated lines if it is repeatedly selected.
- The **Update Prices** button doesn't work on the **Role Prices** sub-grid in the **Quick View** form.
- The **Sales Price List Resolution** logic improperly handles time zones, resulting in the incorrect selection of price lists.
- A project’s **Total Actual Cost** can be off by a fractional amount after a single time entry is approved.
- The **Price Resolution** logic does not provide a user-friendly error message if **Retrieved RolePrice** doesn't have values in **'Primary Unit'** and **'Price In Primary Unit'** fields.
