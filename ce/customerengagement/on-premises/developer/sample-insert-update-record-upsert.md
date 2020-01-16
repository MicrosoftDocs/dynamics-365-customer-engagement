---
title: "Sample: Insert or update a record using Upsert (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample code shows how to insert or update records by using the Upsert message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5aac6430-5d98-4e50-94f9-c2f6ce5cee62
caps.latest.revision: 24
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Insert or update a record using Upsert

This sample code shows how to insert or update records by using the `Upsert` message. For more information about the feature that this sample demonstrates, see [Use Upsert to insert or update a record](use-upsert-insert-update-record.md).  

 This is available to download from [Insert or update a record using Upsert](https://go.microsoft.com/fwlink/p/?LinkId=532924).  

## Prerequisites  

1. Have access to a [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] or [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)] organization.  

2. Download the UpsertSample Visual Studio project.  

3. Open the UpsertSample Visual Studio project and install Microsoft.CrmSdk.CoreAssemblies version 8.0.0-preview or later NuGet Package. See [Install NuGet packages](sample-insert-update-record-upsert.md#BKMK_installNuget) for instructions.  

4. After you install the NuGet packages, see [Run the sample](sample-insert-update-record-upsert.md#BKMK_runSample) for instructions on how to run the sample and what to expect.  

<a name="BKMK_WhatThisSampleDoes"></a>   
## What this sample does  

1. The `ProductUpsertSample` class `Run` method calls the `ImportUpsertSampleSolution` method which first detects whether the UpsertSample managed solution is already installed. If it is not, the UpsertSample_1_0_0_0_managed.zip file is imported to install this managed solution.  

    This managed solution contains a custom sample_product entity that is used by this sample. This entity has a sample_productcode alternate key that creates a unique constraint on the values stored in that attribute.  

2. The `WaitForEntityAndKeysToBeActive` method is necessary because the alternate keys required for this sample may not be ready immediately after the UpsertSample solution is installed. This method polls the metadata for the sample_product entity to delay the execution of the rest of the sample until the alternate keys are ready.  

3. The first time the `ProcessUpsert` method is called it processes data in the newsampleproduct.xml file to represent new products. The <xref:Microsoft.Xrm.Sdk.Messages.UpsertRequest> is passed to the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method to create 13 new records.  

    The <xref:Microsoft.Xrm.Sdk.Messages.UpsertResponse>.<xref:Microsoft.Xrm.Sdk.Messages.UpsertResponse.RecordCreated> property returns true to indicate that new records were created.  

    Before the `ProcessUpsert` method completes, the program will ask if you want to view the sample product entity records. If you respond with ‘y’ the program will attempt to open [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to a view showing the newly created records.  

4. The second time the `ProcessUpsert` method is called it processes data in the updatedsampleproduct.xml file to represent updates to products previously created. The `Upsert` message is used to update 6 records. The `UpsertResponse`.`RecordCreated` property returns false showing that records were updated.  

    Again, the `ProcessUpsert` method will ask if you want to view the records in the browser. If you already have the view open, you can just refresh the view to observe the changes.  

5. Finally, the `DeleteUpsertSampleSolution` will prompt you to delete the Upsert Sample managed solution.  

    If you choose “y”, the managed solution will be deleted including the sample_product entity and all the data in that entity. Your organization will be left with nothing added to it.  

    If you choose “n”, you can inspect the details of the solution including the data created by the sample. But you must manually delete the managed solution to return your organization to the original state.  

<a name="BKMK_installNuget"></a>   
## Install NuGet packages  
 Use the following steps to install the required assemblies for this sample:  

1.  Download this sample and extract the files.  

2.  Navigate to the C# folder and open the UpsertSample.sln file using Visual Studio.  

3.  In Visual Studio, right-click the UpsertSample project and click **Manage NuGet Packages**.  

4.  For the preview release, make sure to click **Include Prerelease** rather than **Stable Only** in the search criteria. Then search for “Microsoft Dynamics CRM 2016 SDK core assemblies”. Make sure you select the 8.0.0-preview or later version.  

5.  Click **Install**. You’ll need to accept the license terms to complete installing this package.  

<a name="BKMK_runSample"></a>   
## Run the sample  

1. In Visual Studio, with the solution open and the necessary NuGet packages installed, press F5.  

2. If you have not previously run one of the Dynamics 365 Customer Engagement managed code samples before, you’ll need to enter information to run the code, otherwise enter the number for one of the Dynamics 365 Customer Engagement servers you have previously set up.  


   |                                                   Prompt                                                    |                                                                                                                                                                                       Description                                                                                                                                                                                        |
   |-------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |                        Enter a Dynamics 365 Customer Engagement server name and port [crm.dynamics.com]                         | Type the name of your Dynamics 365 Customer Engagement server. The default for [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] is crm.dynamics.com in North America.<br /><br /> Example: <br />myservername<br />myprefix.myservername:5500<br />crm5.dynamics.com<br /><br /> Don’t include the name of your organization or Internet protocol (http or https). You’ll be prompted for that later. |
   |                    Is this server configured for Secure Sockets Layer (https) (y/n) [n]                     |                                                                                                                                             Type **y** if the URL you use to access Dynamics 365 Customer Engagement begins with https://, otherwise type **n**.                                                                                                                                             |
   | Is this organization provisioned in [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] (y/n) [n] |                                                                                                                          Type **y** if this is a [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)] provisioned organization. Otherwise, type **n**.                                                                                                                          |
   |                                            Enter domain\username                                            |                                                                                                                                Type your Microsoft account. <br />For Dynamics 365 Customer Engagement, type your network domain and user name separated by a backslash (\\).                                                                                                                                |
   |                                               Enter password                                                |                                                                                                                 Type your password. The characters will show as “\*” in the window. Your password is securely saved in the Microsoft Credential Manager for later reuse.                                                                                                                 |
   |                                  Specify an organization number (1-n) [1]                                   |                                                                                                                 From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.                                                                                                                 |


3. The sample will perform the operations described in [What this sample does](sample-insert-update-record-upsert.md#BKMK_WhatThisSampleDoes) and may prompt you with additional options.  

4. When the sample is complete, press **Enter** to close the console window.  

### See also  
 [Use Upsert to insert or update a record](use-upsert-insert-update-record.md)
