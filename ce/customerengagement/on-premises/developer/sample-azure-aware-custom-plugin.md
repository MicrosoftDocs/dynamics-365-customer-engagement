---
title: "Sample: Azure aware custom plug-in | MicrosoftDocs"
description: "The plug-in demonstrates how to obtain the execution context and the tracing service from the service provider parameter of the Execute method. The plug-in then posts the context to the Azure Service Bus endpoint and writes information to the trace log to facilitate debugging."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - azure
ms.assetid: 3a1fcf7e-1e86-4d55-b11f-38ee179b9f1d
caps.latest.revision: 23
author: JimDaly
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer

---

# Sample: Azure aware custom plug-in

The plug-in demonstrates how to obtain the execution context and the tracing service from the service provider parameter of the `Execute` method. The plug-in then posts the context to the Azure Service Bus endpoint and writes information to the trace log to facilitate debugging. You can download the sample from [here](https://github.com/Microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/Azureplugin).

## How to run this sample

1. Download or clone the [Samples](https://github.com/Microsoft/PowerApps-Samples) repo so that you have a local copy.
2. Open the sample solution in Visual Studio and sign the assembly with a key.
3. Register the plug-in using the **Plugin Registration Tool**.

>[!NOTE]
> This sample requires a service endpoint to be created first, and its ID passed to the plug-in constructor through the unsecure configuration parameter when the plug-in step is registered.

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]