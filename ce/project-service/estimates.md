---
title: Estimations
description: This topic provides information about estimations for Dynamics 365 for Project Service Automation (PSA). 
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 1/31/2019
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

# Estimations

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

On a project-based quote, you can use the Quote line detail entity in Microsoft Dynamics 365 for Project Service Automation (PSA) to estimate the work that is required to deliver a project. You can then share that estimation with the customer.

Project-based quote lines don't have to have any quote line details. Alternatively, they can have many quote line details. Quote line details are used to estimate time, expenses, or fees. PSA doesn't allow for material estimation on quote line details. These classifications are called transaction classes. Estimated tax amounts can also be entered on a transaction class.

In addition to transaction classes, quote line details have a transaction type. PSA support two transaction types for quote line details: **Cost** and **Project Contract**.

- **Top-down estimation** – The top-down estimation method is used when an estimator must quickly size a deal without including a high level of detail. A top-down estimate is typically done by salespeople, the delivery manager, or both, when there isn't enough time to build a detailed estimation. When work is estimated by using the Quote line detail entity, PSA can enter a default bill rate and sales amount for each quote line detail. The sales amounts on all quote line details for a quote line add up to the quote line value. All quote line values add up to the quote value.
- **Bottom-up estimation** – If your organization has a project plan template for the type of work that is required, you can create a project from a quote line, and the project is based on the template. A project plan is created, and a project estimation is created based on that plan. You can then import the estimates to a quote line as quote line details. The bottom-up method is typically used when project-based companies are familiar with the work that they are quoting and have successfully done it many times before. By using project templates to create projects and generate project-based estimates that are reflected in the quote, you can reuse information, based on experience or best practices.

## Estimation by using a contract

If you used a PSA quote when you created a project-based contract, the estimation that you did for each quote line on the quote is copied to the project contract. The structure of a project contract is like the structure of project quote that has lines, line details, and invoice schedules.

Estimation can be done directly in a project contract, as in a project quote. For a project quotation, the estimation is done by using contract lines and contract line details. Contract line details can also be generated from a project plan that was created by using the bottom-up estimation approach.

Contract line details can be used to estimate time, expenses, or fees. Estimated tax amounts can also be entered on a contract line detail. In addition to transaction classes, a contract line detail also has a transaction type. In the context of quote line details, the transaction types that PSA supports are **Cost** and **Project Contract**.

PSA doesn't allow for material estimation on contract line details.

The processes that are supported on a project contract are invoice creation and confirmation. Invoice creation creates a draft of a project-based invoice that includes all unbilled sales actuals until the current date.

Confirmation makes the contract read-only and changes its status from **Draft** to **Confirmed**. After you take this action, you can't undo it. Because this action is permanent, it's a best practice to keep the contract in a **Draft** status.

The only differences between draft contracts and confirmed contracts are their status and the fact that draft contracts can be edited whereas confirmed contracts can't. Invoice creation and actuals tracked can be done on both draft contracts and confirmed contracts.

PSA doesn't support change orders on contracts or projects.

## Estimating projects

You can estimate time and expenses on projects. PSA doesn't allow for estimation of materials or fees on projects.

Time estimates are generated when you create a task and identify the attributes of a generic resource that is required to perform the task. Time estimates are generated from schedule tasks. Time estimates aren't created if you create generic team members outside the context of the schedule.

Expense estimates are entered in the grid on the **Estimates** page.

## Understanding estimation

Use the following table as a guide to understand the business logic in the estimation phase.

| Scenario | Entity record | Transaction type | Transaction class | Additional information |
|----------|---------------|------------------|-------------------|------------------------|
| You must estimate the sales value of time on a quote. | A quote line detail record is created. | Project Contract | Time | The **Transaction origin** field on the sales-side quote line detail row references the cost-side quote line detail. |
| The system creates a second quote line detail record to store the corresponding cost values. The system copies all non-money fields from the sales-side quote line detail to the cost-side quote line detail. | Cost | Time | | |
| You must estimate the sales value of time on a contract. | A project contract line detail record is created. | Project Contract | Time | The **Transaction origin** field on the sales-side contract line detail row references the cost-side contract line detail. |
| | The system creates a second contract line detail record to store the corresponding cost values. The system copies all non-money fields are copied from the sales-side contract line detail to the cost-side contract line detail. | Cost | Time | |
| The user describes a resource on a project task. | When a task is created that has all the required pricing dimensions, an estimate line record is created that shows the sales value of the task. Role and organizational units are the out-of-box PSA pricing dimensions. | Project Contract | Time | |
| When a task is created that has all the required pricing dimensions, an estimate line record is created that shows the cost value of the task. The system copies all non-money fields from the sales estimate line to the cost estimate line. Role and organizational unit are the out-of-box PSA pricing dimensions for both cost and bill rates. | Cost | Time | | |

## Customizing the Quote line detail and Contract line detail entities

If you added a custom field on the quote line detail and want the system to enter the value of the field as a default value on the related cost line that it creates, use the PreOperationContractLineDetailUpdate and PreOperationQuoteLineDetailUpdate plug-in registration tools. These plug-ins must be re-registered after the quote line detail or the contract line detail is changed. Follow these steps to complete the process.

1. Open PluginRegistrationTool, and connect to your online instance.
2. Select **Search**, and search for the plug-in to update.

    ![Search Tree dialog box](media/basic-guide-19.png)

3. Select the plug-in, and then, on the main page, select **Select**.
4. Select the step of the plug-in to update, right-click, and then select **Update**.

    ![Selecting a step in the plug-in](media/basic-guide-20.png)

5. In the **Update Existing Step** dialog box, in the **Filtering Attributes** field, select the ellipsis button (**...**):
 
    ![Update Existing Step dialog box](media/basic-guide-21.png)

6. In the **Select Attributes** dialog box, select check boxes for custom attributes.

    ![Select Attributes dialog box](media/basic-guide-22.png)

7. Select **OK** to close the dialog box, and then select **Update Step**.
 
    ![Update Step button](media/basic-guide-23.png)

8. Repeat steps 1 through 7 for the second plug-in.
9. Close the PluginRegistrationTool.
