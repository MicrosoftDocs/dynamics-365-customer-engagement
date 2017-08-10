---
title: "Oveview of Dialog processes in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: "2017-08-31"
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 4e21904f-5709-441f-904c-62672a11b415
caps.latest.revision: 11
ms.author: "rdubois"
manager: "brycho"
---
# Dialogs overview
Dialogs are a type of process in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that displays the input forms and the data that a user needs at each step while interacting with a customer or following a complex procedure. A dialog can have branching logic that is based on input from the person stepping through a case, phone call, or other customer interaction.  
  
 Dialogs are frequently used in call centers to provide scripts that allow customer facing staff to apply consistent interactions with customers. You can also use dialogs to provide a kind of “wizard” user interface to allow people to perform complex procedures consistently.  
  
 Dialogs provide:  
  
-   Consistent customer interactions and interactive user tasks.  
  
-   Consistent information entry into your organization's database.  
  
-   A way for people in your organization to focus on growing your business, instead of performing repetitive tasks.  
  
 Dialogs display a series of screens based on the responses you enter to the prompts on each screen. The dialog can provide a different set of screens based on the responses you enter. After the dialog is complete, the data is saved and can be reviewed later.  
  
 Unlike workflow processes, a dialog can only be applied to one record at a time.  
  
## Where do I customize dialog processes?  
 You can see the dialogs in your organization by navigating to **Settings** > **Processes** and filtering on processes in the **Dialog** category.  
  
 You can also see the dialogs in your organization by viewing the **Processes** node in the default solution and filtering on processes in the **Dialog** category.  
  
## Dialog properties  
 Every dialog must have the following properties set:  
  
 **Name**  
 The name of the dialog process doesn’t need to be unique, but if you expect you’ll have a lot of dialogs, you may want to use a naming convention to clearly differentiate your processes. You may want to apply standard prefixes to the name of the dialog. The prefix may describe the function of the workflow or the department within the company. This will help you group similar items in the list of dialogs.  
  
 **Entity**  
 Each dialog process must be set to a single entity. You can’t change the entity after the dialog is created.  
  
 **Category**  
 This property establishes that this is a Dialog process.  
  
 Unlike workflow processes, dialogs do not have scope. They are available to the entire organization. If a user runs a dialog that creates or updates record, the user must have privileges to perform those actions outside the dialog. Each dialog will create a Dialog session record and the user must have privileges to create and update those records.  
  
## Activating dialogs  
 Before you can use a dialog, you have to activate it. A dialog can only be activated or deactivated by the dialog owner. You can reassign a dialog by changing the owner. You can do this on the **Administration** tab.  
  
 Dialogs can only be edited while they are deactivated. If you need to edit a dialog that is owned by another user, have them deactivate it and assign it to you.  
  
### See also  
 [Configure dialog processes](../customize/configure-dialog-processes.md)   
 [Actions overview](../customize/actions.md)   
 [Business process flows overview](../customize/business-process-flows-overview.md)   
 [Workflow processes overview](../customize/workflow-processes.md)
