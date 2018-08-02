---
title: "Dynamics 365 Process categories (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Processes enable you to model real-life business processes, for example best practices or standard practices, in Dynamics 365 Customer Engagement. When modeling your business practices, you can choose from four categories of processes: Workflow, Action, Business Process Flow, and Dialog."
ms.custom: ""
ms.date: 12/16/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8c19b218-311b-42bc-be37-c91e07c01661
caps.latest.revision: 41
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Process categories

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Processes enable you to model real-life business processes, for example best practices or standard practices, in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement. When modeling your business practices, you can choose from four categories of processes:  

- **Workflow**. Use this process to model and automate real world business processes. These processes can be configured to run in the background or in real time and can optionally require user input. Workflow processes can start automatically based on specified conditions or can be started manually by a user.  

- **Action**. Use this process to create a new operation that is not available in a standard [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] installation or to combine multiple disparate operations into a single operation. For example, in the case of a support call center, you could combine `create`, `assign`, and `setstate` operations into a single new “escalate” operation.  

- **Business process flow**. Use this process to create a visualization of the business process flow. Users are guided through various stages of the sales or customer service processes. At each stage, you complete specific steps and then move to the next stage.  You can customize the process flow by adding or removing steps, changing the order of the stages, or adding new entities to the process flow.  

- **Dialog**. Use this process to create an  interactive step-by-step data entry form that requires user input to start and run to completion. When you start the dialog process, a wizard-like interface is presented so you can make appropriate selections or enter data as you progress through each page of the wizard.  

The processes’ capability is implemented using [Windows Workflow Foundation](https://msdn.microsoft.com/vstudio/jj684582.aspx). The latest version of [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] has improved to facilitate easier creation, running, and maintenance of workflows to implement custom functionalities in your application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [What's New in Windows Workflow Foundation](https://msdn.microsoft.com/library/dd489410.aspx)  

There are three ways to create business processes: interactively through the web application forms and the workflow designer, by writing code that uses workflow related classes, and by importing a pre-made workflow in a solution. Because the SDK is developer-focused, we are covering the coding aspect of creating workflow processes.  

<a name="XAMLWorkflows"></a>

## XAML (Declarative) workflows

You can create XAML workflows for on-premises [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], which you visually design and create by using the [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] Workflow Designer. This method of creating workflows does not require that you write code. Moreover, you do not have to compile these workflows, and can import the workflow definition (XAML) into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. In addition to creating new workflows, you can also use the [!INCLUDE[pn_Visual_Studio](../includes/pn-visual-studio.md)] Workflow Designer to visually modify existing workflows in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], and then import the updated workflow into [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  

[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]
> [!NOTE]
>  You cannot view or update a workflow definition for a workflow that was created or modified outside of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. You can only change the state (activate or deactivate) of the workflow, and run it. XAML workflows aren’t supported in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  

<a name="bkmk_differences"></a>

## Differences between workflows and dialogs

The following table provides information about the differences between workflows and dialogs in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)].  


|                                                                                                                        Workflows                                                                                                                        |                                                                                                   Dialogs                                                                                                    |
|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                                                                                  Can be either started by a user or can be automated.                                                                                                   |                                                                                          Must be started by a user.                                                                                          |
|                                  Are asynchronous or real-time processes, and do not require user input to run to completion. Asynchronous processes run in the background while real-time processes run immediately.                                   | Are real-time processes that require user input to run to completion. When you run these processes, a wizard-like interface is presented to you so you can make appropriate selections to run the processes. |
|                                                    The entity that stores the details about a running asynchronous workflow is `AsyncOperation` while a `Process` is used for a real-time workflow.                                                     |                                                       The entity that stores information generated by a running dialog is the `ProcessSession` entity.                                                       |
|                  Triggers are supported for workflows. For a list of supported triggers, see [Supported Types, Triggers, and Entities for Processes (Workflows and Dialogs)](supported-types-triggers-entities-actions-processes.md).                   |                                                                                   Triggers are not supported for dialogs.                                                                                    |
| Workflows that are created or updated outside of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] by creating or updating the underlying XAML file are supported in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] on-premises. |                                       There is no support for created dialogs outside of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] by defining XAML.                                       |

<a name="bkmk_whentouse"></a>

## When to use a workflow instead of a plug-in

Most operations that can be accomplished by using workflows can also be accomplished by using plug-ins. However, you should use workflow processes instead of plug-ins when:  

- Changes in the business logic must be performed by people who are not developers, or the changes should not be dependent on the availability of a developer to do the work. When custom workflow activities are defined as Workflow .NET assemblies, a person who is not a developer can use [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] to define the conditions when the custom actions are performed and the parameters that will be passed to the assembly.  

- You need the ability to let users apply your workflow logic manually. With workflow processes, users can trigger the processing of workflow rules by clicking **Run Workflow** on the form or from a grid.  

Use plug-ins when you need the best performance possible from your custom business logic. Plug-ins can start quicker and therefore typically run faster that even a real-time workflow. However, the benefit in performance may be outweighed by the ease of use in creating and maintaining workflows where only a non-developer, for example a business analyst, is required to do the work.  

For more information about plug-ins, see [Write plug-ins to extend business processes](write-plugin-extend-business-processes.md).  

## Distributing workflows in solutions

You can include workflows and custom workflow activities in a solution that is imported into another [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] deployment. However, if you refer to specific entity instances in a workflow and the workflow is moved into another system, problems will arise because the unique IDs of the entity instances in the workflow will differ from those in the target system.  Dynamics 365 automatically resolves system user and currency entity records based on the full name property, but it won't automatically resolve records for other entity types.  

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Package and Distribute Extensions with Dynamics 365 Solutions](package-distribute-extensions-use-solutions.md).  

### See also

[Automate your business processes in Customer Engagement](automate-business-processes-customer-engagement.md)
