---
title: "Dynamics 365 Customer Engagement Process architecture (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The topic illustrates the high-level system architecture for Dynamics 365 Customer Engagement (on-premises), and highlights parts of the system that are specific to processes."
ms.custom: 
ms.date: 12/16/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 8150b437-8c14-4668-910d-2910ba16b503
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Process architecture

The process management system in Dynamics 365 Customer Engagement (on-premises) includes the [!INCLUDE[cc-dyn365-ce-web-services](../includes/cc-dyn365-ce-web-services.md)], plug-ins, forms, and other components.  
  
<a name="Diagram"></a>

## Process architecture diagram

The following diagram illustrates the high-level system architecture for Dynamics 365 Customer Engagement (on-premises), and highlights parts of the system that are specific to processes.  
  
![Process Architecture](media/process-architecture.png "Process Architecture")  
  
This diagram shows the process architecture of Dynamics 365 Customer Engagement (on-premises) including the internal components, the external components, the infrastructure, and the data.  
  
**Internal Components**. The internal components that support the Dynamics 365 Customer Engagement (on-premises) process programming model include Web services, shared platform, and business logic. The shared platform consists of common Dynamics 365 Customer Engagement (on-premises) components that provide registration, metadata cache, and data access services. Business logic contains the implementation of business logic for Dynamics 365 Customer Engagement (on-premises) business entities.  
  
**External Components**. The external components are as follows:  
  
- [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] object model, which contains a set of classes used to create and parse workflow process definitions in XAML format.  
  
- [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] execution, which contains a set of classes used to execute workflow processes.  
  
**Process Infrastructure**. The Dynamics 365 Customer Engagement (on-premises) process infrastructure consists of the following components:  
  
- Process entity model, which contains a set of classes that use the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] object model and expose Dynamics 365 Customer Engagement (on-premises) workflow activities.  
  
- Process business logic, which implements business logic for process-specific entities.  
  
- Process execution, which provides workflow execution services, such as workflow hosting and persistence.  
  
**Process Data**. The Dynamics 365 Customer Engagement (on-premises) process programming model is supported by the following data:  
  
- Business data, which contains information associated with Dynamics 365 Customer Engagement (on-premises) entities.  
  
- Process configuration data, which includes workflow process definitions, compiled workflow processes, and workflow process settings.  
  
- Process runtime data, which is required to execute workflow processes and implement workflow process features, such as persistence and notifications.  
  
<a name="UnifiedEventModel"></a>

## Process and the unified event model

Dynamics 365 Customer Engagement (on-premises) uses a unified event model that is used in both plug-ins (callouts) and in processes. This event processing subsystem adds more flexibility to the execution of processes and plug-ins by introducing the pipeline execution model.  
  
Using this model, processes and plug-ins are executed based on their registration, message type, and a predefined set of configurable parameters. The core platform operations take part in the execution sequence to form a much more reliable and extensible execution model.  
  
<a name="ProcessLifeCycle"></a>

## Process life cycle

The life cycle of a process describes the state transitions from creation through execution. A process can be in one of the following states: Ready, Suspended, Locked, and Completed. The events that occur throughout the lifetime of the process cause a transition from one state to another.  
  
### Workflows

The workflow life cycle is as follows:  
  
1. When you create a workflow, it is in the Draft state. You must activate the workflow before it can run. When you activate a workflow, it subscribes to specific Dynamics 365 Customer Engagement (on-premises) events. When these events are triggered in the platform, a snapshot of the workflow dependencies and input parameters are created and a new asynchronous operation is added to the asynchronous service queue manager. The asynchronous operation represents a workflow execution job and awaits execution in the queue in the Ready state.  
  
2. When the asynchronous operation is processed, a workflow instance, associated with this operation, is created by the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] run-time engine and the state of it is changed from Ready to Locked.  
  
3. The asynchronous operation is updated with the workflow instance state status on each transition. When the asynchronous operation is blocked, the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] run-time engine puts the workflow instance into the Suspended state and removes it from memory. When the Suspended state conditions are satisfied, the workflow instance is loaded back into memory.  
  
4. The workflow execution resumes by putting the workflow instance into a Ready state and then into a Locked state. In the simple scenario, the workflow instance moves to a Completed state when all workflow activities have completed successfully.  
  
The state of asynchronous operations can also be changed by the user. For example, an asynchronous operation that is in a Suspended state can explicitly be restarted by the user.  
  
### Dialogs

A dialog life cycle is as follows:  
  
1. When you create a dialog, it is in the Draft state. You must activate the dialog before it can be run. A dialog can be run from its primary entity form and grid, or directly by using the URL of the dialog. For more information, see [Start a dialog by using a URL](actions-dialogs.md#StartDialog).  
  
1. Every time that you run a dialog, a process session instance is created for the dialog. As you progress with running the dialog, the process session entity is updated with the actions performed during the running of the dialog.  
  
1. If you completed running the dialog successfully, the corresponding process session record is created with a Complete status. If you canceled the dialog without completing it, the corresponding process session record is created with an Incomplete status.  
  
<a name="AsynchService"></a>
  
## Process and the asynchronous service: For workflows only

 The asynchronous service enables you to execute, monitor, and manage various long-running operations, such as bulk import, bulk mail, and workflow processes. To improve performance, scalability, and reliability of Dynamics 365 Customer Engagement (on-premises), these operations are run asynchronously. This means that a requested operation is not processed instantly, but added to a queue and processed by Dynamics 365 Customer Engagement (on-premises) at an appropriate time.  
  
 When an event is raised in the Dynamics 365 Customer Engagement (on-premises) platform pipeline, all workflows that are associated with the event are executed by the asynchronous service. The workflow event handlers are added to the asynchronous queue and processed according to the event execution order.  
  
> [!NOTE]
>  If an asynchronous system job (workflow) fails several times consecutively, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] starts to postpone execution of that particular job for longer and longer time intervals to allow the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator to investigate and resolve the issue . Once the job starts succeeding again, it will resume executing normally.  
  
<a name="Persistence"></a>
  
## Process persistence and shutdown: For workflows only

A workflow can be a long-running business operation that might take hours, weeks, or months to be completed. It can be effectively idle for long periods of time waiting for input from users or other systems.  
  
To improve performance, scalability, and reliability of Dynamics 365 Customer Engagement (on-premises), long-running operations such as workflows use the asynchronous service.  
  
The asynchronous service, as the host of the [!INCLUDE[pn_Windows_Workflow_Foundation](../includes/pn-windows-workflow-foundation.md)] runtime engine, cannot always cache and keep active all objects that accumulate during continued workflow activity. When certain conditions, such as restart or shutdown occur when a workflow is running, the workflow runtime engine uses a persistence service to save the state of the workflow instance onto the disk. The persistence service is also invoked when other conditions occur, such as when a workflow becomes idle and is waiting for some external event to occur. Persisting these idle workflow instances saves memory and greatly increases scalability. If a server that is running the asynchronous service is shut down or if the workflow crashes during execution, the workflow can be restarted from its last persisted point after the server restarts. When the workflow is no longer idle, the state of the workflow instance is restored in memory to the state at the last persisted point.  
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Workflow Persistence](/dotnet/framework/windows-workflow-foundation/workflow-persistence).  
  
### See also  
[Asynchronous Service](asynchronous-service.md)<br />
[Event Framework](/powerapps/developer/common-data-service/event-framework)<br />
[Processes in Dynamics 365 Customer Engagement (on-premises)](automate-business-processes-customer-engagement.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]