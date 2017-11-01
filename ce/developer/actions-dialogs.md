---
title: "Actions on dialogs (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "This topic describes the actions you can perform on dialogs using the Dynamics 365 Customer Engagement web services (SDK). "
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "dialogs, dialogs, actions"
ms.assetid: dec79d11-75fc-4a1c-ae50-3b5d3d237fd7
caps.latest.revision: 29
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Actions on dialogs

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This topic describes the actions you can perform on dialogs.  

<a name="DialogRelated"></a>   

## Dialog-related activities

 These activities are available as steps in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement Process Designer.  

### Query [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Data

 Enables you to define query variables that can be used to query [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] data. 
These query variables can either have pre-defined values or can be parameterized so that they accept values at the runtime, 
and fetch records accordingly.  

 You can parameterize a query variable by using the **Modify Query Variables** tab on the **Define Query** page, 
and then use the dynamic values section on the query form to associate the prompt and response variables with the query variables.  

 The query variable defined using the **Query Dynamics 365 Data** step is available for all the prompts and responses from the point where they 
have been defined in the dialog definition.  

### Assign Value

 Enables you to perform simple arithmetic (increment, decrement, and multiply) and string (append) operations on the variables and input arguments 
in dialogs. You can also use the **Assign Value** step to clear any value that is stored in the variables or input parameters.  

### Link Child Dialog

 You can specify a dialog as a child dialog, and invoke it from within another dialog (parent) by using the **Link Child Dialog** step in the parent 
dialog.  

### Stop Dialog

 Enables you to end a dialog at a particular stage in the dialog flow. This step can be used in any conditional statement where you want a dialog to 
end at that point based on the response from the user.  

<a name="WorkflowRelated"></a>   

## Workflow-related activities

 The following workflow-related activities can be used for dialogs: **Create Record**, **Update Record**, **Assign Record**, **Update Record**, 
**Send E-mail**, **Start Child Workflow**, and **Change Status**.  

<a name="CustomActivities"></a>   

## Custom workflow activities

 You can create custom workflow activities to extend the dialogs in [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]. For detailed 
information about custom workflow activities, see [Custom Workflow Activities](custom-workflow-activities-workflow-assemblies.md).  

<a name="StartDialog"></a>   

## Start a dialog by using a URL

 You can start an activated dialog by specifying the URL of the dialog. To do so, you must specify the URL in the following format:  

```
http://CRMServer_Name/Org_Name/cs/dialog/rundialog.aspx?DialogId=DialogID&EntityName=EntityLogicalName&ObjectId=EntityObjectId  
```

 Where,  

-   _CRMServer_Name_ is the name of your [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] server.  

-   _Org_Name_ is the organization name.  

-   _DialogID_ is GUID of the dialog that you want to run.  

-   _EntityLogicalName_ is the entity logical name of the primary entity of the dialog that you want to run.  

-   _EntityObjectId_ is the GUID of the primary entity record.  
    A sample URL to start a dialog:  
    `http://crmserver/AdventureWorksCycle/cs/dialog/rundialog.aspx?DialogId=9F53D2D8-AC54-46A6-A190-F23DE6677C65&EntityName=contact&ObjectId=41D1884E-B4B6-DF11-BF5E-00155DB05986`  
     

### See also

 [Work with Dialogs](use-dialogs-guided-processes.md)  
 [Understanding Dialogs](understand-dialogs.md)  
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a Dialog](sample-create-retrieve-update-delete-dialog.md)
