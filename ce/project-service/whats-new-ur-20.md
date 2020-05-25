---

title: What's new or changed in Project Service Automation Update Release 20, V3
description: This topic lists the features and fixes that are available in Project Service Automation Update Release 20, V3
author: ruhercul                
manager: kfend
ms.service: dynamics-365-projectservice
ms.custom: dyn365-projectservice
ms.date: 05/22/2020
ms.topic: article
ms.prod: 
ms.service: business-applications
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

# Project Service Automation Update Release 20, V3

We’re pleased to announce the latest update for the Project Service Automation application for Dynamics 365. This release includes some important improvements to quality, performance, and usability. This release is compatible with Dynamics 365 9.x. To update to this release, visit the Admin Center for Dynamics 365 online solutions page to install the update. For more information, see [Install, update, or remove a preferred solution](https://docs.microsoft.com/power-platform/admin/install-remove-preferred-solution).

This topic lists the features and fixes that are new or changed for Project Service Automation V3, Update Release 20. This version has a build number of V 3.10.31.23 and is generally available through a self-update in June 2020.

## Update Release 20

### Bug fixes

**Project Management**

The following issues have been fixed:

- Importing project team members with an allocation method that requires hours results in an unclear error message when the specified hours are zero.
- Users receive an incorrect error when the maximum number of characters have been entered into the **Description** field for a project task.
- The **Microsoft Dynamics 365 Project Service Automation add-in download** page redirects to the English download page when the user’s language settings are set to Japanese.
- When a server error occurs, the synchronization label on the **Schedule** tab of the **Projects** form sometimes remains.
- Redundant task updates are being sent to the server when a task is modified.

**Sales**

The following issues have been fixed:

- On the **Contract** form, double-clicking **Create Invoice** creates two invoices for a single actuals record.
- In Internet Explorer 11, users are unable to create expense entries.
- Reversal of Cost and reversal of Unbilled Sales Actuals are not linked.
- The **Refresh Actuals** button on the **Project** form does not refresh **Task Actual Hours**.
- The **PreValidateProjectTeamMemberCreate** plug-in can create duplicate generic bookable resources when the attribute **msdyn_isgenericresourceprojectscoped** is set to **False**.
- **Recalculate** clears chargeable costs of product-based quote line details and contract line details.
- In specific scenarios, the **PostEstimateLineUpdate** plug-in displays a null teference exception error.
- Time phase duration on the **Profitability Analysis Chart** does not match duration of the costs in the fixed-price quote line detail of the quote.
- Unit and unit group values do not default correctly for expense categories on the **Contract Line Details** and **Quote Line Details** forms.
- **Org Unit Cost Price** lists permit overlaps in the date effectivity.
- Users are not permitted to change the **OrgUnit** when the order type is not work-based because it will lead to a null reference exception error.
- When attempting to navigate from the **Quote Line Details** form, back to the **Quote** tab, the form refreshes and displays the **Summary** tab.
