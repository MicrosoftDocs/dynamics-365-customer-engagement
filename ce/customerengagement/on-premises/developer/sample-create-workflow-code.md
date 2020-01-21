---
title: "Sample: Create a workflow in code (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
descrption: The sample shows how to programmatically create an asynchronous workflow in code instead of using a workflow editor or designer.
ms.custom: 
ms.date: 1/14/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 7105761b-9710-4ad1-a3ee-b7dd58287c81
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Create a workflow in code

[!INCLUDE[cc-sample-note](./includes/cc-sample-note.md)]

Download the sample: [Workflow](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/Workflow).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  

To obtain a local copy of all samples, do the following:
1. Download or clone the  [Samples](https://github.com/microsoft/PowerApps-Samples) repo so that you have a local copy.
2. (Optional) Edit the cds/App.config file to define a connection string specifying the instance/org you want to connect to.
3. Open the sample solution in Visual Studio and press **F5** to run the sample. After you specify a connection string in cds/App.config, any sample you run will use that connection information.

If you do not specify a connection string in cds/App.config file, a dialog will open each time you run the sample and you will need to enter information about which instance/org you want to connect to and which credentials you want to use. This dialog will cache previous connections so that you can choose a previously used connection.

Consult the sample's [README](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/Workflow/README.md) for additional information about the sample.
  
## Demonstrates  
 The sample shows how to programmatically create an asynchronous workflow in code instead of using a workflow editor or designer.  

## Example  
[CreateAWorkflow.cs](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/Workflow/Workflow/CreateAWorkflow.cs) 
  
### See also  
 [Sample code for workflows](sample-code-processes.md)   
 [Sample: Create a real-time workflow in code](sample-create-real-time-workflow-code.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 [Workflow and Process Entities](workflow-process-entities.md)
