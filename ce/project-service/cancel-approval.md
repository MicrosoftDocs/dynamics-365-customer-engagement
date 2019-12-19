---
title: Cancel previously approved time and expense entries
description: This topic provides information about how to cancel an approved project time and expense transaction.
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


<!--from editor: The metadata entry for "ms.technology" still refers to Customer Engagement. What should that be updated to? -->



# Cancel previously approved time or expense entries

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

In the latest version of Dynamics 365 Project Service Automation, approvers can cancel time or expense entries that they previously approved.

## Cancel a previously approved time or expense entry

Follow these steps to cancel a time or expense entry that you previously approved.

1. Go to **Projects** \> **My Work** \> **Approvals**.
2. On the **Approvals** list page, change the view to **My past approvals**. A list of the time and expense entries that you previously approved is shown.
3. Select one or more entries, and then select **Cancel approval**. You receive a warning message.
4. Select **OK** to cancel the approval.

## Understand the impact of canceling a time or expense entry approval

When an approval is canceled, there is both operational impact and financial impact.

### Operational impact

On the operations side, when an approval is canceled, the status of the record is reset to **Draft**, and the approval no longer appears in the **My past approvals** view. Instead, the canceled approval appears in either the **Time entries for approval** view or the **Expense entries for approval** view, depending on whether it was a time entry or an expense entry. Additionally, the status of the related time or expense entry is changed to **Submitted**, so that the related entry is consistent with approvals that have a status of **Draft**.

As an approver, you can edit some of the fields of an approval that has a status of **Draft**. These fields include **Billing Type** and **Billable Hours for Time Entries**. After you make changes, you can approve the record again. Alternatively, you can reject the entry. If you reject the approval of a time entry, the status of the entry is changed to **Returned**. If you reject the approval of an expense entry, the status is changed to **Rejected**. Functionally, both returned and rejected entries behave the same as an entry that has a status of **Draft**. A project team member can either make any required changes to the entry and then resubmit it for approval, or delete the entry entirely.

### Financial impact

A project is also affected financially when an approval is canceled. First, the corresponding actuals for cost and sales are updated in the following manner:

- The adjustment status is set to **Adjusted**.
- The billing status is set to **Canceled**.

Next, reversal entries are created in the Actuals table. To create reversal entries, the system copies over the field values from the original actuals. The only values that aren't copied over are the quantity values. These values are reversed instead. Reversed actuals are created for both **Cost** and **Unbilled Sales** actuals. The **Adjustment Status** field on the reversed actuals is set to **Unadjustable**, and the billing status is set to **Canceled**.

After these changes are made, the amount that is recorded as spent on the project and the revenue backlog on the project will longer account for the amounts that these actuals represent.
