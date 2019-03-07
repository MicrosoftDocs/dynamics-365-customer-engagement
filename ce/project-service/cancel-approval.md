---
title: Cancel previously approved time and expense entries
description: This topic provides information about how to cancel an approved project time and expense transaction in Microsoft Dynamics 365 for Project Service Automation.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 03/07/2019
ms.topic: article
ms.prod: 
ms.service: business-applications
ms.technology: Microsoft Dynamics 365 for Customer Engagement for Project Service 2.x and Microsoft Dynamics 365 for Customer Engagement for Project Service 3.x
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Cancel previously approved time or expense entries

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In the latest version Dynamics 365 for Project Service Automation (PSA), an approver has the option to cancel a time or expense entry that they previously approved.
  
## Cancel a previously approved time or expense entry
Complete the following steps to cancel a previously approved time or expense entry.

1. Navigate to **Projects** \> **My Work** \> **Approvals**.
2. From the view picker on the **Approvals** list page, change the view to **My past approvals**. A list of previously approved time and expense entries will be shown.
3. Select one or more entries, and then click **Cancel approval**.
4. A warning message will open. Click **OK** to cancel the approval.

## Understand the impact of canceling a time or expense entry approval

When an approval is canceled, there is both operational and financial impact. 

On the operations side, the status of the record will be reset to **Draft** and the approval will no longer be available in the **My past approvals** view. Instead, depending on whether the canceled approval was a time or expense entry, the approval will be in the **Time entries for approval** view or the **Expense entries for approval** view. The related time or expense entry will also have its status modified to **Submitted** to be consistent with approvals that are in a **Draft** status.

When an approval has a status of **Draft**, as an approver you can edit some of the fields, including **Billing Type** and **Billable Hours for Time Entries**. After you have made changes, you can choose to approve the record again. 
Alternatively, you also have the option of rejecting the entry. Rejecting the approval of a time entry will change the status of the entry to **Returned** and rejecting the approval of an expense entry will change the status to **Rejected**. Semantically, both returned and rejected entries behave the same as an entry with a status of **Draft**. If necessary, the project team member can make required changes to the entry and resubmit for appoval, or delete the entry entirely.  

A project is also impacted financially when an approval is canceled. To start, the corresponding actuals for cost and sales are updated in the following way:

- The **Adjustment** status is set to **Adjusted**.
- The **Billing** status is set to **Cancelled**.

Next, the system creates reversal entries in the **Actuals** table by copying the field values from the original actuals, minus the quantity values which are reversed. These reversed actuals are created for both **Cost** and **Unbilled Sales** actuals. The **Adjustment Status** field on the reverse actuals is set to **Unadjustable** and the billing status is set to **Cancelled**.

After these changes, the amount recorded as spent on the project and the revenue backlog on the project will no longer account for the amounts represented by these actuals.
