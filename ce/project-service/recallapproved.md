---

title: Recall an approved time or expense entry
description: Process description of how to recall a previously approved project time and expense transactions
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
# Recall a previously approved time or expense entry

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In the latest version PSA, a project team member or the submitter has the option to recall a previously approved time or expense entry. Recalling an approved time or expense entry is a 2-step process.

a. Submitter must request a recall
b. Approver must approve the recall

## Requesting the recall of a previously approved time or expense entry 
1. To recall a previously approved time or expense entry, navigate to Projects -> My Work -> Time Entry or to Projects -> My Work -> Expenses 
2. For time entries, select one or more rows to select all time entries for a specific project-task combination or  or individual cells in the grid for time on a specific date for a specific project task combination. For expense entries each row in the grid represents a expense. 
3. Once you have selected, click the button "Recall". The system will show a confirmation dialog and prompts to enter a reason for recall if the selected time and expense entries were already approved. 
4. Enter a reason for recall and Click ok to confirm the recall process.
5. The sytem will trigger a request to the approver of these entires to approve the recall.
---
**Note: Recall of approved time or expense entries is allowed however, if the approved time or expense has already been invoiced to the custoemr, then recall request is not created and the recaller is shown a message saying that the time or expense cannot be recalled since it was already invoiced. 

## Approving or Rejecting the recall request of an approved time or expense entry
1. To access Recall requests as an approver, navigate to Projects -> My Work -> Approvals
2. From the view picker on the Approvals list page, change the view to "Recall requests for approval". A list of recall requests submitted will be shown.
3. Select one or more entries and click on the ribbon action for "Approve" or "Reject"
4. If you clicked on "approve",  A warning message explaining the impact will be shown. Click ok to confirm. The recall request will be approved. 
5. If you clicked on "reject", the recall request will be rejected. 

**Note: Just as at the time of requesting the recall, at the time of approving the recall, the system will check for any invoicing activity on the entry. If the entry was already invoiced or is on a draft invoice, the approver will see an error message informing the approver that the time or expense cannot be approved for recall since it was already invoiced. 

## Understand the impact of approving or rejecting a recall request 

### Operational Impact:

If the recall request is approved, the approval record will be marked as Rejected. This means that depending on whether it was for a time or expense entry, the entry will also have its status modified to "Returned" or "Rejected". These states have the same semantic meaning.
The project team member will be able see these entries in thier Time or Expense entries view in an editable state. At this point they have the option to either edit and resubmit or delete the entry altogether.

If the recall request was rejected, then the time or expense entry retains its "Approved" status and cannot be edited by either the Team Member or the Approver on the Project.   

### Financial Impact:
If a recall request is approved and the time or expense entry becomes editable, there is financial impact on the project. 
Fristly the corresponding actuals for cost and sales are updated in the following way:

1. The Adjustment status is set to "Adjusted"
2. The billing status is set to "Cancelled"

Secondly, the system created reversal entries in the Actuals table by copying over all the field values from the original actuals with the exception of quantity values that are reversed  the sign. These reversing actuals are created for both Cost and Unbilled Sales actuals. The adjustment status field on these reverse Actuals is set to "Unadjustable" and the Billing status is set to Cancelled

Due to the above changes, the spend recorded on the project and the revenue backlog on the project will no longer account for the amounts represented by these actuals.

If a recall request is rejected  there is no financial impact on the project.

