title: What's new or changed in Project Service Automation Update Release 20, V3
description: This topic lists the features and fixes that are available in
Project Service Automation Update Release 20, V3 author: ruhercul  
manager: kfend ms.service: dynamics-365-projectservice ms.custom:
dyn365-projectservice ms.date: 06/12/2020 ms.topic: article ms.prod: ms.service:
business-applications ms.technology: Microsoft Dynamics 365 Project Service
Automation 3.x ms.author: ruhercul audience: Admin search.audienceType: - admin
- customizer - enduser search.app: - D365CE - D365PS ---

Project Service Automation Update Release 20, V3
================================================

We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability. This release is compatible with Dynamics
365 9.x. To update to this release, visit the Admin Center for Dynamics 365
online solutions page to install the update. For more information, see [Install,
update, or remove a preferred
solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project
Service Automation V3, Update Release 20. This version has a build number of V
3.10.31.37 and is generally available through a self-update in June 2020.

Update Release 20
-----------------

### Bug fixes

**Time and Expense**

The following issues have been fixed:

-   When hosting the **Time Entry Grid Control** in Dashboards, the grid does
    not consume the full width of the dashboard grid container.

-   For specific time zones, the time entry grid control does not display
    records.

-   Time entries after 9 pm show on the wrong day.

-   Users are unable to submit expenses if expense category - expense receipt
    required has no value

**Resource Management**

The following issues have been fixed:

-   Inactive bookings are displayed in the reconciliation view.

-   Generic resource fulfillment was missing validation to ensure that a valid
    booking status exists.

**Project Management**

The following issues have been fixed:

-   Project form grids (Resource Assignment, task, reconciliation view, expense
    estimates) remain editable even when a project is inactive.

-   Duplicate customers cannot be merged with the customers are linked to
    confirmed project contracts.

-   When adding a resource who does not have a valid calendar, the system does
    not return a user friendly error message.

-   Add task button on task grid is enabled when the project is linked to MS
    Project add-in.

-   Efforts grows uncontrollably when a task with a category is assigned to a
    resource with a role for which there is a cost price defined.

**Sales**

The following enhancements have been made:

-   Invoice Frequency and Billing Start has been moved to the Invoice Schedule
    tab.

The following issues have been fixed:

-   Total Sales Price is 0 for category even though Role has non zero Total
    Sales Price.

-   Customers cannot change the value of the field Invoice Status to “Ready for
    invoicing” when having another customized process updating an additional
    field.

-   "Refresh Invoice Lines" button can trigger multiple times if clicked
    repeatedly causing duplicated lines created.

-   Update Prices button doesn't work on Role Prices sub-grid in quick view
    form.

-   **Sales Price List resolution** logic improperly handles timezones,
    resulting in the incorrect price list selection.

-   A Project’s **Total Actual Cost** can be off by a small fractional amount
    after approving a single time entry.

-   Price Resolution logic does not throw a user friendly error message if
    **retrieved RolePrice** doesn't have values in **'Primary Unit'** and
    **'Price In Primary Unit'** fields
