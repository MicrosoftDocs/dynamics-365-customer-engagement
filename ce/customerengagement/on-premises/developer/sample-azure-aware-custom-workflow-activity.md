---
title: "Sample: Azure aware custom workflow activity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to write a custom workflow activity that can post the data context from the current Dynamics 365 Customer Engagement operation to the Azure Service Bus"
ms.custom: 
ms.date: 12/10/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - azure
ms.assetid: 089bc521-c50e-4030-bcd1-7b71e0d34557
caps.latest.revision: 32
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Azure aware custom workflow activity

This sample obtains the data context from the current operation and posts it to the Azure Service Bus.You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/Azurecustomworkflowactivity).

## Requirements

You must configure Dataverse to connect with Azure before registering and executing this sample custom workflow activity. More information: [Configure Microsoft Azure Integration with Dataverse](configure-azure-integration.md).

Notice the `Input id` required argument in the code. When you add this activity to a workflow, you must provide the GUID of a Azure service endpoint.

When registering this custom workflow activity with Dataverse, you must register it in the sandbox (partial trust).

## How to run samples

1. Download or clone the [Samples](https://github.com/Microsoft/PowerApps-Samples) repo so that you have a local copy.
2. Register the workflow activity.

## What this sample does

This sample shows how to write a custom workflow activity that can post the data context from the current Dataverse operation to the Azure Service Bus. The posting of the data context is done through the <xref:Microsoft.Xrm.Sdk.IServiceEndpointNotificationService.Execute(Microsoft.Xrm.Sdk.EntityReference,Microsoft.Xrm.Sdk.IExecutionContext)> method.


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]