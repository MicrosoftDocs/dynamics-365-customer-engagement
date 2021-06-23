---
title: "Sample: Disable a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample shows how to create a user in an Active Directory environment using the SetStateRequest message."
ms.custom: 
ms.date: 1/24/2020
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 082fc88f-a951-41c2-85ae-4b5e69e9917c
caps.latest.revision: 15
author: KumarVivek
ms.author: kvivek
manager: KumarVivek
search.audienceType: 
  - developer

---
# Sample: Disable a user

This sample shows how to disable and enable a system user account in an online or on-premise/IFD environment. Download the complete sample from [Sample: Disable a User](https://github.com/microsoft/PowerApps-Samples/tree/master/cds/orgsvc/C%23/DisableOrEnableUser).

[!INCLUDE[cc-sample-note](./includes/cc-sample-note.md)]

## Prerequisites

[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

The Customer Engagement user account under which you run this program must have the System Administrator role in order to enable/disable a system user.

Before building this sample, open the solution in Visual Studio and select **View** > **Task List**. There are two TODO comments that you must follow to provide the required information about an existing system user in your organization.
  
## Requirements

See [How to run samples](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/README.md) for information about how to run this sample.
  
## Demonstrates  

Demonstrates using <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> to disable and enable a system user. Also shows how to retrieve information about a system user.

To view the summary of the specified system user in Customer Engagement, navigate to **Settings** > **Security** > **Users** and select the target system user account in the list. If desired, choose the **Disabled Users** system view to filter the list of all users. The user's status should be "Disabled".

## Example  
[SampleProgram.cs](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/DisableOrEnableUser/DisableOrEnableUser/SampleProgram.cs)  
[SampleMethod.cs](https://github.com/microsoft/PowerApps-Samples/blob/master/cds/orgsvc/C%23/DisableOrEnableUser/DisableOrEnableUser/SampleMethod.cs)
  
### See also

[User and Team Entities](user-team-entities.md)  
<xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]