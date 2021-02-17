---
title: "Walkthrough: Update a service endpoint from ACS to SAS authorization (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The walkthrough demonstrates updating a service endpoint from Access Control Service (ACS) to Shared Access Signature (SAS) authorization."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: a1a4fe6f-be17-4a75-af6c-cd1ee901b868
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Walkthrough: Update a service endpoint from ACS to SAS authorization

Shared Access Signature (SAS) is the recommended authorization method for the Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] integration as its use results in improved authorization performance compared to Access Control Service (ACS), and SAS is supported on all [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] deployments without any special server configuration. You can update existing service endpoint entity records in a Dynamics 365 Customer Engagement (on-premises) organization from ACS to SAS authorization by using the Plug-in Registration Tool and following these steps.  
  
> [!NOTE]
> [!INCLUDE[cc_feature_included_with_update_8_1_0_admins](../includes/cc-feature-included-with-update-8-1-0-admins.md)] The Plug-in Registration Tool from the v8.1 or later [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] SDK includes SAS support.  
  
## Step 1: Update the messaging entity  
 You'll need to update your [!INCLUDE[pn_Windows_Azure](../includes/pn-windows-azure.md)] messaging entity that was configured for ACS authorization, for example a queue or topic, to be properly configured for SAS. This is simple to do as you just need to add a SAS shared access policy.  
  
### Perform the update  
  
1. Sign in to the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)][Classic portal](https://manage.windowsazure.com).  
  
2. Navigate to the messaging entity that you plan to update.  
  
3. Select the entity and then select **CONFIGURE**.  
  
4. Create a shared access policy and specify **Send** permission at a minimum. **Listen** permission is required for a two-way endpoint contract.  
  
5. Verify the messaging entity's SAS connection information. It should have a connection string.  
  
## Step 2: Update the service endpoint  
 Now go ahead an update the service endpoint entity record in your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization with the SAS information of your messaging entity.  
  
### Perform the update  
  
1. Run the Plug-in Registration Tool and sign in to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organization containing the service endpoint.  
  
2. Select the service endpoint and then select **Update**.  
  
3. Enter a value for the **SAS Key Name** and the **SAS Key**. These are obtained from the messaging entity's connection string that is available in the [!INCLUDE[pn_azure_shortest](../includes/pn-azure-shortest.md)] management portal. Look for SharedAccessKeyName and `SharedAccessKey` values in the connection string.  
  
4. Select **Save**.  
  
### See also  
 [Azure extensions for Dynamics 365 Customer Engagement](azure-extensions.md)   
 [Azure integration with Dynamics 365 Customer Engagement](azure-integration.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]