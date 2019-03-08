---

title: Recall approved time or expense entries
description: This topic provides information about how to recall a previously approved time or expense transaction.
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom:
  - dyn365-projectservice
ms.date: 03/08/2019
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
# Recall approved time or expense entries

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In Dynamics 365 for Project Service Automation (PSA), a project team member or other submitter of a time or expense entry, can recall a previously approved time or expense entry. Recalling an approved time or expense entry is a two-step process:

  1. Submitter requests a recall.
  2. Approver approves the recall.

## Request a recall  
Complete the following steps to request the recall of an approved time or expense entry.

1. Navigate to **Projects** \> **My Work** \> **Time Entry** -or- **Projects** \> **My Work** \> **Expenses**.
2. For time entries, select all of the time entries for a specific project-task combination or the individual cells in the grid for time on a specific date for a specific project. For expense entries, select the row of the expense entry to be recalled. 
3. Click **Recall**. The system will show a confirmation dialog and you will be prompted enter a reason for the recall if the selected time and expense entries were already approved. 
4. Enter a reason for the recall and click **OK** to confirm . The sytem will send a request to the approver of the entries to approve the recall.

> [!NOTE]
> While recalling approved time or expense entries is allowed, if the approved time or expense has already been invoiced to the custoemr, a recall request can't be created. The user trying to create the recall will receive a message that says that the time or expense can't be recalled because it was already invoiced.

## Approve or reject a recall request 
Complete the following steps to approve or reject a recall request.

1. Navigate to **Projects** \> **My Work** \> **Approvals**.
2. From the view picker on the **Approvals** list page, change the view to **Recall requests for approval**. A list of submitted recall requests are shown.
3. Select one or more entries, and click **Approve** or **Reject**.
4. If you click **Approve**, a warning message that explains the impact will be shown. Click **OK** to confirm. The recall request will be approved. 
5. If you click **Reject**, the recall request will be rejected. 

> [!NOTE]
> Just as at the time of requesting the recall, at the time of approving the recall, the system will check for any invoicing activity on the entry. If the entry was already invoiced or is on a draft invoice, the approver will see an error message informing the approver that the time or expense can't be approved for recall since it was already invoiced.

## Impact of a recall request 
When an approval is recalled, there is both operational and financial impact.

### Operational 
If a recall request is approved, the approval record will be marked as **Rejected**. This means that the entry will have it's status modified to **Returned** or **Rejected**, based on whether it's a time or expense entry. 

The project team member can view entries and choose to edit and resubmit, or delete the entry altogether.

If the recall request was rejected, the entry keeps its **Approved** status and can't be edited by the team member of the approver of the Project.   

### Financial 
If a recall request is approved there is financial impact on the project. First, the corresponding actuals for cost and sales are updated in the following way:

- The **Adjustment Status** field is updated to **Adjusted**.
- The **Billing Status** field is updated to **Canceled**.

Next, the system creates reversal entries in the **Actuals** table by copying over all of the field values from the original actuals with the exception of the quantity values, which are reversed. Reversed actuals are created for both the **Cost** and **Unbilled Sales** actuals. The **Adjustment Status** field on the reverse actuals is set to **Unadjustable** and the **Billing status** field is set to **Canceled**. Because of these changes, the recorded spending and the revenue backlog on the project will no longer account for the amounts represented by these actuals.

If a recall request is rejected, there is no financial impact on the project.

## Time entry record changes

The following flow chart shows the changes that occur on approved time entries as they are recalled.

![Time Entry state transitions](media/TimeEntryStateTransitions.png)

### Expense entry record changes

The following flow chart shows the changes that occur on approved expense entries as they are recalled.

![Expense Entry state transitions](media/ExpenseEntryStateTransitions.png)

