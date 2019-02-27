---

title: Cancel approval on project time and expense
description: Process description of how to cancel approval of previously approved project time and expense transactions
author: Rupa Mantravadi
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 2/25/2018
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
# Cancel approval of previously approved time and expense entries

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In the latest version PSA, an approver has the option to cancel thier approval on a previously approved time or expense entry. 
  
## Cancelling an previously approved time or expense entry
1. To cancel a previously approved time or expense entry, navigate to Projects -> My Work -> Approvals
2. From the view picker on the Approvals list page, change the view to "My past approvals". A list of previously approved time and expense entries will be shown.
3. Select one or more entries and click on the ribbon action for "Cancel approval"
4. A warning message explaining the impact will be shown. Click ok to confirm.
5. The approval will be cancelled.

## Understand the impact of cancelling the approval on project time or expense entry

### Operational Impact:

The approval record will come back into draft status. This means that depending on whether the cancelled approval was time or expense entry, the approval will no longer be in the view for "My past approvals" and instead will be shown under "Time entries for approval" or "Expense entries for approval" view. The related time or expense entry will also have its status modified to "Submitted" to be consistent with an Approval in "draft" status
As an approver, you can edit fields that are editable for approvals in draft status. This includes fields such as Billing Type, Billable hours for Time entries. Once the required edits are in, you may choose to approve the record again. 
Alternatively, you also have the option of rejecting the entry. Rejecting the approval of a time entry will put the Time entry in Returned status and Rejecting the approval of an Expense entry will put the Expense entry in "Rejected" status. Semantically both Returned and Rejected entries behave has draft entries would. So the project team member will be able to make the required edit and resubmit or delete the entry entirely.  

### Financial Impact:
When an approval is cancelled, there is financial impact on the project. 
Fristly the corresponding actuals for cost and sales are updated in the following way:

1. The Adjustment status is set to "Adjusted"
2. The billing status is set to "Cancelled"

Secondly, the system created reversal entries in the Actuals table by copying over all the field values from the original actuals with the exception of quantity values that are reversed  the sign. These reversing actuals are created for both Cost and Unbilled Sales actuals. The adjustment status field on these reverse Actuals is set to "Unadjustable" and the Billing status is set to Cancelled

Due to the above changes, the spend recorded on the project and the revenue backlog on the project will no longer account for the amounts represented by these actuals.
