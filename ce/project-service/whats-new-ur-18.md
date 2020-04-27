title: What's new or changed in Project Service Automation Update Release 18, V3
description: This topic lists the features and fixes that are available in
Project Service Automation Update Release 18, V3. author: ruhercul  
manager: kfend ms.service: dynamics-365-projectservice ms.custom:
dyn365-projectservice ms.date: 04/27/2020 ms.topic: article ms.prod: ms.service:
business-applications ms.technology: Microsoft Dynamics 365 Project Service
Automation 3.x ms.author: ruhercul audience: Admin search.audienceType: - admin
- customizer - enduser search.app: - D365CE - D365PS ---

Project Service Automation V3, Update Release 18
================================================

We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability. This release is compatible with Dynamics
365 9.x. To update to this release, visit the Admin Center for Dynamics 365
online, solutions page to install the update. For more information, see
[Install, update, or remove a preferred
solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for PSA V3,
Update Release 18. This version has a build number of V3.10.8.12 and is
generally available through a self-update in April 2020.

Update Release 18
-----------------

### Bug fixes

**General**

**Time and Expense**

-   Fixed: Recall Request & Cancel Approval flows throw exceptions with unclear
    error dialogs.

-   Fixed: When "Cancel Approval" fails for an expense, a relevant exception
    error is not thrown.

-   Fixed: Time Entry grid incorrectly handles non-working days in Australia
    after DST switch in October.

-   Fixed: Incorrect defaulting logic prevents submission of expenses.

-   Fixed: When time entry approval fail, the approval remains in Pending state.

-   Fixed: SQL Errors on bulk approvals (deadlock/timeout).

-   Fixed: User experience significant performance issues caused by unnecessary
    updates to team members while approving time entries.

**Project Management**

-   Fixed: Time zone notification moved from the reconciliation view to the
    project main form.

-   Fixed: Calendar template is not correctly defaulting on load of new project
    form.

-   Fixed: For chromium-based browsers, users are unable to easily select
    predecessor tasks for deletion.

-   Fixed: Creating or copying Project from Empty template fetches unrelated
    assignments

-   Fixed: in specific edge cases, a when creating a new assignment from the
    task grid, duplicate records are created.

-   Fixed: In manual mode, users are unable to update task start dates to be
    later than the current date saved.

**Resource Management**

-   Fixed: Reconciliation view subtotal row incorrectly calculates bookings
    variance after extension of bookings.

-   Fixed: Reconciliation view incorrectly displays resource assignments when
    the bookable resource has a calendar that does not match the project
    calendar.

**Sales**

-   Fixed: When time entries are re-approved (i.e. Approve -\> cancel -\>
    approve again), a duplicate non-chargeable actual is created.
