---
title: "Sample: Work with business process flows (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to programmatically work with business process flows such as retrieving the business process flow instances for an entity record, retrieving active path for a business process flow instance and its process stages, and changing the active stage."
ms.custom: ""
ms.date: 04/05/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7d378504-b4b2-4a09-838c-69ee094072ef
caps.latest.revision: 15
author: "KumarVivek"
ms.author: "kvivek"
---
# Sample: Work with business process flows

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

This sample demonstrates how to programmatically work with business process flows such as retrieving the business process flow instances for an entity record, retrieving active path for a business process flow instance and its process stages, and changing the active stage. For information about these concepts, see [Model business process flows](model-business-process-flows.md)  

 This sample is for [!INCLUDE[pn_crm_8_2_0_both](../includes/pn-crm-8-2-0-both.md)], and is available to download from [Sample: Work with business process flows](https://go.microsoft.com/fwlink/p/?LinkId=846108).  

<a name="BKMK_Prerequisites"></a>   
## Prerequisites  
 Before you can run the sample:  

1. Have access to a [!INCLUDE[pn_crm_8_2_0_both](../includes/pn-crm-8-2-0-both.md)] or later organization.  

2. Have appropriate privileges on the Lead, Opportunity, and Workflow entities and business process  flow definition entity records used in this sample.  

3. Have [!INCLUDE[pn_microsoft_visual_studio_2015](../includes/pn-microsoft-visual-studio-2015.md)] or later to run the sample.  

4. Have Internet connection to download the sample project and to restore the NuGet packages used in the sample project.  

<a name="BKMK_WhatThisSampleDoes"></a>   
## What this sample does  

1.  Creates a sample Lead record. This automatically creates an instance of the "Lead To Opportunity Sales Process" business process flow for the Lead record.  

2.  Converts the Lead record to an Opportunity record.  


4.  Retrieves the business process flow instances associated with the "Opportunity" record using the `RetrieveProcessInstances` message. The first record in the returned collection is the active business process flow  instance for the opportunity record, which is "Lead To Opportunity Sales Process" in this case.  

5.  Retrieves the active path and the process stages for the "Lead To Opportunity Sales Process" instance using the `RetrieveActivePath` message.  

6.  Retrieves the currently active stage for the "Lead To Opportunity Sales Process" instance, and prompts the user whether to move to the next stage. On confirmation to move, sets the next stage in the active path as the active stage for the "Lead To Opportunity Sales Process" instance.  

7.  Finally, prompts the user whether to delete the records created during the sample run.  

     Here is the output of the sample:  

    ![Sample output](media/work-with-bpf-sample-output.png "Sample output")  

<a name="BKMK_runSample"></a>   
## Run the sample  

1. [Download](https://go.microsoft.com/fwlink/p/?LinkId=846108) the WorkWithBPF[!INCLUDE[pn_Visual_Studio_short](../includes/pn-visual-studio-short.md)] sample project, and extract it to a folder on your computer.  

2. Locate the `WorkWithBPF.sln` file in your extracted folder, and open it in Visual Studio.  

3. The sample project uses NuGet packages that must be restored before running the sample. Ensure that automatic restore of NuGet packages is enabled in Visual Studio. More information: [Enabling and disabling NuGet package restore](https://go.microsoft.com/fwlink/?linkid=846106)  

    Alternatively, select **Project** > **Manage NuGet Packages**, and select **Restore** to manually restore the packages used in the sample.  

4. Press F5 or select **Debug** > **Start Debugging**.  

5. If you have not previously run one of the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement managed code samples before, you’ll need to enter information to run the code, otherwise enter the number for one of the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] servers you have previously set up.  


   |                                 Prompt                                  |                                                                                             Description                                                                                             |
   |-------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |      Enter a Dynamics 365 server name and port [crm.dynamics.com]       | Type the name of your Dynamics 365 server. The default is [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] (crm.dynamics.com) in North America.<br /><br /> Example: <br />crm5.dynamics.com |
   | Is this organization provisioned in Microsoft online services (y/n) [n] |                                                 Type **y** if this is a Microsoft online services provisioned organization. Otherwise, type **n**.                                                  |
   |                          Enter domain\username                          |                                                                                    Type your Microsoft account.                                                                                     |
   |                             Enter password                              |                      Type your password. The characters will show as “\*” in the window. Your password is securely saved in the Microsoft Credential Manager for later reuse.                       |
   |                Specify an organization number (1-n) [1]                 |                      From the list of organizations shown that you belong to, type the corresponding number. The default is 1, indicating the first organization in the list.                       |


6. The sample will perform the operations described in [What this sample does](sample-insert-update-record-upsert.md#BKMK_WhatThisSampleDoes) and may prompt you with additional options  

7. When the sample is complete, press ENTER to close the console window.  

### See also  
 [Model business process flows](model-business-process-flows.md)
