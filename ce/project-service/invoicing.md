# Invoicing in PSA

PSA invoice is useful as a second level of approval by Project Managers before generating a customer-facing invoice. The first level of approval is done when time and expense entries are submitted by Project team members .
PSA isn’t designed for creating a customer facing invoice because it lacks the following:

- Tax information
- Amounts in other currencies converted to invoicing currency using properly-configured exchange rates
- The ability to properly format an invoice for printing

Use a financial or accounting system to create a customer-facing invoice using the information from an invoice proposal generated in PSA.

## Creating Project Invoices in PSA
Project invoice can be created one or one or in bulk and invoice creation can be manually or configured for automated runs.

### Manual creation of Project Invoices in PSA
Project Invoices can be created one by one for each Project Contract or in bulk from the Project Contracts list page.

For bulk creation, from the Project Contracts list page, you can select one or more project contracts. Then click on "Create Invoice Select all the project contracts for which you need to create an invoice.
There is a warning message indicating that there could be a delay in creating invoices and the process. Click ok on the warning message. Invoice creation proceeds in the background and picks up all transactions that are in the status "ready to invoice" for each project contract. This includes time, expense, milestones and product-based contract lines.  Navigate to Sales->Billing->Invoices to see the invoices that were created. There will be one invoice created for each project contract


For creating invoices one by one for each project contract, navigate to the project contract list page, open a project contract and click on "Create invoice". Invoice creation proceeds in the background and picks up all transactions that are in the status "ready to invoice" for the specific project contract. This includes time, expense, milestones and product-based contract lines. 

### Automated creation of Project Invoices in PSA 
Use the following steps to configure an unattended periodic invoice run in PSA.

1. Set up invoice schedules on all active contracts.
2. Go to **Project Service** > **Settings** > **Batch jobs**.
3. Create a new batch job and name it “PSA Create Invoices”. The batch job name must include the term **Create Invoices**. 
4. Set the **Job type** to **None**, and the **frequency Daily** and **Is Active** will default to **Yes** .
5. Click **Run Workflow**. You will see the following three workflows in the **Look Up Record** screen:

> ![Screenshot of Look Up Record screen](media/basic-guide-24.png)
 
6. Choose **ProcessRunCaller** and click **Add**. On the next screen, click **OK**. This results in a workflow of **Sleep** followed by **Process**. You could also choose **ProcessRunner** then click **OK**. This results in a workflow of process followed by **Sleep**.

**Background information on the batch jobs**: **ProcessRunCaller** and **ProcessRunner** are the workflows that create invoices. **ProcessRunCaller** calls **ProcessRunner**. **ProcessRunner** does the actual invoice creation by running through all the contract lines in the system that are due for invoice creation that day (it discovers this by looking at invoice run dates for that contract line) and creates the invoices. If contract lines that belong to one contract have invoice run dates that fall on the same day, it combines the transactions into one invoice with two invoice lines. If there are no transactions to create invoices, the job will skip invoice creation.

After is has finished, **ProcessRunner** calls **ProcessRunCaller** with the **End time** and shuts down. **ProcessRunCaller** then starts a timer that runs for 24 hours from that end time. At the end of the time, **ProcessRunCaller** shuts down.

The batch process job for creating invoices is the recurrent job. Running this batch process many times creates multiple instances of the job, which causes errors. For this reason, you only need to start it once and you only need to re-start it if it has stopped running.
 
### Making adjustments on a draft PSA invoice

When you create a draft project invoice, all unbilled sales transactions that were created when the time and expense entries were approved are pulled on to the invoice. You can make the following adjustments to it:

- Invoice line details can be deleted or edited from a draft invoice. 
- The quantity and prices on an invoice line detail are copied from the related unbilled sales actual. The quantity and billing type can be edited and adjusted while the invoice is still in a draft stage.
- A draft invoice also allows time, expense, and fees, to be added directly as transactions on the invoice. You can use this feature if the invoice line maps to a contract line that allows these transaction classes.

Click **Confirm** to confirm an invoice. This is a one-way action and makes the invoice read-only and creates billed sales actuals from each invoice line detail for each invoice line. If the invoice line detail was referencing an unbilled sales actual as it would if it were created from a time or expense entry, the system also reverses the unbilled sales actual. For accounting purposes, this reversal can be used by general ledger integration systems to reverse Project WIP for accounting.

### Making adjustments on a confirmed PSA invoice

Confirmed PSA invoices can be corrected. When you choose to correct a confirmed invoice, a new draft invoice is created with all the transactions from the original invoice with the assumption that you want to reverse all transactions and quantities from the original invoice. The result is that on the draft invoice, you will see that the quantities are zero. Any transactions that do not need corrections can be removed from the draft corrective invoice. If you want to reverse or return only partial quantity, you can edit the quantity field on the correction invoice line detail. If you open the invoice line detail, you can see the original invoice quantity and edit the current invoice quantity to be less or more than the original.

Confirming a corrective invoice will reverse the original billed sales actual and create a new one. 
If the quantity was reduced, the difference will also trigger a new unbilled sales actual to be created. For example, if the original billed sales was for eight hours and the corrective invoice line detail has a reduced quantity of six hours, PSA will reverse the original billed sales line and created two new actuals:

- A billed sales actual for six hours.
- An unbilled sales actual for the remaining two hours. This transaction can then be billed at a later point or can be marked non-chargeable as negotiated with the customer.
