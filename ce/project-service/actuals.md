---
title: Actuals
description: This topic provides information about actuals in Dynamics 365 for Project Service Automation (PSA). 
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/06/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Actuals

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Actuals are the amount of work that has been completed on a project. In Microsoft Dynamics 365 for Project Service Automation (PSA), project actuals can be traced back to their source documents. Those source documents include time, expense, and journal entries, and also invoices.

> ![How project actuals are traced to source documents](media/basic-guide-18.png)

## Submitting a time entry
In PSA, when a time entry is submitted for a project that is mapped to a time-and-materials contract line, two journal lines are created. One line is for cost, and the other line is for unbilled sales. When a time entry is submitted for a project that is mapped to a fixed-price contract line, a journal line is created only for cost. 

Logic for entering default prices resides on the journal line. All the field values from a time entry are copied to the journal line. These fields include the date of the transaction, the contract line that the project is mapped to, and the currency result in the appropriate price list. 

The fields that affect default prices, such as **Role** and **Org Unit**, cause an appropriate price to be entered by default on the journal line. If you add a custom field on the time entry, and you want the field value to be propagated to actuals, create the field on the Actuals entity, and use field mappings to copy the field from the time entry to the actual.

## Submitting an expense entry

In PSA, when an expense entry is submitted for a project that is mapped to a time-and-materials contract line, two journal lines are created. One line is for cost, and the other line is for unbilled sales. When an expense entry is submitted for a project that is mapped to a fixed-price contract line, a journal line is created only for cost.

Logic for entering default prices for expenses is based on the expense category that is selected on the **Expense entry** page. The transaction date, the contract line that the project is mapped to, and the currency are all used to determine the appropriate price list. However, for the price itself, the amount that the user entered is set directly on the related expense journal lines for cost and sales by default.

In the current version of PSA, category-based entry of per-unit default prices on expense entries isn't available.

## Using journals to record costs

In PSA, journals let you record cost or revenue in the material, fee, time, expense, or tax transaction classes. A journal has a header, lines, and a **Confirm** action. Here are some scenarios where you might use a journal:

- You must record material actual costs and sales on a project.
- You must move transaction actuals from another system to PSA.
- You must record costs that occurred in another system, such as procurement or subcontracting costs.

## Invoicing

PSA isn’t designed to be used to invoice customers, because it lacks the following features:

- Tax information
- Amounts in other currencies that are converted to the invoicing currency by using correctly configured exchange rates
- The ability to correctly format an invoice for printing

Instead, you should use a financial or accounting system to create a customer-facing invoice that is based on the information from an invoice proposal that is generated in PSA.

Although PSA invoices are intended for customers, they are useful as a second level of approval for sales values that are ready for an actual invoice to the customer. The first level of approval occurs during the approval of time and expense entries. 

A PSA invoice is created from a contract or by using an unattended workflow job. Follow these steps to configure an unattended periodic invoice run.

1. Set up invoice schedules on all active contracts.
2. Go to **Project Service** \> **Settings** \> **Batch jobs**.
3. Create a batch job and name it **PSA Create Invoices**. The batch job name must include the term "Create Invoices". 
4. Set the **Job type** to **None**. By default, the **Frequency Daily** and **Is Active** options will be set to **Yes** .
5. On the new batch job, select **Run Workflow**. In the **Look Up Record** dialog box, you will see the following three workflows:

  - ProcessRunCaller
  - ProcessRunner
  - UpdateRoleUtilization

> ![Look Up Record dialog box](media/basic-guide-24.png)
 
6. Select **ProcessRunCaller**, and then select **Add**. In the next dialog box, select **OK**. A **Sleep** workflow is followed by a **Process** workflow. You can also select **ProcessRunner** and then select **OK**. In this case, a **Process** workflow is followed by a **Sleep** workflow.

### Backgroun information about the batch jobs
**ProcessRunCaller** and **ProcessRunner** are the workflows that create invoices. **ProcessRunCaller** calls **ProcessRunner**, which actually creates the invoice. **ProcessRunner** looks at the invoice run dates for contract lines and determines all the contract lines in the system that are due for invoice creation on that day. It then creates the invoices. If contract lines that belong to one contract have invoice run dates that fall on the same day, **ProcessRunner** combines the transactions into one invoice that has two invoice lines. If there are no transactions to create invoices for, **ProcessRunner** skips invoice creation.

After **ProcessRunner** has finished running, it calls **ProcessRunCaller** and specifies the end time. It then closes. **ProcessRunCaller** then starts a timer that runs for 24 hours from the specified end time. At the end of the time, **ProcessRunCaller** closes.

The batch process for creating invoices is a recurrent job. If this batch process is run many times, multiple instances of the job are created and cause errors. Therefore, you should start it only one time. You must restart the job only if it stops running.
 
### Making adjustments on a draft PSA invoice

When you create a draft project invoice, all unbilled sales transactions that were created when the time and expense entries were approved are pulled into the invoice. You can make the following adjustments:

- You can delete or edit invoice line details from a draft invoice. 
- The quantity and prices on an invoice line detail are copied from the related unbilled sales actual. You can edit and adjust the quantity and billing type while the invoice is still in a draft stage.
- You can add time, expense, and fees directly to a draft invoice as transactions. You can use this feature if the invoice line is mapped to a contract line that allows for these transaction classes.

Select **Confirm** to confirm an invoice. This action is a one-way action that makes the invoice read-only and creates billed sales actuals from each invoice line detail for each invoice line. If the invoice line detail referenced an unbilled sales actual (for example, if the invoice line detail was created from a time or expense entry), the system also reverses the unbilled sales actual. General ledger integration systems can use this reversal to reverse project work in progress (WIP) for accounting purposes.

### Making adjustments on a confirmed PSA invoice

You can correct confirmed PSA invoices. In this case, a new draft invoice is created that includes all the transactions from the original invoice. Because the assumption is that you want to reverse all transactions and quantities from the original invoice, you will see that the quantities on the draft invoice are 0 (zero). You can remove any transactions that don't require corrections from the draft corrective invoice. If you want to reverse or return only a partial quantity, you can edit the **Quantity** field on the correction invoice line detail. By opening the invoice line detail, you can see the original invoice quantity. You can also edit the current invoice quantity so that it's less than or more than the original invoice quantity.

When you confirm a corrective invoice, the original billed sales actual is reversed, and a new billed sales actual is created.

If you reduced the quantity, the difference will cause a new unbilled sales actual to be created. For example, if the original billed sales was for eight hours and the corrective invoice line detail has a reduced quantity of six hours, PSA will reverse the original billed sales line and create two new actuals:

- A billed sales actual for six hours.
- An unbilled sales actual for the remaining two hours. This transaction can then be billed later or marked non-chargeable, as negotiated with the customer.
