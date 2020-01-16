---
title: "Sample: Synchronize data with external systems using change tracking (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This sample code shows how to retrieve changes from an entity and synchronize data with external systems by using the RetrieveEntityChangesRequest message"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 14464805-0405-4e19-9d95-6c031de8ae3f
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Synchronize data with external systems using change tracking

This sample code shows how to retrieve changes from an entity and synchronize data with external systems by using the `RetrieveEntityChangesRequest` message. For more information about the feature that this sample demonstrates, see [Use change tracking to synchronize data with external systems](use-change-tracking-synchronize-data-external-systems.md).  

 This sample requires [!INCLUDE[pn_crm_8_1_0_both](../includes/pn-crm-8-1-0-both.md)] or later . This sample is available to download from [Synchronize data with external systems using change tracking](https://go.microsoft.com/fwlink/p/?LinkId=533957).  

## Prerequisites  

1. Have access to a [!INCLUDE[pn_crm_8_1_0_both](../includes/pn-crm-8-1-0-both.md)] or later organization.  

2. Download the ChangeTrackingSample Visual Studio project.  

3. Open the ChangeTrackingSample Visual Studio project and install the latest Microsoft.CrmSdk.CoreAssemblies NuGet Package. See [Install NuGet packages](#BKMK_install) for instructions.  

4. After you install the NuGet packages, see [Run the sample](#BKMK_runSample) for instructions on how to run the sample and what to expect.  

<a name="BKMK_whatsampledoes"></a>   
## What this sample does  

1. The `ChangeTrackingSample` class `Run` method calls the `ImportChangeTrackingSolution` method which first detects whether the ChangeTrackingSample managed solution is already installed. If it is not, the ChangeTrackingSample_1_0_0_0_managed.zip file is imported to install this managed solution.  

    This managed solution contains a custom sample_book entity that is used by this sample. This entity has a sample_bookcode alternate key that creates a unique constraint on the values stored in that attribute.  

2. The `WaitForEntityAndKeysToBeActive` method is necessary because the alternate keys required for this sample may not be ready immediately after the ChangeTrackingSample solution is installed. This method polls the metadata for the sample_book entity to delay the execution of the rest of the sample until the alternate keys are ready.  

3. `CreateRequiredRecords` method generates 10 records in the sample_book entity.  

4. The first time the `RetrieveEntityChangesRequest` is called; it performs an initial synchronization and retrieves all the records in the entity along with the version number and caches the retrieved records.  

5. After caching the initial records, the program asks if you want to view the sample_book entity records. If you respond with ‘y’ the program will attempt to open [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to a view showing the newly created records.  

6. `UpdateRecords` method adds ten new records, updates an existing record and deletes a record in the sample_book entity.  

7. After updating the records, the program resets the paging information and instantiates the cache objects.  

8. When `RetrieveEntityChangesRequest` is called again, it only retrieves the updated records since the last synchronization.  

9. After retrieving the changes, the program will ask if you want to view the sample_book entity records. If you respond with ‘y’ the program will attempt to open [!INCLUDE[pn_Internet_Explorer](../includes/pn-internet-explorer.md)] to a view showing the newly created records.  

10. Finally, the `DeleteChangeTrackingSampleSolution` will prompt you to delete the ChangeTrackingSample managed solution.  

     If you select “y”, the managed solution will be deleted including the sample_book entity and all the data in that entity. Your organization will be left with nothing added to it.  

     If you select “n”, you can inspect the details of the solution including the data created by the sample. But you must manually delete the managed solution to return your organization to the original state.  

<a name="BKMK_install"></a>   
## Install NuGet packages  
 Use the following steps to install the required assemblies for this sample:  

1.  Download this sample and extract the files.  

2.  Navigate to the C# folder and open the ChangeTrackingSample.sln file using Visual Studio.  

3.  In Visual Studio, right-click the ChangeTrackingSample project and chose **Manage NuGet Packages**.  

4.  For the preview release, make sure to select **Include Prerelease** rather than **Stable Only** in the search criteria. Then search for “Microsoft Dynamics CRM 2016 SDK core assemblies”. Make sure you select the latest version.  

5.  Click **Install**. You’ll need to accept the license terms to complete installing this package.  

<a name="BKMK_runSample"></a>   
## Run the sample  

1. In Visual Studio, with the solution open and the necessary NuGet packages installed, press F5.  

2. If you have not previously run one of the Dynamics 365 Customer Engagement managed code samples before, you’ll need to enter information to run the code, otherwise enter the number for one of the Dynamics 365 Customer Engagement servers you have previously set up.  


   |                                 Prompt                                  |                                                                                                                                                                                      Description                                                                                                                                                                                       |
   |-------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |      Enter a Dynamics 365 Customer Engagement server name and port [crm.dynamics.com]       | Type the name of your Dynamics 365 Customer Engagement server. The default is [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] (crm.dynamics.com) in North America.<br /><br /> Example: <br />myservername<br />myprefix.myservername:5500<br />crm5.dynamics.com<br /><br /> Don’t include the name of your organization or Internet protocol (http or https). You’ll be prompted for that later. |
   |  Is this server configured for Secure Sockets Layer (https) (y/n) [n]   |                                                                                                                                            Type **y** if the URL you use to access Dynamics 365 Customer Engagement begins with https://, otherwise type **n**.                                                                                                                                            |
   | Is this organization provisioned in Microsoft online services (y/n) [n] |                                                                                                                                           Type **y** if this is a Microsoft online services provisioned organization. Otherwise, type **n**.                                                                                                                                           |
   |                          Enter domain\username                          |                                                                                                       Type your Microsoft account. <br />For [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-onprem.md)], type your network domain and user name separated by a backslash (\\).                                                                                                        |
   |                             Enter password                              |                                                                                                                Type your password. The characters will show as “\*” in the window. Your password is securely saved in the Microsoft Credential Manager for later reuse.                                                                                                                |
   |                Specify an organization number (1-n) [1]                 |                                                                                                                From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.                                                                                                                |


3. The sample will perform the operations described in [What this sample does](#BKMK_whatsampledoes) and may prompt you with additional options.  

4. When the sample is complete, press ENTER to close the console window.  

### See also  
 [Use change tracking to synchronize data with external systems](use-change-tracking-synchronize-data-external-systems.md)
