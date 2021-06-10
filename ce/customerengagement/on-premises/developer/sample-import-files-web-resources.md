---
title: "Sample: Import files as web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The sample provides a simplified example of importing files as web resources."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 0f9bca5b-b876-4f68-8e4e-e844da8598d6
author: JimDaly
ms.author: Nkrb
manager: kvivek
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Import files as web resources

When you develop a large number of files to use as Web resources you can save yourself the work of manually adding them through the application. Many Web resources can be developed and tested outside of Dynamics 365 for Customer Engagement and then imported.  
  
 This sample provides a simplified example of this process. For a more complex sample that provides a WPF application you can use to import Web resources, see the [Sample: Web Resource Utility](sample-web-resource-utility.md).  

[!include[cc-sample-note](includes/cc-sample-note.md)]
 
 You can download the sample from [here](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/ImportWebResources). 

## How to run this sample

[!include[cc-how-to-run-samples](includes/cc-how-to-run-PA-samples.md)]

## What this sample does

This sample will show how to use the `SolutionUniqueName` optional parameter to associate a web resource with a specific solution when it is created.

## How this sample works

In order to simulate the scenario described in [What this sample does](#what-this-sample-does), the sample will do the following:

### Setup

1. Checks for the current version of the org.
2. The `CreateRequiredRecords` class creates a publisher and a solution required for the sample when adding the web resources.

### Demonstrate

1. The `XDocument` method reads the descriptive data from the XML files. 
1. The `WebResource` is used to set the web resource properties.
1. The `CreateRequest` method is used to add optional parameters.

### Clean up

Display an option to delete the sample data that is created in [Setup](#setup). The deletion is optional in case you want to examine the entities and data created by the sample. You can manually delete the records to achieve the same result.



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]