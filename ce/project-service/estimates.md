---
title: Estimates
description: This topic provides information about estimates for Project Service Automation (PSA). 
author: rumant
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 2/13/2019
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

# Estimates

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

On a project-based quote, you can use the **Quote line detail** entity in PSA to estimate the work involved in delivering a project and then share that with the customer. Project-based quote lines can have none or many quote line details. Quote line details are used to estimate time, expenses or fees. These details are called transaction classes. Estimated tax amounts can also be entered on a transaction class. In addition to transaction classes, a quote line detail has a transaction type. In the context of quote line detail, PSA supports two transaction types, cost and project contract.

## Estimate using a contract

If you used a PSA quote while creating a project-based contract, the estimate each quote line on the quote is copied to the project contract. The structure of a project contract is like the structure of project quote with lines, line details, and invoice schedules.

If your organization has a project plan template for the type of work required, you can create a project from a quote line based on your template. This creates a project plan and project estimate based on that plan. You can then import these estimates to a quote line as quote line details. This method, called the "bottom-up" method, is typically used when project-based companies are familiar with the work that they are quoting and have done it successfully many times in the past. Just like with a project quote, estimates can be done directly in a project contract using contract lines and contract line details. Contract line details can also be generated from a project plan that was created using the bottom-up estimate approach. 

Contract line details can be used to estimate time, expenses or fees. Estimated tax amounts can also be entered on a contract line detail. In addition to transaction classes, a contract line detail also has a transaction type. 

> [!NOTE]
> PSA doesn’t allow materials estimation on contract line details. 

When an estimator needs to quickly size a deal without a great level of detail, the top-down estimate method is used. A top-down estimate is typically done by sales people, the delivery manager, or both when there isn’t enough time to build a detailed estimate. When estimating work using the quote line detail entity, PSA can default a bill rate and sales amount for each of the quote line details. The sales amounts on all quote line details for a quote line add up to the quote line value. All quote line values add up to the quote value.

The processes supported on a project contract are invoice creation and confirmation. Invoice creation creates a draft of a project-based invoice with all unbilled sales actuals until the current date.

Confirmation makes the contract read-only and changes its status from **Draft** to **Confirmed**. After you take this action, you can’t undo it. Because this action is permanent, it’s a best practice to keep the contract in a **Draft** status. Other than status and the ability to edit, there’s no difference between a draft and a confirmed contract. Invoice creation and tracking actuals can be done on both draft and confirmed contracts. PSA does not support change orders on contracts or projects.


## Estimating projects

Using project templates to create projects and generate project-based estimates to inform the quote is a good way to reuse information based on experience or best practices.

You can estimate time and expenses on projects. PSA doesn’t allow estimates of materials or fees on projects.
Time estimates are generated when you create a task and identify the attributes of a generic resource required to perform the task. Time estimates are generated from schedule tasks. Creating generic team members outside the context of the schedule doesn’t create time estimates.

Expenses estimates are entered on the **Estimates** gridpage.

## Understanding estimation

Use the following table as a guide for understanding the business logic in the estimation phase.

| Scenario                                                                                                                                                                                                                                                                                                                                          | Entity record                                                                                                                                                                                                       | Transaction Type | Transaction Class | Additional information                                                            |
|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------|-------------|-----------------------------------------------------------------------------------|
| When you need to estimate the sales value of time on a quote                                                                                                                                                                                                                                                                                    | Quote line detail (QLD) record is created                                                                                                                                                                               | Project contract | Time        | Transaction origin field on the sales side QLD row references the Cost side QLD |
|                                                                                                                                                                                                                                                                                     | A second QLD record is created by the system to store the corresponding cost values. All non-money fields are copied from the sales QLD to the Cost QLD by the system.                                                                                                                                                                               | Cost | Time        | Transaction origin field on the sales side quote line detail (QLD) row references the Cost side QLD |
| When you need to estimate the sales value of time on a contract                                                                                                                                                                                                                                                                                 | Project contract line detail (CLD) record is created                                                                                                                                                                    | Project Contract | Time        | Transaction origin field on the sales side CLD row references the cost CLD      |
|                                                                                                                                                                                                                                                                                  | A second CLD record is created by the system to store the corresponding cost values. All non-money fields are copied from the sales CLD to the cost CLD by the system.                                                                                                                                                                    | Cost | Time        | Transaction origin field on the sales side CLD row references the cost CLD      |
| When the user describes a resource on a project task                                                                                                                                                                                                                                                                                            | Estimate line record to show the sales value of the task is created when a task is created with all required pricing dimensions. Role and organizational units are the OOB Project Service pricing dimensions | Project Contract | Time        |                                                                                   |
|     | The estimate line record to show the cost value of the task is created when a task is created with all required pricing dimensions. All non-money fields are copied from the sales estimate line to the cost estimate line by the system. Role and organizational unit are the OOB PSA pricing dimensions for both cost and bill rates.                                                                                                                                                                                                                | Cost             | Time           |                                                                                   |

## Customizing the quote line detail and contract line detail entities

If you added a custom field on the quote line detail and would like the system to default the value of the field on to the related cost line that it creates, use the **PreOperationContractLineDetailUpdate** and **PreOperationQuoteLineDetailUpdate** plug-in registration tools. These plug-ins need to be re-registered after a change to the quote line detail or the contract line detail. The following steps provide information on how to complete the process:

1. Open **PluginRegistrationTool** and connect to your online instance.
2. Click **Search** and search for the plug-in you want to update:

> ![Screenshot of updating the plug-in with the Search Tree](media/basic-guide-19.png)

3. Select the plug-in and on the main form, click **Select**.
4. Select the **Step** of the plug-in to be updated, right-click, and then click **Update**.

> ![Example of updating a Step in the plugin](media/basic-guide-20.png)

5. In the **Update Existing Step** dialog select **...** in the **Filtering Attributes** field.
 
> ![Screenshot of the Update Existing Step configuration information](media/basic-guide-21.png)

6. Set check boxes for custom attributes.

> ![Checkbox selection for pricing attributes](media/basic-guide-22.png)

7. Click **OK** to close the form and then click **Update Step**.
 
> ![Update Step button](media/basic-guide-23.png)

8. Repeat steps 1 - 7 for the second plug-in.
9. Close the **PluginRegistrationTool**.
