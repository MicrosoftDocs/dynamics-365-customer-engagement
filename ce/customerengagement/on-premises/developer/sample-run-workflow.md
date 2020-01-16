---
title: "Sample: Run a workflow (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This sample demonstrates how to programmatically execute a workflow by using the ExecuteWorkflowRequest"
ms.custom: 
ms.date: 1/14/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: c32a634c-3e01-42cd-b3ed-d1a89586b1cc
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Run a workflow

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
 The sample demonstrates how to programmatically execute a workflow using <xref:Microsoft.Crm.Sdk.Messages.ExecuteWorkflowRequest>.  
  
## Example  
[ExecuteWorkflow.cs](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/Workflow/Workflow/ExecuteWorkflow.cs)
  
### See also  
 [Sample code for workflows](sample-code-processes.md)   
 [Sample: Create, Retrieve, Update, and Delete a Dialog](sample-create-retrieve-update-delete-dialog.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises)(formerly Workflows)](automate-business-processes-customer-engagement.md)   
 <xref:Microsoft.Crm.Sdk.Messages.ExecuteWorkflowRequest>   
<xref:Microsoft.Xrm.Sdk.IOrganizationService>
