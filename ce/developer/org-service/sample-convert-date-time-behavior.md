---
title: "Sample: Convert date and time behavior (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to use the ConvertDateAndTimeBehaviorRequest message to convert the UTC value to DateOnly value of the date and time attribute in Dynamics 365 Customer Engagement that exist in the system before you changed the behavior of the attribute from UserLocal to DateOnly."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "samples"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cd9d4906-9f98-4c7e-9e0a-9b40ed4dc7f2
caps.latest.revision: 18
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Sample: Convert date and time behavior

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This sample demonstrates how to use the <xref:Microsoft.Xrm.Sdk.Messages.ConvertDateAndTimeBehaviorRequest> message to convert the UTC value to DateOnly value of the date and time attribute in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Customer Engagement that exist in the system before you changed the behavior of the attribute from `UserLocal` to `DateOnly`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Convert behavior of existing date and time values in the database](../behavior-format-date-time-attribute.md#convert-behavior-of-existing-date-and-time-values-in-the-database).  
  
 This sample is for [!INCLUDE[pn_crm_online_2015_update_1](../../includes/pn-crm-online-2015-update-1.md)] and [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] (on-premises). This is available to download from [Convert date and time behavior](http://go.microsoft.com/fwlink/p/?LinkId=534240).  
  
## Prerequisites  
  
1.  Have access to a [!INCLUDE[pn_crm_online_2015_update_1](../../includes/pn-crm-online-2015-update-1.md)] or [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] organization.  
  
2.  Have the System Administrator role in your Dynamics 365 organization to be able to use the <xref:Microsoft.Xrm.Sdk.Messages.ConvertDateAndTimeBehaviorRequest> message that is demonstrated in this sample. Otherwise, this sample will fail.  
  
3.  [Download](http://go.microsoft.com/fwlink/p/?LinkId=534240) the DateTimeAttributeBehavior[!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)] project.  
  
4.  Open the DateTimeAttributeBehavior Visual Studio project and install Microsoft.CrmSdk.CoreAssemblies version 7.1.0-preview NuGet Package. See [Install NuGet packages](../sample-insert-update-record-upsert.md#install-nuget-packages) later for instructions.  
  
     After you install the NuGet packages, see [Run the sample](../sample-insert-update-record-upsert.md#run-the-sample) for instructions on how to run the sample and what to expect.  
  
<a name="BKMK_WhatThisSampleDoes"></a>   
## What this sample does  
  
1.  The `ConvertDateandTimeBehavior` class `Run` method checks if you are running the appropriate version of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] for the sample.  
  
2.  The `CreateRequiredRecords` method creates the required records for the sample:  
  
    1.  Creates a sample date and time attribute for the Account entity with the `UserLocal` behavior.  
  
    2.  Creates a sample account record with March 31, 2015 11:00 PM UTC value in the new date and time attribute.  
  
    3.  Changes the behavior of the date and time attribute to `DateOnly`.  
  
    4.  Creates another sample account record with March 31, 2015 11:00 PM UTC value in the new date and time attribute. Because the attribute is now `DateOnly`, the time part is ignored and stored in the system as March 31, 2015 00:00:00.  
  
    5.  Retrieves the value in the date and time attribute in both the account records. Because the behavior is changed, both the values are displayed as March 31, 2015 00:00:00. However, the value in the first account record continues to be in the UTC (March 31, 2015 11:00 PM) in the database.  
  
3.  Runs the <xref:Microsoft.Xrm.Sdk.Messages.ConvertDateAndTimeBehaviorRequest> SDK message to create an async job for converting the UTC values in the date and time attribute to a `DateOnly` value. The conversion rule in the SDK message converts the value as per the India Standard Time (IST) time zone code in Dynamics 365 (190).  
  
 [!code-csharp[DateTimeAttributeBehavior#ConvertDateandTimeBehavior1](../../snippets/csharp/CRMV8/datetimeattributebehavior/cs/convertdateandtimebehavior1.cs#convertdateandtimebehavior1)]  
  
4.  Retrieves the value in the date and time attribute in both the account records after the conversion. The UTC value in the first account record gets converted to April 1, instead of March 31 because the conversion happened as per the India Standard Time (IST) time zone. The value in the second account record is not affected because it was already a `DateOnly` value.  
  
5.  Finally, the `DeleteRequiredRecords` method prompts you to delete the entity records and the custom date and time attribute created during the sample run:  
  
    1.  Type `y`, and press ENTER to delete the entity records and custom attribute from your organization.  
  
    2.  Type `n`, and press ENTER to leave the entity records and custom attribute in your organization. You will have to manually delete them later if you want to return to the original state.  
  
<a name="BKMK_installNuget"></a>   
## Install NuGet packages  
 Use the following steps to install the required assemblies for this sample:  
  
1.  Download this sample and extract the files.  
  
2.  Navigate to the C# folder and open the DateTimeAttributeBehavior.sln file using Visual Studio.  
  
3.  In Visual Studio, right-click the DateTimeAttributeBehavior project and chose **Manage NuGet Packages**.  
  
4.  For the preview release, make sure to select **Include Prerelease** rather than **Stable Only** in the search criteria. Then search for “Microsoft Dynamics CRM 2015 SDK core assemblies”. Make sure you select the 7.1.0-preview version.  
  
5.  Click **Install**. You’ll need to accept the license terms to complete installing this package.  
  
<a name="BKMK_runSample"></a>   
## Run the sample  
  
1.  In Visual Studio, with the solution open and the necessary [!INCLUDE[tn_nuget](../../includes/tn-nuget.md)] packages installed, press F5.  
  
2.  If you have not previously run one of the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] managed code samples before, you’ll need to enter information to run the code, otherwise enter the number for one of the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] servers you have previously set up.  
  
    |Prompt|Description|  
    |------------|-----------------|  
    |Enter a Dynamics 365 server name and port [crm.dynamics.com]|Type the name of your Dynamics 365 server. The default is [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] (crm.dynamics.com) in North America.<br /><br /> Example: <br />crm5.dynamics.com|  
    |Is this organization provisioned in Microsoft online services (y/n) [n]|Type **y** if this is a Microsoft online services provisioned organization. Otherwise, type **n**.|  
    |Enter domain\username|Type your Microsoft account.|  
    |Enter password|Type your password. The characters will show as “*” in the window. Your password is securely saved in the Microsoft Credential Manager for later reuse.|  
    |Specify an organization number (1-n) [1]|From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.|  
  
3.  The sample will perform the operations described in [What this sample does](../sample-insert-update-record-upsert.md#what-this-sample-does) and may prompt you with additional options.  
  
4.  When the sample is complete, press ENTER to close the console window.  
  
### See also  
 [Behavior and format of the date and time attribute](../behavior-format-date-time-attribute.md)   
 <xref:Microsoft.Xrm.Sdk.Messages.ConvertDateAndTimeBehaviorRequest>   
 [Customize entity attribute metadata](../customize-entity-attribute-metadata.md)
