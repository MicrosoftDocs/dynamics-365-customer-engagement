title: What's new or changed in Project Service Automation Update Release 20, V3
description: This topic lists the features and fixes that are available in
Project Service Automation Update Release 20, V3. author: ruhercul  
manager: kfend ms.service: dynamics-365-projectservice ms.custom:
dyn365-projectservice ms.date: 05/05/2020 ms.topic: article ms.prod: ms.service:
business-applications ms.technology: Microsoft Dynamics 365 Project Service
Automation 3.x ms.author: ruhercul audience: Admin search.audienceType: - admin
- customizer - enduser search.app: - D365CE - D365PS ---

Project Service Automation V3, Update Release 20
================================================

We’re pleased to announce the latest update for the Project Service Automation
application for Dynamics 365. This release includes some important improvements
to quality, performance, and usability. This release is compatible with Dynamics
365 9.x. To update to this release, visit the Admin Center for Dynamics 365
online solutions page to install the update. For more information, see [Install,
update, or remove a preferred
solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for PSA V3,
Update Release 20. This version has a build number of V 3.10.31.23 and is
generally available through a self-update in June 2020.

Update Release 20
-----------------

### Bug fixes

**Time and Expense**

The following issues have been fixed:

-   n/a

**Project Management**

The following issues have been fixed:

-   Importing Project Team Members with allocation method that requires hours
    throws an unclear error message when the specified hours are not greater
    than zero.

-   Users receive the incorrect error when the maximum number of characters have
    been entered into the description field.

-   Microsoft Dynamics 365 Project Service Automation add-in download page
    redirects to the English download page with the user’s language settings are
    in Japanese.

-   On the schedule tab of the Project main form, when a server error occurs,
    the syncing label does not always disappear.

-   Redundant task updates are being sent to the server when a task is modified.

**Sales**

The following issues have been fixed:

-   Double clicking on 'Create Invoice' creates 2 invoices for same a single
    Actuals record.

-   In Internet Explorer 11, user are unable to create expense entries.

-   Reversal of Cost and reversal of Unbilled Sales Actuals are not linked.

-   "Refresh Actuals" button on the project form does not refresh Task Actual
    Hours.

-   The PreValidateProjectTeamMemberCreate plugin can create duplicate generic
    bookable resources when the attribute msdyn_isgenericresourceprojectscoped
    is set to false.

-   Recalculate clears chargeable costs of product based quote line details/
    contract line details.

-   In specific scenarios, the PostEstimateLineUpdate plugin throws a Null
    Reference Exception

-   Time phase duration on profitability analysis chart does not match duration
    of the costs in the fixed price quote line detail of the quote.

-   Unit and unit group defaulting on a Contract Line Details and Quote Line
    Details for for expense categories are incorrectly defaulted.

-   Org unit cost price lists permit date effectivity overlaps.

-   Handling Null ref when Validating OrgUnit updates

-   When attempting to navigate from the quote line detail form back to the
    quote tab, the form refreshes and displays the summary tab.
