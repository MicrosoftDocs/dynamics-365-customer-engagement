---
title: Create or customize a business process flow
description: Learn to customize business process flows in Sales, ensuring consistent data entry and customer interaction while reducing training costs.
ms.date: 05/30/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - dyn365-sales
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:05/29/2024
---

# Create or customize a business process flow

With Dynamics 365 Sales, you can help ensure that users enter data consistently and follow the same steps every time they work with a customer by creating a business process flow. For example, you might want to create a business process flow to have everyone handle customer service requests the same way, or to require that users get approval for an invoice before submitting an order.  

## How do business process flows help? 

Business process flows use the same underlying technology as other processes, but the capabilities that they provide are very different from other features that use processes.

With business process flows, you define a set of stages and steps that are displayed in a control at the top of a form. Each stage contains a group of steps. Each step represents a field where data can be entered. Users advance to the next stage by using the **Next Stage** button. You can make a step required so that users must enter data for the corresponding field before they can proceed to the next stage. This is called “stage-gating.”

Business process flows appear relatively simple compared to other types of processes. This is because they don't provide any conditional business logic or automation beyond providing a streamlined experience for data entry and controlling entry into stages. However, when you combine them with other processes and customizations, they can play an important role in saving users time, reducing training costs, and increasing user adoption.

## Entities available for business process flow

Entities are sets of records. You can use the following entities to create business process flows in Sales Hub and Sales Professional apps:

| Entity | Supported app |
|--------|---------------|
| Account | Sales Hub and Sales Professional |
| Appointment | Sales Hub |
| Contact | Sales Hub and Sales Professional |
| Email | Sales Hub |
| Invoice | Sales Hub and Sales Professional |
| Lead | Sales Hub and Sales Professional |
| Opportunity | Sales Hub and Sales Professional |
| Phone Call | Sales Hub |
| Product | Sales Hub |
| Quote | Sales Hub and Sales Professional |
| Task | Sales Hub |
| Team | Sales Hub |
| User | Sales Hub |

## Create a business process flow

Depending on the license you have, select one of the following tabs for more information:

# [Sales Premium and Sales Enterprise](#tab/SE)

Follow the instructions in [Create a business process flow](/power-automate/create-business-process-flow?context=/dynamics365/context/sales-context) to create or customize a business process flow.  

# [Sales Professional](#tab/SP)

1. Make sure you have the System Administrator or System Customizer security role or equivalent permissions.  
1. In your sales professional app, in the site map, select **Setup** &gt; **Sales Settings**.  
1. Select **Customization** &gt; **Business Process Flows** and then select **Create New**.  
1. In the **Create New Business Process** pane, enter the following information:  
    - **Name**: A name for your business process flow. The name of the process doesn’t need to be unique, but it should be meaningful for users who need to choose a process. You can change this later.  
    - **Entity**: Choose the entity you want to base the process on. The entity you select affects the fields available for steps that can be added to the first stage of the process flow. You can't change this after you save the process.
1. Select **Launch Designer**.  
    The new process is created, and the business-process flow designer opens with a single stage already created for you. Now, you can start [adding stages to the process](/power-automate/create-business-process-flow#create-a-business-process-flow?context=/dynamics365/context/sales-context).
  
### Edit a business process flow

You can edit existing business process flows, as needed. If your business processes change, or you just want to make minor modifications, you can open the business process flow and change most properties. The following table lists the properties you can change and those you can't.

| Can change | Cannot change |
|------------|---------------|
|- Stages or other components<br>- Properties of existing components<br>- Name<br>- Description|- Entity on which the process flow is based<br>- System name for the business process flow<br>- Owner<br>- Category|

To edit a business process flow:  
1. In your sales professional app, in the site map, select **Setup** &gt; **Sales Settings**.  
1. Select **Customization** &gt; **Business Process Flows** and then select the business process flow you want to edit in the **Process Name** column.

---

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Customize forms](customize-forms.md)  
[Customize views](customize-views.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]

